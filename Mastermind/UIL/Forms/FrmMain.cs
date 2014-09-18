using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind {
	public partial class FrmMain : Form {
		#region State
		private readonly ColorPicker clrPicker;
		private readonly ControlsController ctrlController;
		private const byte maxNrAvailableColors = 10;
		private const byte maxNrOfPins = 10;
		private const byte maxNrOfTries = 15;
		#endregion State

		#region Autoproperties
		internal Mastermind Mastermind { get; private set; } /*Game*/
		internal SavedGamesList SgList { get; private set; } /*SGList*/
		internal SerializeClass SClass { get; private set; } /*SClass*/
		#endregion AutoProperties

		#region Properties
		public byte MaxNrOfTries {
			get { return maxNrOfTries; }
		} /*MaxNrOfTries*/

		public byte MaxNrOfPins {
			get { return maxNrOfPins; }
		} /*MaxNrOfPins*/

		public byte MaxNrAvailableColors {
			get { return maxNrAvailableColors; }
		} /*MaxNrAvailableColors*/

		private ColorPicker ClrPicker {
			get { return clrPicker; }
		} /*ClrPicker*/

		internal ControlsController CtrlController {
			get { return ctrlController; }
		} /*CtrlController*/
		#endregion Properties

		#region Constructor
		public FrmMain() {
			InitializeComponent();
			SgList = new SavedGamesList();
			SClass = new SerializeClass();
			ctrlController = new ControlsController(this);
			clrPicker = new ColorPicker();
			SavedGamesList sg = SClass.deserializeSavedGames(this);
			if (sg != null) SgList = sg;
			CtrlController.giveControlspProperties();
			showOptions();
		} /*FrmMain*/
		#endregion Constructor

		#region Behavior
		public void lbl_MouseHover(object sender, EventArgs e) {
			Label lbl = sender as Label;
			if (lbl != null) CtrlController.Tt.SetToolTip(lbl, lbl.BackColor.ToKnownColor().ToString());
		} /*lbl_MouseHover*/

		public void lblArrayPlayer_MouseClick(object sender, MouseEventArgs e) {
			Label lbl = sender as Label;
			if (lbl != null && int.Parse(lbl.Tag.ToString()) == Mastermind.GameState.TurnNumber - 1 && !Mastermind.gameIsOver()) {
				string backColor = lbl.BackColor.ToKnownColor().ToString();
				lbl.BackColor = ClrPicker.nextOrPreviousAvailableColor(Mastermind.GameState.NrOfAvailableColors,
					e.Button == MouseButtons.Right,
					backColor);
			}
		} /*lblArrayPlayer_MouseClick*/

		public void lblArrayPlayer_DragDrop(object sender, DragEventArgs e) {
			Label lbl = sender as Label;
			if (lbl != null) {
				try {
					lbl.BackColor = (Color)e.Data.GetData(typeof (Color));
				} catch (NullReferenceException) {
				}
			}
		} /*lblArrayPlayer_DragDrop*/

		public void lblArrayPlayer_DragEnter(object sender, DragEventArgs e) {
			Label lbl = sender as Label;
			if (lbl != null && int.Parse(lbl.Tag.ToString()) == Mastermind.GameState.TurnNumber - 1 && !Mastermind.gameIsOver()) {
				e.Effect = DragDropEffects.Copy;
			}
		} /*lblArrayPlayer_DragEnter*/

		public void lblArrayAvailable_MouseDown(object sender, MouseEventArgs e) {
			Label lbl = sender as Label;
			if (lbl != null) lbl.DoDragDrop(lbl.BackColor, DragDropEffects.Copy);
		} /*lblArrayAvailable_MouseDown*/

		public void lblArrayFeedBackPins_MouseClick(object sender, MouseEventArgs e) {
			Label lbl = sender as Label;
			if (lbl != null && int.Parse(lbl.Tag.ToString()) == Mastermind.GameState.TurnNumber - 1 && !Mastermind.gameIsOver())
				lbl.BackColor = ClrPicker.nextFeedBackColor(lbl.BackColor.ToKnownColor().ToString());
		}

		public void btnGuess_Click(object sender, EventArgs e) {
			if (!Mastermind.gameIsOver()) {
				try {
					ColorSequence guess = new ColorSequence();
					for (int i = 0; i < Mastermind.GameState.NrOfPins; i++)
						guess.addLast(
							ClrPicker.parseEnum <Colors>(
								CtrlController.LblArrayPlayer[Mastermind.GameState.TurnNumber - 1, i].BackColor.ToKnownColor().ToString()));
					passGuessAndGetFeedback(guess);
				} catch (ArgumentException) {
					MessageBox.Show(
						string.Format("Every pin must have a color and a color can't be used twice..."), string.Format("Error"));
				}
			}
		} /*btnGuess_Click*/

		public void btnHint_Click(object sender, EventArgs e) {
			if (!Mastermind.gameIsOver()) {
				try {
					ColorSequence guess = Mastermind.MSolver.giveHint();
					for (byte i = 0; i < guess.Length; i++) {
						CtrlController.LblArrayPlayer[Mastermind.GameState.TurnNumber - 1, i].BackColor =
							Color.FromName(guess.getColorOnPlace(i).ToString());
					}
					passGuessAndGetFeedback(guess);
				} catch (IndexOutOfRangeException) {
					MessageBox.Show(
						string.Format("I can't seem to resolve the puzzel"), string.Format("Error"));
				}
			}
		} /*btnHint_Click*/

		public void btnGiveFeedBack_Click(object sender, EventArgs e) {
			if (!Mastermind.gameIsOver()) {
				try {
					Button btn = sender as Button;
					byte correcPlaceAndCol = 0;
					byte correctCol = 0;
					for (int i = 0; i < Mastermind.GameState.NrOfPins; i++) {
						if (CtrlController.LblArrayFeedBackPins[Mastermind.GameState.TurnNumber - 1, i].BackColor == Color.Black) {
							correcPlaceAndCol++;
						}
						if (CtrlController.LblArrayFeedBackPins[Mastermind.GameState.TurnNumber - 1, i].BackColor == Color.White) {
							correctCol++;
						}
					}
					Feedback fb = new Feedback(correcPlaceAndCol, correctCol);
					ColorSequence newGuess = Mastermind.MSolver.makeGuess(fb);
					if (Mastermind.gameIsOver()) {
						MessageBox.Show(Mastermind.GameState.Won ? "Won" : "Lost");
					} else {
						for (byte i = 0; i < newGuess.Length; i++) {
							CtrlController.LblArrayPlayer[Mastermind.GameState.TurnNumber - 1, i].BackColor =
								Color.FromName(newGuess.getColorOnPlace(i).ToString());
						}
						if (btn != null) btn.Top += 50;
						pnlPlace.ScrollControlIntoView(CtrlController.LblArrayPlayer[Mastermind.GameState.TurnNumber - 1, 0]);
					}
				} catch (ArgumentOutOfRangeException) {
					MessageBox.Show(Mastermind.GameState.Won ? "Won" : "You must have made a mistake, I can't do anything anymore");
				}
			}
		} /*btnGiveFeedBack_Click*/

		public void tsLoad_Mousedown(object sender, MouseEventArgs e) {
			ToolStripItem ts = sender as ToolStripMenuItem;
			if (e.Button == MouseButtons.Right) {
				if (ts != null) SgList.remove((int)ts.Tag);
				SClass.serializeSavedGames(this);
			} else {
				if (ts != null) Mastermind = SgList.load((int)ts.Tag, this);
				CtrlController.removeAllControls();
				CtrlController.drawFrm();
			}
		} /*tsLoad_Mousedown*/

		private void toolStripExit_Click(object sender, EventArgs e) {
			Close();
		} /*toolStripexit_Click*/

		private void toolStripAbout_Click(object sender, EventArgs e) {
			FrmAbout about = new FrmAbout();
			about.ShowDialog();
		} /*toolStripAbout_Click*/

		private void toolStripOptions_Click(object sender, EventArgs e) {
			showOptions();
		} /*toolStripOptions_Click*/

		private void toolStripUsage_Click(object sender, EventArgs e) {
			FrmUsage usage = new FrmUsage();
			usage.ShowDialog();
		} /*toolStripUsage_Click*/

		private void toolStripNew_Click(object sender, EventArgs e) {
			CtrlController.removeAllControls();
			try {
				byte nrOfTries = Mastermind.GameState.NrOfTries;
				byte nrOfPins = Mastermind.GameState.NrOfPins;
				byte nrOfAvailableColors = Mastermind.GameState.NrOfAvailableColors;
				bool computerisPlaying = Mastermind.GameState.ComputerIsPlaying;
				Mastermind = new Mastermind(nrOfTries, nrOfPins, nrOfAvailableColors, computerisPlaying);
			} catch (Exception) {
				Mastermind = new Mastermind();
			}
			CtrlController.drawFrm();
		} /*toolStripNew_Click*/

		private void toolStripSave_Click(object sender, EventArgs e) {
			SgList.add(this);
			SClass.serializeSavedGames(this);
		} /*toolStripSave_Click*/

		internal void CenterThisScreen() {
			CenterToScreen();
		} /*CenterThisScreen*/

		private void showOptions() {
			FrmOptions options = new FrmOptions();
			if (Mastermind != null)
				options = new FrmOptions(Mastermind.GameState.NrOfTries, Mastermind.GameState.NrOfPins,
					Mastermind.GameState.NrOfAvailableColors,
					Mastermind.GameState.ComputerIsPlaying);
			options.ShowDialog();
			if (options.ClickedOk) {
				CtrlController.removeAllControls();
				Mastermind = new Mastermind(options.getOptions());
				CtrlController.drawFrm();
				if (!Mastermind.GameState.ComputerIsPlaying) {
					CtrlController.highlightAccesiblePlayerLabels();
				}
			}
		} /*showOptions*/

		private void passGuessAndGetFeedback(ColorSequence guess) {
			Feedback feedback = Mastermind.checkAnswerAndGiveFeedbackFor(guess);
			int tmp = 0;
			for (byte j = 0; j < feedback.CorrectPositionAndColor; j++) {
				CtrlController.LblArrayFeedBackPins[Mastermind.GameState.TurnNumber - 2, tmp].BackColor = Color.Black;
				tmp++;
			}
			for (byte j = 0; j < feedback.CorrectColor; j++) {
				CtrlController.LblArrayFeedBackPins[Mastermind.GameState.TurnNumber - 2, tmp].BackColor = Color.White;
				tmp++;
			}
			if (Mastermind.gameIsOver()) {
				MessageBox.Show(Mastermind.GameState.Won ? "Won" : "Lost");
				CtrlController.unvealSecret();
			} else {
				if (CtrlController.BtnGuess != null) CtrlController.BtnGuess.Top += 50;
				pnlPlace.ScrollControlIntoView(CtrlController.LblArrayPlayer[Mastermind.GameState.TurnNumber - 1, 0]);
				CtrlController.highlightAccesiblePlayerLabels();
			}
		} /*passGuessAndGetFeedback*/
		#endregion Behavior
	} /*FrmMain*/
} /*Mastermind*/