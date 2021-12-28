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

        public struct CernelSizeSelectionItem
        {
            public string Name { get; set; }
            public int CernelSize { get; set; }

            public CernelSizeSelectionItem(string name, int cernelSize)
            {
                Name = name;
                CernelSize = cernelSize;
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

        private void BlurControl_Load(object sender, EventArgs e)
        {
            Result.NameChanged += Result_NameChanged;
            Mat = new Mat();
            SelectCernelSize.Items.Add(new CernelSizeSelectionItem("3 by 3", 3));
            SelectCernelSize.Items.Add(new CernelSizeSelectionItem("5 by 5", 5));
            SelectCernelSize.Items.Add(new CernelSizeSelectionItem("7 by 7", 7));
            SelectCernelSize.Items.Add(new CernelSizeSelectionItem("9 by 9", 9));
            SelectCernelSize.Items.Add(new CernelSizeSelectionItem("11 by 11", 11));
        }

        private void SelectCernelSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cernelSize = ((CernelSizeSelectionItem)SelectCernelSize.SelectedItem).CernelSize;
            CvInvoke.Blur(Input.Image, Mat, new Size(cernelSize, cernelSize), new Point(-1, -1));
            Result.Image = Mat.Clone();
        }

        private void Result_NameChanged(object sender, NewNameEvent e)
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

    }
}
