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
    public partial class SelectionControl : UserControl
    {
        public Mat Mat { get; set; }

        public SelectionControl()
        {
            Mat = new Mat();
            InitializeComponent();
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                using Mat loaded = CvInvoke.Imread(dialog.FileName);
                Image.Image = loaded;
                Mat = loaded.Clone();

            }
        }

        private void SelectionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
