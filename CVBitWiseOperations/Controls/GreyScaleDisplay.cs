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
            ROutput.NameChanged += ROutput_NameChanged;
            GOutput.NameChanged += GOutput_NameChanged;
            BOutput.NameChanged += BOutput_NameChanged;
        }

        private void BOutput_NameChanged(object sender, NewNameEvent e)
        {
            UpdateName(((ICanChangeName)sender).Image.Clone(), e.OldName, e.NewName);
        }

        private void GOutput_NameChanged(object sender, NewNameEvent e)
        {
            UpdateName(((ICanChangeName)sender).Image.Clone(), e.OldName, e.NewName);
        }

        private void ROutput_NameChanged(object sender, NewNameEvent e)
        {
            UpdateName(((ICanChangeName)sender).Image.Clone(), e.OldName, e.NewName);
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
