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
				//_cameraCapture.Width = 600;
				//_cameraCapture.set(CV_CAP_PROP_FRAME_HEIGHT, 480);
				//_cameraCapture.set(CV_CAP_PROP_FOURCC, CV_FOURCC('B', 'G', 'R', '3'));
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return;
			}

			//_fgDetector = new BackgroundSubtractorMOG2();
			//_blobDetector = new CvBlobDetector();
			//_tracker = new CvTracks();

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
				CvInvoke.Rectangle(frame, face, new Bgr(Color.Red).MCvScalar, 2);
			foreach (Rectangle eye in eyes)
				CvInvoke.Rectangle(frame, eye, new Bgr(Color.Blue).MCvScalar, 2);
			//Mat smoothedFrame = new Mat();
			//CvInvoke.GaussianBlur(frame, smoothedFrame, new Size(3, 3), 1); //filter out noises
			////frame._SmoothGaussian(3); 

			//#region use the BG/FG detector to find the forground mask
			//Mat forgroundMask = new Mat();
			//_fgDetector.Apply(smoothedFrame, forgroundMask);
			//#endregion

			//CvBlobs blobs = new CvBlobs();
			//_blobDetector.Detect(forgroundMask.ToImage<Gray, byte>(), blobs);
			//blobs.FilterByArea(100, int.MaxValue);

			//float scale = (frame.Width + frame.Width) / 2.0f;
			//_tracker.Update(blobs, 0.01 * scale, 5, 5);

			//foreach (var pair in _tracker)
			//{
			//	CvTrack b = pair.Value;
			//	CvInvoke.Rectangle(frame, b.BoundingBox, new MCvScalar(255.0, 255.0, 255.0), 2);
			//	CvInvoke.PutText(frame, b.Id.ToString(), new Point((int)Math.Round(b.Centroid.X), (int)Math.Round(b.Centroid.Y)), FontFace.HersheyPlain, 1.0, new MCvScalar(255.0, 255.0, 255.0));
			//}
			imbxCurrentFrame.Image = frame.ToImage<>();
		}
	}
}
