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
    public partial class OutputControl : UserControl, ICanChangeName
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
            set
            { 
                OutputImage.Image = value;
            }
        }

        public event EventHandler<NewNameEvent> NameChanged;

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
            minWidth = 150;
            maxWidth = 280;
            NameText.Size = new Size(minWidth, NameText.Height);
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            Size sizeOfText = TextRenderer.MeasureText(NameText.Text, Font);

            NameText.Size = new Size(Math.Min(Math.Max(sizeOfText.Width, minWidth), maxWidth), NameText.Height);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameChanged?.Invoke(this, new NewNameEvent(OldName, NameText.Text));
            OldName = NameText.Text;
        }

        private void FlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
