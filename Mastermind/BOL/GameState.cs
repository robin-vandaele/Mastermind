using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind {
	[Serializable]
	public class GameState {
		#region State
		private readonly Random randomizer = new Random();
		#endregion State 

		#region Autoproperties
		public bool Won { get; private set; } /*Won*/
		public ColorSequence SecretCombo { get; private set; } /*SecretCombo*/
		public List <ColorSequence> TurnHistory { get; private set; } /*TurnTable*/
		public List <Feedback> FeedbackHistory { get; private set; } /*FeedbackTable*/
		public byte TurnNumber { get; private set; } /*TurnNumber*/
		public bool ComputerIsPlaying { get; private set; } /*ComputerPlayer*/
		public byte NrOfTries { get; private set; } /*NrOfTries*/
		public byte NrOfPins { get; private set; } /*NrOfPins*/
		public byte NrOfAvailableColors { get; private set; } /*NrOfAvailableColors*/
		#endregion Autoproperties

		#region Properties
		private Random Randomizer {
			get { return randomizer; }
		} /*Randomizer*/
		#endregion Properties

		#region Constructors
		public GameState(byte tries, byte pins, byte colors, bool computerIsPlaying, ColorSequence secretCombo = null) {
			NrOfTries = tries;
			NrOfPins = pins;
			NrOfAvailableColors = colors;
			ComputerIsPlaying = computerIsPlaying;
			TurnHistory = new List <ColorSequence>();
			FeedbackHistory = new List <Feedback>();
			TurnNumber = 1;
			SecretCombo = secretCombo ?? createSecretCombo();
		} /*GameState*/
		#endregion Constructors

		#region Behavior
		public void updateTurn() {
			TurnNumber++;

			if (FeedbackHistory.Count != 0 && FeedbackHistory.Last().CorrectPositionAndColor == NrOfPins)
				Won = true;
		} /*updateTurn*/

		private ColorSequence createRandomSequence(byte length) {
			ColorSequence randomCombo = new ColorSequence();
			bool[] used = new bool[NrOfAvailableColors];

			for (byte i = 0; i < length; i++) {
				int tmp;
				do {
					tmp = Randomizer.Next(NrOfAvailableColors);
				} while (used[tmp]);
				randomCombo.addLast((Colors)tmp);
				used[tmp] = true;
			}

			return randomCombo;
		} /*createRandomSequence*/

		public ColorSequence createSecretCombo() {
			return createRandomSequence(NrOfPins);
		} /*createSecretCombo*/
		#endregion Behavior
	} /*Settings*/
} /*Mastermind*/