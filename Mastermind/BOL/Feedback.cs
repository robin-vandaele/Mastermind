using System;

namespace Mastermind {
	[Serializable]
	public class Feedback {
		#region State
		private readonly byte correctPositionAndColor;
		private readonly byte correctColor;
		#endregion State

		#region Constructor
		public Feedback(byte correctColAndPos, byte correctCol) {
			correctPositionAndColor = correctColAndPos;
			correctColor = correctCol;
		} /*Feedback*/
		#endregion Constructor

		#region Properties
		public byte CorrectPositionAndColor {
			get { return correctPositionAndColor; }
		} /*CorrectPositionAndColor*/

		public byte CorrectColor {
			get { return correctColor; }
		} /*CorrectColor*/
		#endregion

		#region Behavior
		public override bool Equals(object obj) {
			return CorrectPositionAndColor == ((Feedback)obj).CorrectPositionAndColor &&
					CorrectColor == ((Feedback)obj).CorrectColor;
		} /*Equals*/

		public override int GetHashCode() {
			return base.GetHashCode();
		} /*GetHashCode*/
		#endregion Behavior
	} /*Feedback*/
} /*Mastermind*/