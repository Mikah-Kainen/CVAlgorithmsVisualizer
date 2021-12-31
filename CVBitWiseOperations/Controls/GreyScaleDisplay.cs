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
    public partial class GreyScaleDisplay : BaseUserControl
    {
        public GreyScaleDisplay()
        {
            InitializeComponent();
        }

        private void GreyScaleDisplay_Load(object sender, EventArgs e)
        {
            Input.ImageReturned += Input_ImageReturned;
        }

        private void Input_ImageReturned(object sender, NewImageEvent e)
        {
            (Mat R, Mat G, Mat B) GreyScaleMats = e.NewImage.Clone().GetRGBGreyScale();
            ROutput.SetImage(GreyScaleMats.R, true);
            GOutput.SetImage(GreyScaleMats.G, true);
            BOutput.SetImage(GreyScaleMats.B, true);
        }

        private void outputControl3_Load(object sender, EventArgs e)
        {

        }

        private void inputControl1_Load(object sender, EventArgs e)
        {

        }

        private void ROutput_Load(object sender, EventArgs e)
        {

        }
    }
}
