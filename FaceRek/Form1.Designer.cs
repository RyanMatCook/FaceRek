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
			this.btnToggleCamera = new System.Windows.Forms.Button();
			this.btnLockFrame = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imbxCurrentFrame)).BeginInit();
			this.SuspendLayout();
			// 
			// imbxCurrentFrame
			// 
			this.imbxCurrentFrame.Location = new System.Drawing.Point(23, 62);
			this.imbxCurrentFrame.Name = "imbxCurrentFrame";
			this.imbxCurrentFrame.Size = new System.Drawing.Size(414, 282);
			this.imbxCurrentFrame.TabIndex = 2;
			this.imbxCurrentFrame.TabStop = false;
			// 
			// btnToggleCamera
			// 
			this.btnToggleCamera.Location = new System.Drawing.Point(23, 12);
			this.btnToggleCamera.Name = "btnToggleCamera";
			this.btnToggleCamera.Size = new System.Drawing.Size(75, 44);
			this.btnToggleCamera.TabIndex = 3;
			this.btnToggleCamera.Text = "Toggle Camera";
			this.btnToggleCamera.UseVisualStyleBackColor = true;
			this.btnToggleCamera.Click += new System.EventHandler(this.btnToggleCamera_Click);
			// 
			// btnLockFrame
			// 
			this.btnLockFrame.Location = new System.Drawing.Point(104, 12);
			this.btnLockFrame.Name = "btnLockFrame";
			this.btnLockFrame.Size = new System.Drawing.Size(75, 44);
			this.btnLockFrame.TabIndex = 4;
			this.btnLockFrame.Text = "Lock frame";
			this.btnLockFrame.UseVisualStyleBackColor = true;
			this.btnLockFrame.Click += new System.EventHandler(this.btnLockFrame_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLockFrame);
			this.Controls.Add(this.btnToggleCamera);
			this.Controls.Add(this.imbxCurrentFrame);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.imbxCurrentFrame)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Emgu.CV.UI.ImageBox imbxCurrentFrame;
		private System.Windows.Forms.Button btnToggleCamera;
		private System.Windows.Forms.Button btnLockFrame;
	}
}

