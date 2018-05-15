namespace FaceRek
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.imbxCurrentFrame = new Emgu.CV.UI.ImageBox();
			this.btnToggleCamera = new System.Windows.Forms.Button();
			this.btnLockFrame = new System.Windows.Forms.Button();
			this.btnToggleMonitoring = new System.Windows.Forms.Button();
			this.txtFaceXLocked = new System.Windows.Forms.TextBox();
			this.txtFaceYLocked = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFaceYCurrent = new System.Windows.Forms.TextBox();
			this.txtFaceXCurrent = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.stbNotifications = new System.Windows.Forms.ToolStripStatusLabel();
			this.cbWithinX = new System.Windows.Forms.CheckBox();
			this.cbWithinY = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.imbxCurrentFrame)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imbxCurrentFrame
			// 
			this.imbxCurrentFrame.Location = new System.Drawing.Point(23, 140);
			this.imbxCurrentFrame.Name = "imbxCurrentFrame";
			this.imbxCurrentFrame.Size = new System.Drawing.Size(640, 480);
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
			// btnToggleMonitoring
			// 
			this.btnToggleMonitoring.Location = new System.Drawing.Point(185, 12);
			this.btnToggleMonitoring.Name = "btnToggleMonitoring";
			this.btnToggleMonitoring.Size = new System.Drawing.Size(75, 44);
			this.btnToggleMonitoring.TabIndex = 5;
			this.btnToggleMonitoring.Text = "Toggle Monitoring";
			this.btnToggleMonitoring.UseVisualStyleBackColor = true;
			this.btnToggleMonitoring.Click += new System.EventHandler(this.btnToggleMonitoring_Click);
			// 
			// txtFaceXLocked
			// 
			this.txtFaceXLocked.Location = new System.Drawing.Point(116, 62);
			this.txtFaceXLocked.Name = "txtFaceXLocked";
			this.txtFaceXLocked.Size = new System.Drawing.Size(100, 20);
			this.txtFaceXLocked.TabIndex = 6;
			// 
			// txtFaceYLocked
			// 
			this.txtFaceYLocked.Location = new System.Drawing.Point(116, 88);
			this.txtFaceYLocked.Name = "txtFaceYLocked";
			this.txtFaceYLocked.Size = new System.Drawing.Size(100, 20);
			this.txtFaceYLocked.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Locked Face X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Locked Face Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(268, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Current Face Y:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(268, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Current Face X:";
			// 
			// txtFaceYCurrent
			// 
			this.txtFaceYCurrent.Location = new System.Drawing.Point(360, 88);
			this.txtFaceYCurrent.Name = "txtFaceYCurrent";
			this.txtFaceYCurrent.Size = new System.Drawing.Size(100, 20);
			this.txtFaceYCurrent.TabIndex = 11;
			// 
			// txtFaceXCurrent
			// 
			this.txtFaceXCurrent.Location = new System.Drawing.Point(360, 62);
			this.txtFaceXCurrent.Name = "txtFaceXCurrent";
			this.txtFaceXCurrent.Size = new System.Drawing.Size(100, 20);
			this.txtFaceXCurrent.TabIndex = 10;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbNotifications});
			this.statusStrip1.Location = new System.Drawing.Point(0, 631);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(684, 22);
			this.statusStrip1.TabIndex = 14;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// stbNotifications
			// 
			this.stbNotifications.Name = "stbNotifications";
			this.stbNotifications.Size = new System.Drawing.Size(0, 17);
			// 
			// cbWithinX
			// 
			this.cbWithinX.AutoSize = true;
			this.cbWithinX.Location = new System.Drawing.Point(534, 64);
			this.cbWithinX.Name = "cbWithinX";
			this.cbWithinX.Size = new System.Drawing.Size(66, 17);
			this.cbWithinX.TabIndex = 15;
			this.cbWithinX.Text = "Within X";
			this.cbWithinX.UseVisualStyleBackColor = true;
			// 
			// cbWithinY
			// 
			this.cbWithinY.AutoSize = true;
			this.cbWithinY.Location = new System.Drawing.Point(534, 90);
			this.cbWithinY.Name = "cbWithinY";
			this.cbWithinY.Size = new System.Drawing.Size(66, 17);
			this.cbWithinY.TabIndex = 16;
			this.cbWithinY.Text = "Within Y";
			this.cbWithinY.UseVisualStyleBackColor = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 653);
			this.Controls.Add(this.cbWithinY);
			this.Controls.Add(this.cbWithinX);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFaceYCurrent);
			this.Controls.Add(this.txtFaceXCurrent);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFaceYLocked);
			this.Controls.Add(this.txtFaceXLocked);
			this.Controls.Add(this.btnToggleMonitoring);
			this.Controls.Add(this.btnLockFrame);
			this.Controls.Add(this.btnToggleCamera);
			this.Controls.Add(this.imbxCurrentFrame);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Posture Watcher";
			((System.ComponentModel.ISupportInitialize)(this.imbxCurrentFrame)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Emgu.CV.UI.ImageBox imbxCurrentFrame;
		private System.Windows.Forms.Button btnToggleCamera;
		private System.Windows.Forms.Button btnLockFrame;
		private System.Windows.Forms.Button btnToggleMonitoring;
		private System.Windows.Forms.TextBox txtFaceXLocked;
		private System.Windows.Forms.TextBox txtFaceYLocked;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFaceYCurrent;
		private System.Windows.Forms.TextBox txtFaceXCurrent;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel stbNotifications;
		private System.Windows.Forms.CheckBox cbWithinX;
		private System.Windows.Forms.CheckBox cbWithinY;
	}
}

