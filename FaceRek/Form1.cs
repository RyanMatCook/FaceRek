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
	public partial class Form1 : Form
	{

		private static VideoCapture _cameraCapture;

		private static IBackgroundSubtractor _fgDetector;
		private static Emgu.CV.Cvb.CvBlobDetector _blobDetector;
		private static Emgu.CV.Cvb.CvTracks _tracker;

		public Form1()
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
				MessageBox.Show(e.Message);
				return;
			}

			Application.Idle += ProcessFrame;
		}

		void ProcessFrame(object sender, EventArgs e)
		{
			_cameraCapture.QueryFrame();
			Mat frame = _cameraCapture.QueryFrame();

			List<Rectangle> faces = new List<Rectangle>();
			List<Rectangle> eyes = new List<Rectangle>();
			DetectFace.Detect(frame, faces, eyes, out var detectionTime);
			detectionTime++;

			foreach (Rectangle face in faces)
				CvInvoke.Rectangle(frame, face, new Bgr(Color.Yellow).MCvScalar, 1);
			foreach (Rectangle eye in eyes)
				CvInvoke.Rectangle(frame, eye, new Bgr(Color.Green).MCvScalar, 1);
			
			imbxCurrentFrame.Image = frame;
		}

		private void btnToggleCamera_Click(object sender, EventArgs e)
		{

		}

		private void btnLockFrame_Click(object sender, EventArgs e)
		{

		}
	}
}
