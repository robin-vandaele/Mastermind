using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mastermind {
	internal class SerializeClass {
		#region State
		private readonly BinaryFormatter f = new BinaryFormatter();
		#endregion State

		#region Autoproperties
		private FileStream S { get; set; } /*S*/
		#endregion Autoproperties

		#region Properties
		private BinaryFormatter F {
			get { return f; }
		} /*F*/
		#endregion Properties

		#region Behavior
		public void serializeSavedGames(FrmMain main) {
			S = new FileStream("save.dat", FileMode.Create);
			F.Serialize(S, main.SgList);
			S.Close();
			main.CtrlController.filltsLoad();
		} /*serializeSavedGames*/

		public SavedGamesList deserializeSavedGames(FrmMain main) {
			try {
				S = new FileStream("save.dat", FileMode.Open);
				SavedGamesList SgList = (SavedGamesList)F.Deserialize(S);
				S.Close();
				return SgList;
			} catch (IOException) {
				return null;
			} catch (SerializationException) {
				S.Close();
				return null;
			} catch (ArgumentNullException) {
				S.Close();
				return null;
			}
		} /*deserializeSavedGames*/
		#endregion Behavior
	} /*SerializeClass*/
} /*Mastermind*/