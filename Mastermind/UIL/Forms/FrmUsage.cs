using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind {
	public partial class FrmUsage : Form {
		private readonly string[] text = {
			"What's Mastermind?\n\n",
			"Mastermind is a code-breaking game. " +
			"The objective of the game is to guess the " +
			"exact positions of the colors in the computer’s sequence " +
			"or in other words ‘to crack the code’.\n\n",
			"Rules\n\n",
			"The computer picks a sequence of colors, " +
			"(the Secret code). Each color can be " +
			"used only once in a code sequence. " +
			"Each turn the player needs to fill a " +
			"line with different colors and then " +
			"click on the try button to verify your " +
			"combination. For each color in your combination " +
			"that is the correct color and  position in the " +
			"code sequence, the computer will display a " +
			"small black pin on the right side of the current " +
			"color combo. For each color in your sequence that " +
			"is the correct color but NOT in the correct position " +
			"in the code sequence, the computer displays a small white pin.\n\n",
			"You win the game when you manage to crack the Secret code. " +
			"You lose when all the tries are wasted without guessing the correct sequence.\n\n",
			"Settings and controls\n\n",
			"Option menu (Ctrl + O)\n",
			"In the option menu you can choose between these settings:\n" +
			"Available colors: 3 - 10\n" +
			"Length of Secret code: 3 - 10\n" +
			"Nr of tries: 1 – 15\n" +
			"Don’t forget to press ok or hit enter!\n\n",
			"Save a game (Ctrl + S)\n",
			"During the game you can save your progress by " +
			"hitting save in the file menu or using the shortcut.\n" +
			"The game will be available later when you feel like playing again.\n\n",
			"Load a game\n",
			"In the file menu, there is the option to load the games you’ve saved before.\n" +
			"You can remove saved games by right clicking on the name of the game.\n"
		};

		public FrmUsage() {
			InitializeComponent();
			rtbUsage.SelectionFont = new Font(DefaultFont, FontStyle.Bold);
			rtbUsage.AppendText(text[0]);
			rtbUsage.SelectionIndent = 20;
			rtbUsage.AppendText(text[1]);
			rtbUsage.SelectionIndent = 0;
			rtbUsage.SelectionFont = new Font(DefaultFont, FontStyle.Bold);
			rtbUsage.AppendText(text[2]);
			rtbUsage.SelectionIndent = 20;
			rtbUsage.AppendText(text[3]);
			rtbUsage.AppendText(text[4]);
			rtbUsage.SelectionIndent = 0;
			rtbUsage.SelectionFont = new Font(DefaultFont, FontStyle.Bold);
			rtbUsage.AppendText(text[5]);
			rtbUsage.SelectionIndent = 20;
			rtbUsage.SelectionFont = new Font(DefaultFont, FontStyle.Bold);
			rtbUsage.AppendText(text[6]);
			rtbUsage.SelectionIndent = 40;
			rtbUsage.AppendText(text[7]);
			rtbUsage.SelectionIndent = 20;
			rtbUsage.SelectionFont = new Font(DefaultFont, FontStyle.Bold);
			rtbUsage.AppendText(text[8]);
			rtbUsage.SelectionIndent = 40;
			rtbUsage.AppendText(text[9]);
			rtbUsage.SelectionIndent = 20;
			rtbUsage.SelectionFont = new Font(DefaultFont, FontStyle.Bold);
			rtbUsage.AppendText(text[10]);
			rtbUsage.SelectionIndent = 40;
			rtbUsage.AppendText(text[11]);
			rtbUsage.GotFocus += rtbUsage_GotFocus;
		} /*FrmUsage*/

		private void rtbUsage_GotFocus(object sender, EventArgs e) {
			ActiveControl = button;
		} /*rtbUsage_GotFocus*/
	} /*FrmUsage*/
} /*Mastermind*/