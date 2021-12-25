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
                return ((Mat)OutputImage.Image).Clone();
            }
            set
            { 
                OutputImage.Image = value;
            }
        }

        public event EventHandler<NewNameEvent> NameChanged;

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void OutputControl_Load(object sender, EventArgs e)
        {
            NameText.Size = new Size(60, NameText.Height);
            
        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {
            Size sizeOfText = TextRenderer.MeasureText(NameText.Text, Font);

            NameText.Size = new Size(Math.Min(Math.Max(sizeOfText.Width, 60), 100), NameText.Height);
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
