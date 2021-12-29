using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CVBitWiseOperations.Controls
{
    public partial class GetContours : BaseUserControl
    {
        public struct SelectOperationItem
        {
            public string Name { get; set; }
            public Action<Mat, VectorOfVectorOfPoint> Operation { get; set; }

            public SelectOperationItem(string name, Action<Mat, VectorOfVectorOfPoint> operation)
            {
                Name = name;
                Operation = operation;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public GetContours()
        {
            InitializeComponent();
        }

        private int width;

        private void GetContours_Load(object sender, EventArgs e)
        {
            ColorPicker.BackColor = Color.Red;
            WidthValue.Value = 3;
            width = 3;
            WidthValue.Minimum = 0;
            WidthValue.Maximum = 5000;

            SelectOperation.Items.Add(new SelectOperationItem("Outline", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                CvInvoke.DrawContours(input, contours, -1, ColorPicker.BackColor.ToMCvScalar(), width);
                Result.Image = input.Clone();
            }));

            SelectOperation.Items.Add(new SelectOperationItem("BoundingRectangle", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                int length = contours.Size;
                for (int i = 0; i < length; i++)
                {
                    Rectangle boundingRect = CvInvoke.BoundingRectangle(contours[i]);
                    CvInvoke.Rectangle(input, boundingRect, ColorPicker.BackColor.ToMCvScalar(), width);
                }
                Result.Image = input.Clone();
            }));

            SelectOperation.Items.Add(new SelectOperationItem("ClosestRectangle", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                int length = contours.Size;
                for (int i = 0; i < length; i++)
                {
                    RotatedRect closestRect = CvInvoke.MinAreaRect(contours[i]);
                    MCvScalar currentColor = ColorPicker.BackColor.ToMCvScalar();
                    Point[] vertices = closestRect.GetVertices().Select((PointF pf) => new Point((int)pf.X, (int)pf.Y)).ToArray();
                    for (int z = 0; z < vertices.Length; z ++)
                    {
                        int next = z + 1;
                        if(next >= vertices.Length)
                        {
                            next = 0;
                        }
                        CvInvoke.Line(input, vertices[z], vertices[next], currentColor, width);
                    }
                }
                Result.Image = input.Clone();
            }));

            SelectOperation.Items.Add(new SelectOperationItem("BoundingCircle", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                int length = contours.Size;
                for (int i = 0; i < length; i++)
                {
                    CircleF currentCircle = CvInvoke.MinEnclosingCircle(contours[i]);
                    CvInvoke.Circle(input, currentCircle.Center.ToPoint(), (int)currentCircle.Radius, ColorPicker.BackColor.ToMCvScalar(), width);
                }
                Result.Image = input.Clone();
            }));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ColorSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ColorPicker_Click(object sender, EventArgs e)
        {
            var dialog = ColorDialog.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                ColorPicker.BackColor = ColorDialog.Color;
            }
        }

        private void WidthValue_ValueChanged(object sender, EventArgs e)
        {
            width = (int)WidthValue.Value;
        }

        private Mat temp;

        private void SelectOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = Input.Image.Clone();
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(temp, contours, new Mat(), Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);
            CvInvoke.CvtColor(temp, temp, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);

            ((SelectOperationItem)SelectOperation.SelectedItem).Operation(temp, contours);
        }
    }
}
