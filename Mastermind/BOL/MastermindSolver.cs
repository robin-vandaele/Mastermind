using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind {
	public class MastermindSolver {
		#region State
		private readonly GameState gameState;
		private readonly List <ColorSequence> goodCombos;
		#endregion State

		#region Properties
		private GameState GameState {
			get { return gameState; }
		} /*GameState*/

		private List <ColorSequence> GoodCombos {
			get { return goodCombos; }
		} /*GoodCombos*/
		#endregion Properties

		#region Constructor
		public MastermindSolver(ref GameState gameState) {
			this.gameState = gameState;
			goodCombos = getAllPossibleCombos(GameState.NrOfPins, gameState.NrOfAvailableColors);
		} /*MastermindSolver*/
		#endregion Constructor

		#region Behavior
		private static IEnumerable <IEnumerable <T>> GetCombinations <T>(IEnumerable <T> list, int length) {
			//http://stackoverflow.com/questions/22894657/get-all-combinations-of-items-in-an-array
			if (length == 1) return list.Select(t => new[] {t}); //StackOverflow 
			IList <T> enumerable = list as IList <T> ?? list.ToList();

			return GetCombinations(enumerable, length - 1).SelectMany(t => enumerable.Where(o => !t.Contains(o)),
				(t1, t2) => t1.Concat(new[] {t2}));
		} /*GetCombinations*/

		private List <ColorSequence> getAllPossibleCombos(byte nrOfPins, byte nrOfColors) {
			List <ColorSequence> combinations = new List <ColorSequence>();
			Colors[] bufferAvailable = new Colors[nrOfColors];

			for (int i = 0; i < bufferAvailable.Length; i++)
				bufferAvailable[i] = (Colors)i;

			IEnumerable <IEnumerable <Colors>> result =
				GetCombinations(bufferAvailable, nrOfPins);

			foreach (IEnumerable <Colors> res in result) {
				List <Colors> tmp = res.ToList();
				ColorSequence clsq = new ColorSequence(tmp);
				combinations.Add(clsq);
			}

			return combinations;
		} /*getAllPossibleCombos*/

		private List <ColorSequence> getAllPossibleCombos() {
			return getAllPossibleCombos(GameState.NrOfPins, GameState.NrOfAvailableColors);
		} /*getAllPossibleCombos*/

		private ColorSequence getNextGuess(Feedback fb) {
			removeBadCombosFromGoodCombos(fb, GameState.TurnHistory.Last());

			try {
				return GoodCombos[new Random().Next(0, GoodCombos.Count)];
			} catch (ArgumentOutOfRangeException) {
				throw new ArgumentOutOfRangeException();
			}
		} /*getNextGuess*/

		private void removeBadCombosFromGoodCombos(Feedback fb, ColorSequence turn) {
			GoodCombos.Remove(GoodCombos.Find(combo => combo.Equals(turn)));
			GoodCombos.RemoveAll(combo => !combo.compareToColorsequence(turn).Equals(fb));
		} /*removeBadCombosFromGoodCombos*/

		public ColorSequence makeGuess(Feedback fb = null) {
			ColorSequence guess;
			if (fb == null) {
				Colors[] buffer = new Colors[GameState.NrOfPins];

				for (byte i = 0; i < buffer.Length; i++)
					buffer[i] = (Colors)i;

				guess = new ColorSequence(buffer);
			} else {
				GameState.FeedbackHistory.Add(fb);
				guess = getNextGuess(fb);
				GameState.updateTurn();
			}

			GameState.TurnHistory.Add(guess);

			return guess;
		} /*makeGuess*/

		public ColorSequence giveHint() {
			ColorSequence guess = GameState.FeedbackHistory.Count == 0
				? makeGuess()
				: getNextGuess(GameState.FeedbackHistory.Last());

			return guess;
		} /*giveHint*/
		#endregion Behavior
	} /*MastermindSolver*/
} /*Mastermind*/