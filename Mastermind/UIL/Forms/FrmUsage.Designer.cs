namespace Mastermind {
	partial class FrmUsage {
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
			this.rtbUsage = new System.Windows.Forms.RichTextBox();
			this.button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtbUsage
			// 
			this.rtbUsage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.rtbUsage.DetectUrls = false;
			this.rtbUsage.Location = new System.Drawing.Point(12, 12);
			this.rtbUsage.Name = "rtbUsage";
			this.rtbUsage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbUsage.Size = new System.Drawing.Size(554, 630);
			this.rtbUsage.TabIndex = 0;
			this.rtbUsage.Text = "";
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(462, 119);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(75, 23);
			this.button.TabIndex = 1;
			this.button.Text = "button1";
			this.button.UseVisualStyleBackColor = true;
			// 
			// FrmUsage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 654);
			this.Controls.Add(this.rtbUsage);
			this.Controls.Add(this.button);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmUsage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmUsage";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbUsage;
		private System.Windows.Forms.Button button;
	}
}