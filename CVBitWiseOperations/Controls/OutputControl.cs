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
    public partial class OutputControl : UserControl
    {
        public OutputControl()
        {
            InitializeComponent();
        }

        public string OldName { get; set; }

        public Mat Image
        {
            get
            {
                return (Mat)OutputImage.Image;
            }
        }

        public void SetImage(Mat image, bool shouldClone)
        {
            if (image == null) { return; }

            using Mat old = Image?.Clone();
            if(shouldClone)
            {
                OutputImage.Image = image.Clone();
            }
            else
            {
                OutputImage.Image = image;
            }
            ImageUpdated?.Invoke(this, new UpdateImageEvent(old?.Clone(), Image.Clone()));
            //might need to not have a clone here later
        }

        public event EventHandler<UpdateNameEvent> NameUpdated;
        public event EventHandler<UpdateImageEvent> ImageUpdated;

        private void Output_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new SaveFileDialog() { AddExtension = true, Filter = "Image Files|*.jpg;*.jpeg;*.jfif;*.png" };
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                CvInvoke.Imwrite(dialog.FileName, Image);
            }
        }

        private int minWidth;
        private int maxWidth;
        private void OutputControl_Load(object sender, EventArgs e)
        {
            minWidth = 60;
            maxWidth = 100;
            NameText.Size = new Size(minWidth, NameText.Height);
        }

        public string ImageName => NameText.Text;
        private void NameText_TextChanged(object sender, EventArgs e)
        {
            Size sizeOfText = TextRenderer.MeasureText(NameText.Text, Font);

            NameText.Size = new Size(Math.Min(Math.Max(sizeOfText.Width, minWidth), maxWidth), NameText.Height);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameUpdated?.Invoke(this, new UpdateNameEvent(OldName, NameText.Text));
            OldName = NameText.Text;
        }

        private void FlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
