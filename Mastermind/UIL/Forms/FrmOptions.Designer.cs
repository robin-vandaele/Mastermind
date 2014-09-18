namespace Mastermind {
	partial class FrmOptions {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblTurns = new System.Windows.Forms.Label();
			this.lblAvailableColors = new System.Windows.Forms.Label();
			this.lblColorsToGuess = new System.Windows.Forms.Label();
			this.gbWho = new System.Windows.Forms.GroupBox();
			this.rbtnComputer = new System.Windows.Forms.RadioButton();
			this.rbtnUser = new System.Windows.Forms.RadioButton();
			this.btnOk = new System.Windows.Forms.Button();
			this.nudNrOfTurns = new System.Windows.Forms.NumericUpDown();
			this.nudColorsToGuess = new System.Windows.Forms.NumericUpDown();
			this.nudAvailableColors = new System.Windows.Forms.NumericUpDown();
			this.gbWho.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNrOfTurns)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudColorsToGuess)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAvailableColors)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTurns
			// 
			this.lblTurns.AutoSize = true;
			this.lblTurns.Location = new System.Drawing.Point(61, 42);
			this.lblTurns.Name = "lblTurns";
			this.lblTurns.Size = new System.Drawing.Size(114, 17);
			this.lblTurns.TabIndex = 0;
			this.lblTurns.Text = "Number of turns:";
			// 
			// lblAvailableColors
			// 
			this.lblAvailableColors.AutoSize = true;
			this.lblAvailableColors.Location = new System.Drawing.Point(61, 103);
			this.lblAvailableColors.Name = "lblAvailableColors";
			this.lblAvailableColors.Size = new System.Drawing.Size(180, 17);
			this.lblAvailableColors.TabIndex = 1;
			this.lblAvailableColors.Text = "Number of available colors:";
			// 
			// lblColorsToGuess
			// 
			this.lblColorsToGuess.AutoSize = true;
			this.lblColorsToGuess.Location = new System.Drawing.Point(61, 169);
			this.lblColorsToGuess.Name = "lblColorsToGuess";
			this.lblColorsToGuess.Size = new System.Drawing.Size(178, 17);
			this.lblColorsToGuess.TabIndex = 2;
			this.lblColorsToGuess.Text = "Number of colors to guess:";
			// 
			// gbWho
			// 
			this.gbWho.Controls.Add(this.rbtnComputer);
			this.gbWho.Controls.Add(this.rbtnUser);
			this.gbWho.Location = new System.Drawing.Point(65, 249);
			this.gbWho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbWho.Name = "gbWho";
			this.gbWho.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbWho.Size = new System.Drawing.Size(152, 113);
			this.gbWho.TabIndex = 3;
			this.gbWho.TabStop = false;
			this.gbWho.Text = "Who Is guessing?";
			// 
			// rbtnComputer
			// 
			this.rbtnComputer.AutoSize = true;
			this.rbtnComputer.Location = new System.Drawing.Point(17, 69);
			this.rbtnComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtnComputer.Name = "rbtnComputer";
			this.rbtnComputer.Size = new System.Drawing.Size(90, 21);
			this.rbtnComputer.TabIndex = 5;
			this.rbtnComputer.Text = "Computer";
			this.rbtnComputer.UseVisualStyleBackColor = true;
			// 
			// rbtnUser
			// 
			this.rbtnUser.AutoSize = true;
			this.rbtnUser.Checked = true;
			this.rbtnUser.Location = new System.Drawing.Point(17, 30);
			this.rbtnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtnUser.Name = "rbtnUser";
			this.rbtnUser.Size = new System.Drawing.Size(59, 21);
			this.rbtnUser.TabIndex = 4;
			this.rbtnUser.TabStop = true;
			this.rbtnUser.Text = "User";
			this.rbtnUser.UseVisualStyleBackColor = true;
			this.rbtnUser.CheckedChanged += new System.EventHandler(this.rbtnUser_CheckedChanged);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(279, 318);
			this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(97, 32);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// nudNrOfTurns
			// 
			this.nudNrOfTurns.Location = new System.Drawing.Point(279, 37);
			this.nudNrOfTurns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudNrOfTurns.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.nudNrOfTurns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudNrOfTurns.Name = "nudNrOfTurns";
			this.nudNrOfTurns.ReadOnly = true;
			this.nudNrOfTurns.Size = new System.Drawing.Size(68, 22);
			this.nudNrOfTurns.TabIndex = 1;
			this.nudNrOfTurns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudNrOfTurns.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// nudColorsToGuess
			// 
			this.nudColorsToGuess.Location = new System.Drawing.Point(279, 164);
			this.nudColorsToGuess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudColorsToGuess.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudColorsToGuess.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudColorsToGuess.Name = "nudColorsToGuess";
			this.nudColorsToGuess.ReadOnly = true;
			this.nudColorsToGuess.Size = new System.Drawing.Size(64, 22);
			this.nudColorsToGuess.TabIndex = 3;
			this.nudColorsToGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudColorsToGuess.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.nudColorsToGuess.ValueChanged += new System.EventHandler(this.nudColorsToGuess_ValueChanged);
			// 
			// nudAvailableColors
			// 
			this.nudAvailableColors.Location = new System.Drawing.Point(279, 98);
			this.nudAvailableColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.nudAvailableColors.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudAvailableColors.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudAvailableColors.Name = "nudAvailableColors";
			this.nudAvailableColors.ReadOnly = true;
			this.nudAvailableColors.Size = new System.Drawing.Size(64, 22);
			this.nudAvailableColors.TabIndex = 2;
			this.nudAvailableColors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudAvailableColors.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.nudAvailableColors.ValueChanged += new System.EventHandler(this.nudAvailableColors_ValueChanged);
			// 
			// FrmOptions
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 412);
			this.Controls.Add(this.nudAvailableColors);
			this.Controls.Add(this.nudColorsToGuess);
			this.Controls.Add(this.nudNrOfTurns);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.gbWho);
			this.Controls.Add(this.lblColorsToGuess);
			this.Controls.Add(this.lblAvailableColors);
			this.Controls.Add(this.lblTurns);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmOptions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Options";
			this.gbWho.ResumeLayout(false);
			this.gbWho.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNrOfTurns)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudColorsToGuess)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAvailableColors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTurns;
		private System.Windows.Forms.Label lblAvailableColors;
		private System.Windows.Forms.Label lblColorsToGuess;
		private System.Windows.Forms.GroupBox gbWho;
		private System.Windows.Forms.RadioButton rbtnComputer;
		private System.Windows.Forms.RadioButton rbtnUser;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.NumericUpDown nudNrOfTurns;
		private System.Windows.Forms.NumericUpDown nudColorsToGuess;
		private System.Windows.Forms.NumericUpDown nudAvailableColors;
	}
}