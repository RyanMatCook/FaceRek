namespace FaceRek
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.imbxCurrentFrame = new Emgu.CV.UI.ImageBox();
			((System.ComponentModel.ISupportInitialize)(this.imbxCurrentFrame)).BeginInit();
			this.SuspendLayout();
			// 
			// imbxCurrentFrame
			// 
			this.imbxCurrentFrame.Location = new System.Drawing.Point(169, 75);
			this.imbxCurrentFrame.Name = "imbxCurrentFrame";
			this.imbxCurrentFrame.Size = new System.Drawing.Size(414, 282);
			this.imbxCurrentFrame.TabIndex = 2;
			this.imbxCurrentFrame.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.imbxCurrentFrame);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.imbxCurrentFrame)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Emgu.CV.UI.ImageBox imbxCurrentFrame;
	}
}

