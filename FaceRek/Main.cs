using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace FaceRek
{
	public partial class Main : Form
	{
		public bool MonitoringActive { get { return _monitoringActive; } set { _monitoringActive = value; } }
		private bool _monitoringActive;
		Rectangle LockedFrame
		{
			get
			{
				return _lockedFrame;
			}
			set
			{
				if (value == null)
				{
					FrameIsLocked = false;
					_lockedFrame = new Rectangle();
				}
				else
				{
					FrameIsLocked = true;
					_lockedFrame = value;
				}
			}
		}
		private Rectangle _lockedFrame;

		public bool FrameIsLocked { get => _frameIsLocked; set => _frameIsLocked = value; }
		private bool _frameIsLocked;

		int ThresholdX = 25, ThresholdY = 35;

		private static VideoCapture _cameraCapture;

		private volatile bool CameraActive = false;

		public Main()
		{
			InitializeComponent();
			Run();
		}

		void Run()
		{
			try
			{
				_cameraCapture = new VideoCapture();
			}
			catch (Exception e)
			{
				stbNotifications.ForeColor = Color.Red;
				stbNotifications.Text = e.Message;
				return;
			}

			Application.Idle += ProcessFrame;
			CameraActive = true;
		}

		void ProcessFrame(object sender, EventArgs e)
		{
			stbNotifications.Text = "";

			Mat frame = _cameraCapture.QueryFrame();

			List<Rectangle> faces = new List<Rectangle>();
			DetectFace.Detect(frame, faces);

			foreach (Rectangle face in faces)
				CvInvoke.Rectangle(frame, face, new Bgr(Color.Orange).MCvScalar, 1);

			var lockFrameColour = Color.DarkMagenta;
			if (faces.Count > 1)
			{
				stbNotifications.ForeColor = Color.Orange;
				stbNotifications.Text = "More than 1 face detected.";
			}
			else if (faces.Count == 0 && MonitoringActive)
			{
				stbNotifications.ForeColor = Color.Orange;
				stbNotifications.Text = "Warning! No face detected.";
			}
			else if (faces.Count == 1)
			{
				var detectedFace = faces[0];
				// 1 Face detected
				txtFaceXCurrent.Text = detectedFace.Location.X.ToString();
				txtFaceYCurrent.Text = detectedFace.Location.Y.ToString();

				var withinXThreshold = LockedFrame.Left <= detectedFace.Left + ThresholdX && LockedFrame.Right >= detectedFace.Right - ThresholdX;
				var withinYThreshold = LockedFrame.Top >= detectedFace.Top - ThresholdY && LockedFrame.Bottom <= detectedFace.Bottom + ThresholdY;

				cbWithinX.Checked = withinXThreshold;
				cbWithinY.Checked = withinYThreshold;

				if (MonitoringActive && !(withinYThreshold || withinXThreshold))
				{
					lockFrameColour = Color.Red;
					stbNotifications.ForeColor = Color.Red;
					stbNotifications.Text = "Mind your posture!";
				}
				else if (MonitoringActive && withinXThreshold && withinYThreshold)
				{
					lockFrameColour = Color.Green;
				}
			}

			if (FrameIsLocked)
			{
				CvInvoke.Rectangle(frame, LockedFrame, new Bgr(lockFrameColour).MCvScalar, 2);
			}

			if (CameraActive)
				imbxCurrentFrame.Image = frame;
			else
				imbxCurrentFrame.Image = null;
		}

		private void btnToggleCamera_Click(object sender, EventArgs e)
		{
			CameraActive = !CameraActive;
		}

		private void btnToggleMonitoring_Click(object sender, EventArgs e)
		{
			if (FrameIsLocked)
			{
				MonitoringActive = !MonitoringActive;
				if(MonitoringActive)
					notifyIcon1.ShowBalloonTip(1000, "title", "text", ToolTipIcon.Info);
			}
			else
			{
				stbNotifications.ForeColor = Color.Orange;
				stbNotifications.Text = "Please use the \"Lock Frame\" button ";
			}
		}

		private void btnLockFrame_Click(object sender, EventArgs e)
		{
			Mat frame = _cameraCapture.QueryFrame();
			List<Rectangle> faces = new List<Rectangle>();
			DetectFace.Detect(frame, faces);

			if (faces.Count > 1)
			{
				stbNotifications.ForeColor = Color.Orange;
				stbNotifications.Text = "More than one face was detected. This program is intended for one face only.";
			}
			else if (faces.Count == 0)
			{
				stbNotifications.ForeColor = Color.Orange;
				stbNotifications.Text = "No face detected. Maybe give it a wash?";
			}
			else
			{
				LockedFrame = faces[0];
				txtFaceXLocked.Text = LockedFrame.Location.X.ToString();
				txtFaceYLocked.Text = LockedFrame.Location.Y.ToString();
			}
		}
	}
}
