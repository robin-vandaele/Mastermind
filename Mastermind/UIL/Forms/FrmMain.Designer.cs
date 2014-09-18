using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Mastermind {
	partial class FrmMain {
		#region Windows Form Designer generated code
		/// <summary>
		/// Required designer variable.
		/// </summary>
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripNew = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripUsage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.pnlLabelPlayer = new System.Windows.Forms.Panel();
			this.pnlLabelAvailable = new System.Windows.Forms.Panel();
			this.pnlLabelSecret = new System.Windows.Forms.Panel();
			this.gbGuess = new System.Windows.Forms.GroupBox();
			this.pnlPlace = new System.Windows.Forms.Panel();
			this.pnlButton = new System.Windows.Forms.Panel();
			this.pnlLabelFB = new System.Windows.Forms.Panel();
			this.lblStartNewGame = new System.Windows.Forms.Label();
			this.gbSecretCode = new System.Windows.Forms.GroupBox();
			this.gbAvailable = new System.Windows.Forms.GroupBox();
			this.menuStrip1.SuspendLayout();
			this.gbGuess.SuspendLayout();
			this.pnlPlace.SuspendLayout();
			this.gbSecretCode.SuspendLayout();
			this.gbAvailable.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripFile
			// 
			this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOptions,
            this.toolStripSeparator2,
            this.toolStripLoad,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripExit});
			this.toolStripFile.Name = "toolStripFile";
			this.toolStripFile.Size = new System.Drawing.Size(44, 24);
			this.toolStripFile.Text = "File";
			// 
			// toolStripNew
			// 
			this.toolStripNew.Name = "toolStripNew";
			this.toolStripNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.toolStripNew.Size = new System.Drawing.Size(183, 24);
			this.toolStripNew.Text = "New";
			this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
			// 
			// toolStripOptions
			// 
			this.toolStripOptions.Name = "toolStripOptions";
			this.toolStripOptions.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripOptions.Size = new System.Drawing.Size(183, 24);
			this.toolStripOptions.Text = "Options";
			this.toolStripOptions.Click += new System.EventHandler(this.toolStripOptions_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
			// 
			// toolStripLoad
			// 
			this.toolStripLoad.Name = "toolStripLoad";
			this.toolStripLoad.Size = new System.Drawing.Size(183, 24);
			this.toolStripLoad.Text = "Load";
			// 
			// toolStripSave
			// 
			this.toolStripSave.Enabled = false;
			this.toolStripSave.Name = "toolStripSave";
			this.toolStripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.toolStripSave.Size = new System.Drawing.Size(183, 24);
			this.toolStripSave.Text = "Save";
			this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
			// 
			// toolStripExit
			// 
			this.toolStripExit.Name = "toolStripExit";
			this.toolStripExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.toolStripExit.Size = new System.Drawing.Size(183, 24);
			this.toolStripExit.Text = "Exit";
			this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
			// 
			// toolStripHelp
			// 
			this.toolStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsage,
            this.toolStripAbout});
			this.toolStripHelp.Name = "toolStripHelp";
			this.toolStripHelp.Size = new System.Drawing.Size(53, 24);
			this.toolStripHelp.Text = "Help";
			// 
			// toolStripUsage
			// 
			this.toolStripUsage.Name = "toolStripUsage";
			this.toolStripUsage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
			this.toolStripUsage.Size = new System.Drawing.Size(171, 24);
			this.toolStripUsage.Text = "Usage";
			this.toolStripUsage.Click += new System.EventHandler(this.toolStripUsage_Click);
			// 
			// toolStripAbout
			// 
			this.toolStripAbout.Name = "toolStripAbout";
			this.toolStripAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.toolStripAbout.Size = new System.Drawing.Size(171, 24);
			this.toolStripAbout.Text = "About";
			this.toolStripAbout.Click += new System.EventHandler(this.toolStripAbout_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(413, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "MenuStripMain";
			// 
			// pnlLabelPlayer
			// 
			this.pnlLabelPlayer.AllowDrop = true;
			this.pnlLabelPlayer.BackColor = System.Drawing.SystemColors.Control;
			this.pnlLabelPlayer.Location = new System.Drawing.Point(11, 4);
			this.pnlLabelPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlLabelPlayer.Name = "pnlLabelPlayer";
			this.pnlLabelPlayer.Size = new System.Drawing.Size(59, 73);
			this.pnlLabelPlayer.TabIndex = 1;
			// 
			// pnlLabelAvailable
			// 
			this.pnlLabelAvailable.BackColor = System.Drawing.SystemColors.Control;
			this.pnlLabelAvailable.Location = new System.Drawing.Point(13, 21);
			this.pnlLabelAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlLabelAvailable.Name = "pnlLabelAvailable";
			this.pnlLabelAvailable.Size = new System.Drawing.Size(59, 58);
			this.pnlLabelAvailable.TabIndex = 2;
			// 
			// pnlLabelSecret
			// 
			this.pnlLabelSecret.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlLabelSecret.BackColor = System.Drawing.SystemColors.Control;
			this.pnlLabelSecret.Location = new System.Drawing.Point(13, 21);
			this.pnlLabelSecret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlLabelSecret.Name = "pnlLabelSecret";
			this.pnlLabelSecret.Size = new System.Drawing.Size(59, 58);
			this.pnlLabelSecret.TabIndex = 4;
			// 
			// gbGuess
			// 
			this.gbGuess.AutoSize = true;
			this.gbGuess.BackColor = System.Drawing.SystemColors.Control;
			this.gbGuess.Controls.Add(this.pnlPlace);
			this.gbGuess.Location = new System.Drawing.Point(15, 155);
			this.gbGuess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbGuess.MaximumSize = new System.Drawing.Size(1013, 652);
			this.gbGuess.Name = "gbGuess";
			this.gbGuess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbGuess.Size = new System.Drawing.Size(379, 159);
			this.gbGuess.TabIndex = 5;
			this.gbGuess.TabStop = false;
			this.gbGuess.Text = "Play field";
			// 
			// pnlPlace
			// 
			this.pnlPlace.AutoScroll = true;
			this.pnlPlace.BackColor = System.Drawing.SystemColors.Control;
			this.pnlPlace.Controls.Add(this.pnlButton);
			this.pnlPlace.Controls.Add(this.pnlLabelFB);
			this.pnlPlace.Controls.Add(this.pnlLabelPlayer);
			this.pnlPlace.Location = new System.Drawing.Point(3, 18);
			this.pnlPlace.Margin = new System.Windows.Forms.Padding(4);
			this.pnlPlace.MaximumSize = new System.Drawing.Size(1000, 628);
			this.pnlPlace.Name = "pnlPlace";
			this.pnlPlace.Size = new System.Drawing.Size(356, 118);
			this.pnlPlace.TabIndex = 8;
			// 
			// pnlButton
			// 
			this.pnlButton.BackColor = System.Drawing.SystemColors.Control;
			this.pnlButton.Location = new System.Drawing.Point(145, 4);
			this.pnlButton.Margin = new System.Windows.Forms.Padding(4);
			this.pnlButton.Name = "pnlButton";
			this.pnlButton.Size = new System.Drawing.Size(61, 73);
			this.pnlButton.TabIndex = 3;
			// 
			// pnlLabelFB
			// 
			this.pnlLabelFB.BackColor = System.Drawing.SystemColors.Control;
			this.pnlLabelFB.Location = new System.Drawing.Point(76, 4);
			this.pnlLabelFB.Margin = new System.Windows.Forms.Padding(4);
			this.pnlLabelFB.Name = "pnlLabelFB";
			this.pnlLabelFB.Size = new System.Drawing.Size(61, 73);
			this.pnlLabelFB.TabIndex = 2;
			// 
			// lblStartNewGame
			// 
			this.lblStartNewGame.BackColor = System.Drawing.SystemColors.Control;
			this.lblStartNewGame.Location = new System.Drawing.Point(77, 18);
			this.lblStartNewGame.Name = "lblStartNewGame";
			this.lblStartNewGame.Size = new System.Drawing.Size(181, 71);
			this.lblStartNewGame.TabIndex = 2;
			this.lblStartNewGame.Text = "Start a new game with ctrl+N or File > New game.";
			// 
			// gbSecretCode
			// 
			this.gbSecretCode.BackColor = System.Drawing.SystemColors.Control;
			this.gbSecretCode.Controls.Add(this.pnlLabelSecret);
			this.gbSecretCode.Location = new System.Drawing.Point(15, 334);
			this.gbSecretCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbSecretCode.Name = "gbSecretCode";
			this.gbSecretCode.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbSecretCode.Size = new System.Drawing.Size(379, 94);
			this.gbSecretCode.TabIndex = 6;
			this.gbSecretCode.TabStop = false;
			this.gbSecretCode.Text = "Secret code";
			// 
			// gbAvailable
			// 
			this.gbAvailable.BackColor = System.Drawing.SystemColors.Control;
			this.gbAvailable.Controls.Add(this.lblStartNewGame);
			this.gbAvailable.Controls.Add(this.pnlLabelAvailable);
			this.gbAvailable.ForeColor = System.Drawing.SystemColors.ControlText;
			this.gbAvailable.Location = new System.Drawing.Point(15, 48);
			this.gbAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbAvailable.Name = "gbAvailable";
			this.gbAvailable.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbAvailable.Size = new System.Drawing.Size(379, 102);
			this.gbAvailable.TabIndex = 7;
			this.gbAvailable.TabStop = false;
			this.gbAvailable.Text = "Available";
			// 
			// FrmMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(413, 441);
			this.Controls.Add(this.gbAvailable);
			this.Controls.Add(this.gbSecretCode);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.gbGuess);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mastermind";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gbGuess.ResumeLayout(false);
			this.pnlPlace.ResumeLayout(false);
			this.gbSecretCode.ResumeLayout(false);
			this.gbAvailable.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem toolStripFile;
		private System.Windows.Forms.ToolStripMenuItem toolStripNew;
		private System.Windows.Forms.ToolStripMenuItem toolStripOptions;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		public System.Windows.Forms.ToolStripMenuItem toolStripLoad;
		internal System.Windows.Forms.ToolStripMenuItem toolStripSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripExit;
		private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
		private System.Windows.Forms.ToolStripMenuItem toolStripUsage;
		private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
		private System.Windows.Forms.MenuStrip menuStrip1;
		public System.Windows.Forms.Panel pnlLabelPlayer;
		public System.Windows.Forms.Panel pnlLabelAvailable;
		public System.Windows.Forms.Panel pnlLabelSecret;
		public System.Windows.Forms.GroupBox gbGuess;
		public System.Windows.Forms.GroupBox gbSecretCode;
		public System.Windows.Forms.GroupBox gbAvailable;
		public System.Windows.Forms.Label lblStartNewGame;
		public System.Windows.Forms.Panel pnlButton;
		public System.Windows.Forms.Panel pnlLabelFB;
		public System.Windows.Forms.Panel pnlPlace;
	}/*FrmMain*/
}/*Mastermind*/