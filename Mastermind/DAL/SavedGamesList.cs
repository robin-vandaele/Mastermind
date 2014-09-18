using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind {
	[Serializable]
	public class SavedGamesList {
		#region State
		private readonly List <SavedGame> savedGames = new List <SavedGame>();
		#endregion State;

		#region Properties
		internal List <SavedGame> SavedGames {
			get { return savedGames; }
		} /*SavedGames*/
		#endregion Properties

		#region Behavior
		public void add(FrmMain main) {
			try {
				SavedGames.Add(new SavedGame(main.Mastermind.GameState));
			} catch (NullReferenceException) {
			}
		} /*add*/

		public Mastermind load(int i, FrmMain main) {
			return new Mastermind(SavedGames.ElementAt(i).Game);
		} /*load*/

		public void remove(int i) {
			SavedGames.RemoveAt(i);
		} /*remove*/

		public string[] getAllSavedGamesNames() {
			string[] res = new string[SavedGames.Count];
			for (int i = SavedGames.Count - 1; i >= 0; i--)
				res[i] = SavedGames.ElementAt(i).ToString();
			return res;
		} /*getAllSavedGamesNames*/
		#endregion Behavior
	} /*SavedGamesList*/
} /*UnitTestProject*/