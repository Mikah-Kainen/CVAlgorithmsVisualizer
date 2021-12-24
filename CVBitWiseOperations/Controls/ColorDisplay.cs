using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CVBitWiseOperations.Controls
{
    public partial class ColorDisplay : BaseUserControl
    {
        public ColorDisplay()
        {
            InitializeComponent();
        }

        private void R_Click(object sender, EventArgs e)
        {

        }

        private void G_Click(object sender, EventArgs e)
        {

        }

        private void ImageSelection_Load(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            if (ImageSelection.Image == null) { return; }

            (int RVal, int GVal, int BVal) = ImageSelection.Image.GetRGB();
            RValue.Text = $"{RVal}";
            GValue.Text = $"{GVal}";
            BValue.Text = $"{BVal}";

            int GreyScaleVal = RVal + GVal + BVal;
            GreyScaleVal /= 3;
            GreyScaleValue.Text = $"{GreyScaleVal}";
        }

        private void ColorDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
