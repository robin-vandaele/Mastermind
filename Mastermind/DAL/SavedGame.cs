using System;

namespace Mastermind {
	[Serializable]
	internal class SavedGame {
		#region State
		private readonly GameState game;
		private readonly DateTime gameDateTime;
		#endregion State

		#region Properties
		public GameState Game {
			get { return game; }
		} /*Game*/

		private DateTime GameDateTime {
			get { return gameDateTime; }
		} /*GameDateTime*/
		#endregion Properties

		#region Constructor
		public SavedGame(GameState game) {
			this.game = game;
			gameDateTime = DateTime.Now;
		} /*SavedGame*/
		#endregion Constructor

		#region Behavior
		public override string ToString() {
			return string.Format("Game {0} {1}", GameDateTime.ToShortDateString(),
				GameDateTime.ToShortTimeString());
		} /*ToString*/
		#endregion Behavior
	} /*SavedGame*/
} /*UnitTestProject.DAL*/