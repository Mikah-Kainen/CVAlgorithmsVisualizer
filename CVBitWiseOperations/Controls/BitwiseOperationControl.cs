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
    public partial class BitwiseOperationControl : UserControl
    {
        public struct Operation
        {
            public string Name { get; set; }
            
            public delegate void CvFunction(IInputArray a, IInputArray b, IOutputArray c);
            public CvFunction MatOperation { get; set; }


            public Operation(string name, CvFunction matOperation)
            {
                Name = name;
                MatOperation = matOperation;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public Mat ResultMat { get; set; }

        public BitwiseOperationControl()
        {
            ResultMat = new Mat();
            InitializeComponent();
        }

        private void SelectOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = ((ComboBox)sender).SelectedItem;

            using Mat leftBox = LeftInputImage.Mat.Clone();
            using Mat rightBox = RightInputImage.Mat.Clone();

            ((Operation)selected).MatOperation(leftBox, rightBox, ResultMat);
            ResultImage.Image = ResultMat;
        }

        private void BitwiseOperationControl_Load(object sender, EventArgs e)
        {
            SelectOperation.Items.Add(new Operation("OR", (a, b, c) => CvInvoke.BitwiseOr(a, b, c)));
            SelectOperation.Items.Add(new Operation("AND", (a, b, c) => CvInvoke.BitwiseAnd(a, b, c)));
            SelectOperation.Items.Add(new Operation("Not", (a, b, c) => CvInvoke.BitwiseNot(b, c)));
            SelectOperation.Items.Add(new Operation("Xor", (a, b, c) => CvInvoke.BitwiseXor(a, b, c)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
