using System;
using System.Windows.Forms;

namespace Mastermind {
	public partial class FrmOptions : Form {
		#region Properties
		private byte NrfOTries { get; set; } /*NrfOTries*/
		private byte NrOfColors { get; set; } /*NrOfColors*/
		private byte NrOfPins { get; set; } /*NrOfPins*/
		public bool ClickedOk { get; private set; } /*ClickedOk*/
		public bool ComputerPlayer { get; private set; } /* ComputerPlayer*/
		#endregion Properties

		#region Constructor
		public FrmOptions() {
			InitializeComponent();
		} /*FrmOptions*/

		public FrmOptions(byte nrOfTries, byte nrOfPins, byte nrOfAvailableColors, bool computerIsPlaying) {
			InitializeComponent();
			nudNrOfTurns.Value = nrOfTries;
			nudColorsToGuess.Value = nrOfPins;
			nudAvailableColors.Value = nrOfAvailableColors;
			rbtnUser.Checked = !computerIsPlaying;
			rbtnComputer.Checked = computerIsPlaying;
		}
		#endregion Constructor

		#region Behavior
		internal GameState getOptions() {
			return new GameState(NrfOTries, NrOfPins, NrOfColors, ComputerPlayer);
		} /*getOptions*/

		private void btnOk_Click(object sender, EventArgs e) {
			NrfOTries = (byte)nudNrOfTurns.Value;
			NrOfColors = (byte)nudAvailableColors.Value;
			NrOfPins = (byte)nudColorsToGuess.Value;
			ComputerPlayer = rbtnComputer.Checked;
			ClickedOk = true;
			Close();
		} /*btnOk_Click*/

		private void nudAvailableColors_ValueChanged(object sender, EventArgs e) {
			if (!isAvailableBiggerThanToGuess(nudAvailableColors.Value, nudColorsToGuess.Value))
				nudColorsToGuess.Value = nudAvailableColors.Value;
		} /*nudAvailableColors_ValueChanged*/

		private void nudColorsToGuess_ValueChanged(object sender, EventArgs e) {
			if (!isAvailableBiggerThanToGuess(nudAvailableColors.Value, nudColorsToGuess.Value))
				nudAvailableColors.Value = nudColorsToGuess.Value;
		} /*nudColorsToGuess_ValueChanged*/

		private bool isAvailableBiggerThanToGuess(decimal available, decimal toGuess) {
			return available > toGuess;
		} /*isAvailableBiggerThanToGuess*/

		private void rbtnUser_CheckedChanged(object sender, EventArgs e) {
			RadioButton rbtn = sender as RadioButton;
			if (rbtn != null) {
				if (!rbtn.Checked) {
					ComputerPlayer = true;
					nudAvailableColors.Maximum = 8;
					nudColorsToGuess.Maximum = 8;
				} else {
					nudAvailableColors.Maximum = 10;
					nudColorsToGuess.Maximum = 10;
				}
			}
		} /*rbtnUser_CheckedChanged*/
		#endregion Behavior
	} /*FrmOptions*/
} /*Mastermind*/