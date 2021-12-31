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
    public partial class BlurControl : BaseUserControl
    {
        public struct SelectBlurItem
        {
            public string Name { get; set; }
            public Action<int> Blur { get; set; }

            public SelectBlurItem(string name, Action<int> blur)
            {
                Name = name;
                Blur = blur;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public Mat Mat { get; set; }

        public BlurControl()
        {
            InitializeComponent();
        }

        private Action<int> operation;
        private void BlurControl_Load(object sender, EventArgs e)
        {
            Result.NameUpdated += Result_NameChanged;
            Mat = new Mat();
            operation = (int x) => { };
            CernelValue.Value = 5;
            CernelValue.Minimum = 0;
            CernelValue.Maximum = 500;
            SelectBlur.Items.Add(new SelectBlurItem("Simple", (int cernel) => CvInvoke.Blur(Input.Image.Clone(), Mat, new Size(cernel, cernel), new Point(-1, -1))));
            SelectBlur.Items.Add(new SelectBlurItem("Gaussian", (int cernel) => CvInvoke.GaussianBlur(Input.Image.Clone(), Mat, new Size(cernel, cernel), 0)));
            SelectBlur.Items.Add(new SelectBlurItem("Median", (int cernel) => CvInvoke.MedianBlur(Input.Image.Clone(), Mat, cernel)));
        }


        private void Result_NameChanged(object sender, UpdateNameEvent e)
        {
            UpdateName(((OutputControl)sender).Image, e.OldName, e.NewName);
        }

        public Color[][] Blur (Color[][] colors, int cernel)
        {
            Color[][] returnArray = new Color[colors.Length][];
            int margin = (cernel - 1) / 2;
            for(int y = margin; y < colors.Length - margin; y++)
            {
                returnArray[y] = new Color[colors[y].Length];
                for(int x = margin; x < colors[y].Length - margin; x ++)
                {
                    int R = 0;
                    int G = 0;
                    int B = 0;
                    for(int y2 = -margin; y2 < margin + 1; y2 ++)
                    {
                        for(int x2 = -margin; x2 < margin + 1; x2 ++)
                        {
                            Color currentColor = colors[y + y2][x + x2];
                            R += currentColor.R;
                            G += currentColor.G;
                            B += currentColor.B;
                        }
                    }
                    R /= (cernel * cernel);
                    G /= (cernel * cernel);
                    B /= (cernel * cernel);
                    returnArray[y][x] = Color.FromArgb(255, R, G, B);
                }
            }
            return returnArray;
        }

        private int previousCernel = 0;
        private void CernelValue_ValueChanged(object sender, EventArgs e)
        {
            if(CernelValue.Value < 3)
            {
                CernelValue.Value = 3;
            }
            if(CernelValue.Value % 2 == 0)
            {
                if(previousCernel < CernelValue.Value)
                {
                    CernelValue.Value += 1;
                }
                else
                {
                    CernelValue.Value -= 1;
                }
            }
            previousCernel = (int)CernelValue.Value;
            int cernelSize = (int)CernelValue.Value;
            operation(((int)CernelValue.Value));
            Result.SetImage(Mat, true);
        }

        private void SelectBlur_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = ((SelectBlurItem)SelectBlur.SelectedItem).Blur;
            operation(((int)CernelValue.Value));
            Result.SetImage(Mat, true);
        }
    }
}
