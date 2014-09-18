using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mastermind {
	internal class ControlsController {
		#region AutoProperties
		private FrmMain Main { get; set; } /*Main*/
		public Label[,] LblArrayPlayer { get; private set; } /*LblArrayPlayer*/
		public byte NrOfPins { get; private set; } /*NrOfPins*/
		public byte NrOfTries { get; private set; } /*NrOfTries*/
		public byte NrOfAvailableColors { get; private set; } /*NrOfAvailableColors*/
		public Label[,] LblArrayFeedBackPins { get; private set; } /*LblArrayFeedBackPins*/
		public Label[] LblArraySecret { get; private set; } /*LblArraySecret*/
		public Label[] LblArrayAvailable { get; private set; } /*LblArrayAvailable*/
		public ToolStripMenuItem[] TsLoad { get; private set; } /*TsLoad*/
		public Button BtnGuess { get; private set; } /*BtnGuess*/
		public Button BtnGiveFeedBack { get; private set; } /*BtnGiveFeedBack*/
		public Button BtnHint { get; private set; } /*BtnHint*/
		public ToolTip Tt { get; private set; } /*Tt*/
		#endregion Autoproperties

		#region Constructor
		public ControlsController(FrmMain main) {
			Tt = new ToolTip();
			Main = main;
			LblArrayAvailable = new Label[Main.MaxNrAvailableColors];
			LblArrayFeedBackPins = new Label[Main.MaxNrOfTries, Main.MaxNrOfPins];
			LblArrayPlayer = new Label[Main.MaxNrOfTries, Main.MaxNrOfPins];
			LblArraySecret = new Label[Main.MaxNrOfPins];
		} /*ControlsController*/
		#endregion Constructor

		#region Behavior
		public void giveControlspProperties() {
			createLabelPlayerProperties();
			createLabelFbProperties();
			createBtnGuessProperties();
			createBtnGiveFeedBackProperties();
			createBtnHintProperties();
			createLabelSecretProperties();
			createLabelAvailableProperties();
			filltsLoad();
		} /*giveControlsproperties*/

		public void drawFrm() {
			Main.toolStripSave.Enabled = true;

			NrOfPins = Main.Mastermind.GameState.NrOfPins;
			NrOfTries = Main.Mastermind.GameState.NrOfTries;
			NrOfAvailableColors = Main.Mastermind.GameState.NrOfAvailableColors;

			showPlayerLabels();
			showFbLabels();
			showSecretLabels();
			showAvailableLabels();

			resizeFrmMain();
			Main.CenterThisScreen();

			highlightAccesiblePlayerLabels();

			if (Main.Mastermind.GameState.ComputerIsPlaying && Main.Mastermind.GameState.TurnHistory.Count == 0) {
				ColorSequence firstGuess = Main.Mastermind.MSolver.makeGuess();
				for (byte i = 0; i < NrOfPins; i++)
					LblArrayPlayer[0, i].BackColor = Color.FromName(firstGuess.getColorOnPlace(i).ToString());
			}

			btnShow();
		} /*drawFrm*/

		public void removeAllControls() {
			Main.lblStartNewGame.Hide();

			if (Main.Mastermind != null) {
				for (int i = 0; i < NrOfTries; i++)
					for (int j = 0; j < NrOfPins; j++) {
						LblArrayPlayer[i, j].BackColor = Color.DarkGray;
						LblArrayPlayer[i, j].Hide();
						LblArrayFeedBackPins[i, j].BackColor = Color.Gainsboro;
						LblArrayFeedBackPins[i, j].Hide();
						LblArraySecret[j].BackColor = Color.Gray;
						LblArraySecret[j].Hide();
					}

				for (int i = 0; i < NrOfAvailableColors; i++)
					LblArrayAvailable[i].Hide();
				BtnGuess.Top = 10;
				BtnGuess.Hide();
				BtnGiveFeedBack.Top = 10;
				BtnGiveFeedBack.Hide();
				BtnHint.Hide();
			}
		} /*removeAllControls*/

		private void createLabelPlayerProperties() {
			int ypos = 10;

			for (byte i = 0; i < LblArrayPlayer.GetLength(0); i++) {
				int xpos = 10;

				for (byte j = 0; j < LblArrayPlayer.GetLength(1); j++) {
					LblArrayPlayer[i, j] = new Label {
						Left = xpos,
						Top = ypos,
						Height = 35,
						Width = 35,
						Name = string.Format("Pl{0}{1}", i, j),
						Tag = string.Format("{0}", i),
						BackColor = Color.DarkGray,
						Visible = false,
						AllowDrop = true
					};
					LblArrayPlayer[i, j].MouseHover += Main.lbl_MouseHover;
					Main.pnlLabelPlayer.Controls.Add(LblArrayPlayer[i, j]);
					xpos += 50;
				}

				ypos += 50;
			}
		} /*createLabelPlayerProperties*/

		private void createLabelFbProperties() {
			int ypos = 10;

			for (int i = 0; i < LblArrayFeedBackPins.GetLength(0); i++) {
				int xpos = 0;

				for (int j = 0; j < LblArrayFeedBackPins.GetLength(1); j++) {
					LblArrayFeedBackPins[i, j] = new Label {
						Left = xpos,
						Top = ypos + (j % 2) * 20,
						Height = 15,
						Width = 15,
						Name = string.Format("Fb{0}{1}", i, j),
						Tag = string.Format("{0}", i),
						BackColor = Color.Gainsboro,
						Visible = false,
						BorderStyle = BorderStyle.Fixed3D
					};
					xpos += (j % 2) * 20;
					LblArrayFeedBackPins[i, j].MouseHover += Main.lbl_MouseHover;
					Main.pnlLabelFB.Controls.Add(LblArrayFeedBackPins[i, j]);
				}

				ypos += 50;
			}
		} /*createLabelFbProperties*/

		private void createLabelSecretProperties() {
			int xpos = 10;

			for (byte i = 0; i < LblArraySecret.Length; i++) {
				LblArraySecret[i] = new Label {
					Left = xpos,
					Top = 10,
					Height = 35,
					Width = 35,
					Name = string.Format("Secret{0}", i),
					BackColor = Color.Gray,
					Visible = false
				};

				LblArraySecret[i].MouseHover += Main.lbl_MouseHover;
				Main.pnlLabelSecret.Controls.Add(LblArraySecret[i]);
				xpos += 50;
			}
		} /*createLabelSecretProperties*/

		private void createBtnGuessProperties() {
			BtnGuess = new Button {
				Top = 10,
				Left = 0,
				Tag = "Guess",
				Text = string.Format("Guess"),
				Visible = false
			};

			BtnGuess.Click += Main.btnGuess_Click;
			Main.pnlButton.Controls.Add(BtnGuess);
		} /*createBtnGuessProperties*/

		private void createBtnGiveFeedBackProperties() {
			BtnGiveFeedBack = new Button {
				Top = 10,
				Left = 0,
				Tag = "GiveFeedback",
				Text = string.Format("Give"),
				Visible = false
			};

			BtnGiveFeedBack.Click += Main.btnGiveFeedBack_Click;
			Main.pnlButton.Controls.Add(BtnGiveFeedBack);
		}

		private void createBtnHintProperties() {
			BtnHint = new Button {
				Tag = "Hint",
				Text = string.Format("Hint"),
				Visible = false
			};

			BtnHint.Click += Main.btnHint_Click;
			Main.gbSecretCode.Controls.Add(BtnHint);
		}

		private void createLabelAvailableProperties() {
			int xpos = 10;

			for (byte i = 0; i < LblArrayAvailable.GetLength(0); i++) {
				LblArrayAvailable[i] = new Label {
					Left = xpos,
					Top = 10,
					Height = 35,
					Width = 35,
					Name = string.Format("Available{0}", i),
					BackColor = Color.FromName(((Colors)i).ToString()),
					Visible = false
				};

				Main.pnlLabelAvailable.Controls.Add(LblArrayAvailable[i]);
				LblArrayAvailable[i].MouseHover += Main.lbl_MouseHover;
				xpos += 50;
			}
		} /*createLabelAvailableProperties*/

		private void showPlayerLabels() {
			for (byte i = 0; i < NrOfTries; i++)
				for (byte j = 0; j < NrOfPins; j++) {
					if (i < Main.Mastermind.GameState.TurnNumber - 1)
						LblArrayPlayer[i, j].BackColor =
							Color.FromName(Main.Mastermind.GameState.TurnHistory[i].getColorOnPlace(j).ToString());

					LblArrayPlayer[i, j].Show();
					LblArrayPlayer[i, j].MouseClick -= Main.lblArrayPlayer_MouseClick;
					LblArrayPlayer[i, j].MouseDoubleClick -= Main.lblArrayPlayer_MouseClick;
					LblArrayPlayer[i, j].DragEnter -= Main.lblArrayPlayer_DragEnter;
					LblArrayPlayer[i, j].DragDrop -= Main.lblArrayPlayer_DragDrop;

					if (!Main.Mastermind.GameState.ComputerIsPlaying) {
						LblArrayPlayer[i, j].MouseClick += Main.lblArrayPlayer_MouseClick;
						LblArrayPlayer[i, j].MouseDoubleClick += Main.lblArrayPlayer_MouseClick;
						LblArrayPlayer[i, j].DragEnter += Main.lblArrayPlayer_DragEnter;
						LblArrayPlayer[i, j].DragDrop += Main.lblArrayPlayer_DragDrop;
					}
				}
		} /*showPlayerLabels*/

		private void btnShow() {
			BtnGuess.Top += 50 * (Main.Mastermind.GameState.TurnNumber - 1);
			BtnGiveFeedBack.Top += 50 * (Main.Mastermind.GameState.TurnNumber - 1);

			if (Main.Mastermind.GameState.ComputerIsPlaying)
				BtnGiveFeedBack.Show();

			else {
				BtnGuess.Show();

				if (Main.Mastermind.GameState.NrOfPins <= 8 && Main.Mastermind.GameState.NrOfAvailableColors <= 8)
					BtnHint.Show();
			}
		} /*btnShow*/

		private void showFbLabels() {
			byte nrOfWhitePins = 0;
			byte nrOfBlackPins = 0;

			for (byte i = 0; i < NrOfTries; i++) {
				if (Main.Mastermind.GameState.FeedbackHistory != null) {
					try {
						nrOfWhitePins = Main.Mastermind.GameState.FeedbackHistory[i].CorrectColor;
						nrOfBlackPins = Main.Mastermind.GameState.FeedbackHistory[i].CorrectPositionAndColor;
					} catch (System.ArgumentOutOfRangeException) {
						//Nodig omdat het starten van een game anders problemen geeft
					}

					for (byte j = 0; j < NrOfPins; j++) {
						if (nrOfBlackPins > 0) {
							LblArrayFeedBackPins[i, j].BackColor = Color.Black;
							nrOfBlackPins--;
						} else if (nrOfWhitePins > 0) {
							LblArrayFeedBackPins[i, j].BackColor = Color.White;
							nrOfWhitePins--;
						}

						LblArrayFeedBackPins[i, j].Show();
						LblArrayFeedBackPins[i, j].MouseClick -= Main.lblArrayFeedBackPins_MouseClick;
						LblArrayFeedBackPins[i, j].MouseDoubleClick -= Main.lblArrayFeedBackPins_MouseClick;

						if (Main.Mastermind.GameState.ComputerIsPlaying) {
							LblArrayFeedBackPins[i, j].MouseClick += Main.lblArrayFeedBackPins_MouseClick;
							LblArrayFeedBackPins[i, j].MouseDoubleClick += Main.lblArrayFeedBackPins_MouseClick;
						}
					}
				}
			}
		} /*showFbLabels*/

		private void showSecretLabels() {
			for (byte j = 0; j < NrOfPins; j++) {
				LblArraySecret[j].Show();

				if (Main.Mastermind.GameState.ComputerIsPlaying) {
					unvealSecret();
				}
			}
		} /*showSecretLabels*/

		private void showAvailableLabels() {
			for (byte j = 0; j < NrOfAvailableColors; j++) {
				LblArrayAvailable[j].Show();
				LblArrayAvailable[j].MouseDown -= Main.lblArrayAvailable_MouseDown;

				if (!Main.Mastermind.GameState.ComputerIsPlaying) {
					LblArrayAvailable[j].MouseDown += Main.lblArrayAvailable_MouseDown;
				}
			}
		} /*showAvailableLabels*/

		public void filltsLoad() {
			if (TsLoad != null)
				foreach (ToolStripMenuItem ts in TsLoad.Where(ts => ts != null))
					Main.toolStripLoad.DropDownItems.Remove(ts);

			TsLoad = new ToolStripMenuItem[Main.SgList.getAllSavedGamesNames().Length];

			for (int i = Main.SgList.getAllSavedGamesNames().Length - 1; i >= 0; i--) {
				TsLoad[i] = new ToolStripMenuItem {
					Text = Main.SgList.getAllSavedGamesNames()[i],
					Tag = i
				};
				Main.toolStripLoad.DropDownItems.Add(TsLoad[i]);
				TsLoad[i].MouseDown += Main.tsLoad_Mousedown;
			}
		} /*filltsLoad*/

		public void unvealSecret() {
			for (byte i = 0; i < NrOfPins; i++)
				LblArraySecret[i].BackColor = Color.FromName(Main.Mastermind.getSecretCombo().getColorOnPlace(i).ToString());
		} /*unvealSecret*/

		public void highlightAccesiblePlayerLabels() {
			byte turn = Main.Mastermind.GameState.TurnNumber;
			for (byte i = 0; i < NrOfPins; i++) {
				LblArrayPlayer[turn - 1, i].BackColor = Color.Silver;
			}
		} /*highlightAccesiblePlayerLabels*/

		private void resizeFrmMain() {
			Main.pnlLabelPlayer.Width = 50 * NrOfPins + 5;
			Main.pnlLabelPlayer.Height = 50 * NrOfTries + 10;
			Main.pnlLabelFB.Left = Main.pnlLabelPlayer.Width + Main.pnlLabelPlayer.Left;
			Main.pnlLabelFB.Width = 20 * (NrOfPins - NrOfPins / 2);
			Main.pnlLabelFB.Height = Main.pnlLabelPlayer.Height;
			Main.pnlButton.Left = Main.pnlLabelFB.Left + Main.pnlLabelFB.Width;
			Main.pnlButton.Height = Main.pnlLabelPlayer.Height;
			Main.pnlButton.Width = BtnGuess.Width;
			Main.pnlPlace.Width = Main.pnlButton.Left + Main.pnlButton.Width + 40;
			Main.pnlPlace.Height = Main.pnlLabelPlayer.Height + 10;
			Main.gbGuess.Height = Main.pnlLabelPlayer.Height;
			Main.gbGuess.Width = Main.pnlPlace.Width + 20;
			Main.pnlLabelSecret.Width = Main.pnlLabelPlayer.Width;
			Main.gbSecretCode.Top = Main.gbGuess.Top + Main.gbGuess.Height + 20;
			Main.pnlLabelAvailable.Width = NrOfAvailableColors * 50;
			Main.gbAvailable.Width = Main.pnlLabelAvailable.Width + 40;
			if (Main.gbAvailable.Width < Main.gbGuess.Width)
				Main.gbAvailable.Width = Main.gbGuess.Width;
			else
				Main.gbGuess.Width = Main.gbAvailable.Width;
			Main.gbSecretCode.Width = Main.gbGuess.Width;
			Main.Height = Main.gbSecretCode.Top + Main.gbSecretCode.Height + 60;
			Main.Width = Main.gbAvailable.Left + Main.gbAvailable.Width + 60;
			Main.CtrlController.BtnHint.Left = Main.pnlButton.Left + BtnGuess.Left;
			Main.CtrlController.BtnHint.Top = 20;
		} /*resizeFrmMain*/
		#endregion Behavior
	} /*GameBuilder*/
} /*Mastermind*/