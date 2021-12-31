using Emgu.CV;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CVBitWiseOperations.Controls
{
    public partial class ImageConversionControl : BaseUserControl
    {
        public struct SelectConversionItem
        {
            public string Name { get; set; }
            public Action Conversion { get; set; }

            public SelectConversionItem(string name, Action conversion)
            {
                Name = name;
                Conversion = conversion;
            }


            public override string ToString()
            {
                return Name;
            }
        }

        public Mat Mat { get; set; }
        public ImageConversionControl()
        {
            InitializeComponent();
        }

        private void ImageConversionControl_Load(object sender, EventArgs e)
        {
            Result.NameUpdated += Result_NameChanged;
            Mat = new Mat();
            SelectConversion.Items.Add(new SelectConversionItem("RGB To GreyScale", () =>
            {
                CvInvoke.CvtColor(Input.Image.Clone(), Mat, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);
                Result.SetImage(Mat, true);
            }));
            SelectConversion.Items.Add(new SelectConversionItem("GreyScale To RGB", () =>
            {
                CvInvoke.CvtColor(Input.Image.Clone(), Mat, Emgu.CV.CvEnum.ColorConversion.Gray2Rgb);
                Result.SetImage(Mat, true);
            })) ;
            SelectConversion.Items.Add(new SelectConversionItem("RGB To HSV", () =>
            {
                CvInvoke.CvtColor(Input.Image.Clone(), Mat, Emgu.CV.CvEnum.ColorConversion.Rgb2Hsv);
                Result.SetImage(Mat, true);
            }));
        }

        private void Result_NameChanged(object sender, UpdateNameEvent e)
        {
            UpdateName(((OutputControl)sender).Image, e.OldName, e.NewName);
        }

        private void SelectConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((SelectConversionItem)SelectConversion.SelectedItem).Conversion();
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}
