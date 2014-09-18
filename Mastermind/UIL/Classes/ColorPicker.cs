using System;
using System.Drawing;

namespace Mastermind {
	public class ColorPicker {
		#region Autoproperties
		private Colors ThisAvailableColor { get; set; } /*ThisAvailableColor*/
		private FeedBackColors ThisFeedBackColor { get; set; } /*ThisFeedBackColor*/
		#endregion Autoproperties

		#region Behavior
		internal T parseEnum <T>(string value) {
			//http://stackoverflow.com/questions/16100/how-do-i-convert-a-string-to-an-enum-in-c

			if (typeof (T).IsEnum) // van Keith op StackOverflow
				return (T)Enum.Parse(typeof (T), value, true);

			throw new ArgumentException("I must be an enum type");
		} /*parseEnum*/

		public Color nextOrPreviousAvailableColor(byte nrOfAvailableColors, bool right, string backColor) {
			int i = !right ? 1 : -1;
			if (String.Compare("Silver", backColor, StringComparison.Ordinal) == 0)
				ThisAvailableColor = 0;
			else
				ThisAvailableColor = (Colors)((int)(parseEnum <Colors>(backColor) + i) % nrOfAvailableColors);
			return
				Color.FromName((int)ThisAvailableColor < 0
					? ((Colors)(nrOfAvailableColors - 1)).ToString()
					: ThisAvailableColor.ToString());
		} /*nextOrPreviousAvailableColor*/

		public Color nextFeedBackColor(string backColor) {
			ThisFeedBackColor = (FeedBackColors)((int)(parseEnum <FeedBackColors>(backColor) + 1) % 3);
			return
				Color.FromName((int)ThisFeedBackColor < 0
					? ((FeedBackColors)(2 - 1)).ToString()
					: ThisFeedBackColor.ToString());
		} /*nextFeedBackColor*/
		#endregion Behavior
	} /*ColorPicker*/
} /*Mastermind*/