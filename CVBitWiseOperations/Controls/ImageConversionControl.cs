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
            Result.NameChanged += Result_NameChanged;
            Mat = new Mat();
            SelectConversion.Items.Add(new SelectConversionItem("GreyScaleToRGB", () =>
            {
                CvInvoke.CvtColor(Input.Image, Mat, Emgu.CV.CvEnum.ColorConversion.Gray2Rgb);
                Result.Image = Mat.Clone();
            })) ;
            SelectConversion.Items.Add(new SelectConversionItem("RGBToHSV", () =>
            {
                CvInvoke.CvtColor(Input.Image, Mat, Emgu.CV.CvEnum.ColorConversion.Rgb2Hsv);
                Result.Image = Mat.Clone();
            }));
        }

        private void Result_NameChanged(object sender, NewNameEvent e)
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
