using System;

namespace Mastermind {
	public class Mastermind {
		#region State
		private readonly MastermindSolver mSolver;
		private readonly GameState gameState;
		#endregion State 

		#region Properties
		public GameState GameState {
			get { return gameState; }
		} /*GameState*/

		internal MastermindSolver MSolver {
			get { return mSolver; }
		} /*MSolver*/
		#endregion Properties

		#region constructors
		public Mastermind(byte tries, byte pins, byte colors, bool computerIsPlaying, ColorSequence secretCombo)
			: this(new GameState(tries, pins, colors, computerIsPlaying, secretCombo)) {
		}

		public Mastermind(byte tries, byte pins, byte colors, bool computerIsPlaying)
			: this(new GameState(tries, pins, colors, computerIsPlaying)) {
		} /*Mastermind*/

		public Mastermind() : this(3, 4, 5, false) {
		} /*Mastermind*/

		public Mastermind(GameState settings) {
			gameState = settings;
			if (GameState.NrOfAvailableColors <= 8 && GameState.NrOfPins <= 8) {
				mSolver = new MastermindSolver(ref gameState);
			}
		} /*Mastermind*/
		#endregion constructors

		#region behavior
		internal Feedback checkAnswerAndGiveFeedbackFor(ColorSequence comboToCheck) {
			if (!answerIsAllowed(comboToCheck))
				throw new ArgumentException();

			Feedback fb = getSecretCombo().compareToColorsequence(comboToCheck);
			GameState.TurnHistory.Add(comboToCheck);
			GameState.FeedbackHistory.Add(fb);

			GameState.updateTurn();

			return fb;
		} /*checkAnswerAndGiveFeedbackFor*/

		private bool answerIsAllowed(ColorSequence guess) {
			for (byte i = 0; i < guess.Length; i++)
				for (byte j = 0; j < guess.Length; j++)
					if (i != j && guess.getColorOnPlace(i) == guess.getColorOnPlace(j))
						return false;

			return true;
		} /*answerAllowed*/

		public bool gameIsOver() {
			return ((GameState.TurnNumber > GameState.NrOfTries) || GameState.Won);
		} /*gameIsOver*/

		public ColorSequence getSecretCombo() {
			return GameState.SecretCombo;
		} /*getSecretCombo*/
		#endregion behavior
	} /*Mastermind*/
} /*Mastermind*/