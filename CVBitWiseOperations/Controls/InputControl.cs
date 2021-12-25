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
    public partial class InputControl : UserControl, ICanReturnImage
    {

        

        public Mat Image
        {
            get
            {
                return ((Mat)SelectedImage.Image).Clone();
            }
            set
            {
                SelectedImage.Image = value;
            }
        }

        public InputControl()
        {
            InitializeComponent();
        }

        public event EventHandler<NewImageEvent> ImageReturned;

        public void RemoveInput(string input)
        {
            SelectImage.Items.Remove(input);
        }
        public void AddInput(string input)
        {
            SelectImage.Items.Add(input);
        }

        private void SelectionControl_Load(object sender, EventArgs e)
        {

        }

        private void SelectImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            using Mat oldImage = Image.Clone();
            Image = BaseUserControl.SavedImages[(string)SelectImage.SelectedItem];
            ImageReturned?.Invoke(this, new NewImageEvent(oldImage, Image));
        }

        private void Image_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                using Mat loaded = CvInvoke.Imread(dialog.FileName);
                Image = loaded.Clone();
            }
            ImageReturned.Invoke(this, new NewImageEvent(null, Image));
        }
    }
}
