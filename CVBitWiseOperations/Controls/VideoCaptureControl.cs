using Emgu.CV;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace CVBitWiseOperations.Controls
{
    public partial class VideoCaptureControl : BaseUserControl
    {
        public struct SelectCameraItem
        {
            public string Name { get; set; }
            public int CameraIndex { get; set; }

            public SelectCameraItem(string name, int cameraIndex)
            {
                Name = name;
                CameraIndex = cameraIndex;
            }

            public override string ToString()
            {
                return Name;
            }
        }


        public static List<string> Cameras;
        static VideoCaptureControl()
        {
            Cameras = GetCameras();
        }

        public VideoCapture VideoCapture;
        public VideoCaptureControl()
        {
            InitializeComponent();
            VideoCapture = null;
            Application.Idle += GrabVideoFrame;
        }

        private void GrabVideoFrame(object sender, EventArgs e)
        {
            if (VideoCapture == null || !VideoCapture.IsOpened) return;
            if (!VideoCapture.Grab()) return;

            using Mat frame = VideoCapture.QueryFrame();
            CvInvoke.Flip(frame, frame, Emgu.CV.CvEnum.FlipType.Horizontal);

            CameraFeed.Image?.Dispose();
            CameraFeed.Image = frame.Clone();
        }

        private void VideoCaptureControl_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Cameras.Count; i ++)
            {
                int ii = i;
                SelectCamera.Items.Add(new SelectCameraItem(Cameras[ii], ii));
            }
        }

        public static List<string> GetCameras()
        {
            var cameraNames = new List<string>();
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE (PNPClass = 'Image' OR PNPClass = 'Camera')"))
            {
                foreach (var device in searcher.Get())
                {
                    cameraNames.Add(device["Caption"].ToString());
                }
            }

            return cameraNames;
        }

        private void TakePicture_Click(object sender, EventArgs e)
        {
            Result.SetImage((Mat)CameraFeed.Image, true);
        }

        private void AddCamServer_Click(object sender, EventArgs e)
        {

        }

        private void SelectCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCamera = ((SelectCameraItem)SelectCamera.SelectedItem).CameraIndex;
            VideoCapture = new VideoCapture(selectedCamera);
            CameraFeed.Image = VideoCapture.QueryFrame();
        }
    }
}
