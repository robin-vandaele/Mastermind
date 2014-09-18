using System;
using System.Collections.Generic;

namespace Mastermind {
	[Serializable]
	public class ColorSequence {
		#region State
		private readonly List <Colors> colorCombo = new List <Colors>();
		#endregion State

		#region Constructors
		public ColorSequence() {
		} /*ColorSequence*/

		public ColorSequence(Colors[] colors) {
			for (int i = 0; i < colors.Length; i++)
				ColorCombo.Add(colors[i]);
		} /*ColorSequence*/

		public ColorSequence(List <Colors> colors) {
			colorCombo = colors;
		} /*ColorSequence*/
		#endregion Constructors

		#region Properties
		private List <Colors> ColorCombo {
			get { return colorCombo; }
		} /*ColorCombo*/

		public int Length {
			get { return ColorCombo.Count; }
		}
		#endregion Properties

		#region Behavior
		public void addLast(Colors clr) {
			ColorCombo.Add(clr);
		} /*addLast*/

		public Colors getColorOnPlace(byte i) {
			return ColorCombo[i];
		} /*getColorOnPlace*/

		public void setColorOnPlace(byte i, Colors clr) {
			try {
				ColorCombo[i] = clr;
			} catch (ArgumentOutOfRangeException) {
				ColorCombo.Add(clr);
			}
		} /*setColorOnPlace*/

		public Feedback compareToColorsequence(ColorSequence toCompare) {
			byte correctCol = 0;
			byte correctPosAndCol = 0;
			for (byte i = 0; i < toCompare.ColorCombo.Count; i++) {
				if (toCompare.ColorCombo[i] == ColorCombo[i])
					correctPosAndCol++;
				for (byte j = 0; j < ColorCombo.Count; j++)
					if (toCompare.ColorCombo[i] == ColorCombo[j])
						correctCol++;
			}

			correctCol -= correctPosAndCol;
			Feedback fb = new Feedback(correctPosAndCol, correctCol);
			return fb;
		} /*compareToColorsequence*/

		public override bool Equals(object obj) {
			bool res = true;
			for (int i = 0; i < ColorCombo.Count; i++) {
				if (String.CompareOrdinal(ColorCombo[i].ToString(), ((ColorSequence)obj).ColorCombo[i].ToString()) != 0) {
					res = false;
				}
			}
			return res;
		} /*Equals*/

		public override int GetHashCode() {
			return base.GetHashCode();
		} /*GetHashCode*/
		#endregion Behavior
	} /*Colorsequence*/
} /*Mastermind*/