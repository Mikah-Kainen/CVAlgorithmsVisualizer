using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Util;

using System;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private Action<Mat, VectorOfVectorOfPoint> operation;

        public GetContours()
        {
            InitializeComponent();
        }

        private int width;

        private void GetContours_Load(object sender, EventArgs e)
        {
            operation = (bla, blab) => { };

            ColorPicker.BackColor = Color.Red;
            WidthValue.Value = 3;
            width = 3;
            WidthValue.Minimum = 0;
            WidthValue.Maximum = 5000;

            SelectOperation.Items.Add(new SelectOperationItem("Outline", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                CvInvoke.DrawContours(input, contours, -1, ColorPicker.BackColor.ToMCvScalar(), width);
            }));

            SelectOperation.Items.Add(new SelectOperationItem("BoundingRectangle", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                int length = contours.Size;
                for (int i = 0; i < length; i++)
                {
                    Rectangle boundingRect = CvInvoke.BoundingRectangle(contours[i]);
                    Rectangle nicerRect = new Rectangle(boundingRect.X - 5, boundingRect.Y - 5, boundingRect.Width + 10, boundingRect.Height + 10) ;
                    CvInvoke.Rectangle(input, nicerRect, ColorPicker.BackColor.ToMCvScalar(), width);
                }
            }));

            SelectOperation.Items.Add(new SelectOperationItem("ClosestRectangle", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                int length = contours.Size;
                for (int i = 0; i < length; i++)
                {
                    RotatedRect closestRect = CvInvoke.MinAreaRect(contours[i]);
                    MCvScalar currentColor = ColorPicker.BackColor.ToMCvScalar();
                    Point[] vertices = closestRect.GetVertices().Select((PointF pf) => new Point((int)pf.X, (int)pf.Y)).ToArray();
                    for (int z = 0; z < vertices.Length; z++)
                    {
                        int next = z + 1;
                        if (next >= vertices.Length)
                        {
                            next = 0;
                        }
                        CvInvoke.Line(input, vertices[z], vertices[next], currentColor, width);
                    }
                }
            }));

            SelectOperation.Items.Add(new SelectOperationItem("BoundingCircle", (Mat input, VectorOfVectorOfPoint contours) =>
            {
                int length = contours.Size;
                for (int i = 0; i < length; i++)
                {
                    CircleF currentCircle = CvInvoke.MinEnclosingCircle(contours[i]);
                    CvInvoke.Circle(input, currentCircle.Center.ToPoint(), (int)currentCircle.Radius, ColorPicker.BackColor.ToMCvScalar(), width);
                }
            }));
        }




        private void ColorPicker_Click(object sender, EventArgs e)
        {
            var dialog = ColorDialog.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                ColorPicker.BackColor = ColorDialog.Color;
            }
            Draw();
        }

        private void WidthValue_ValueChanged(object sender, EventArgs e)
        {
            width = (int)WidthValue.Value;
            Draw();
        }


        private void SelectOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation = ((SelectOperationItem)SelectOperation.SelectedItem).Operation;
            Draw();
        }

        private Mat tempInput = new Mat();
        private Mat tempContours = new Mat();
        private void Draw()
        {
            if (Input.Image != null && ContourInput.Image != null)
            {
                tempInput = Input.Image.Clone();
                tempContours = ContourInput.Image.Clone();
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                if (tempContours.NumberOfChannels > 1)
                {
                    CvInvoke.CvtColor(tempContours.Clone(), tempContours, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                }
                CvInvoke.FindContours(tempContours, contours, new Mat(), Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxNone);
                if (tempInput.NumberOfChannels == 1)
                {
                    CvInvoke.CvtColor(tempInput.Clone(), tempInput, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);
                }

                operation(tempInput, contours);
                Result.SetImage(tempInput, true);
            }
        }
    }
}
