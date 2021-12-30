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
    public partial class BitwiseOperationControl : BaseUserControl
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

            using Mat leftBox = LeftInputImage.Image.Clone();
            using Mat rightBox = RightInputImage.Image.Clone();

            ((Operation)selected).MatOperation(leftBox, rightBox, ResultMat);
            Result.SetImage(ResultMat, true);
        }

        private void BitwiseOperationControl_Load(object sender, EventArgs e)
        {
            Result.NameChanged += Result_NameChanged;

            SelectOperation.Items.Add(new Operation("OR", (a, b, c) => CvInvoke.BitwiseOr(a, b, c)));
            SelectOperation.Items.Add(new Operation("AND", (a, b, c) => CvInvoke.BitwiseAnd(a, b, c)));
            SelectOperation.Items.Add(new Operation("Not", (a, b, c) => CvInvoke.BitwiseNot(b, c)));
            SelectOperation.Items.Add(new Operation("Xor", (a, b, c) => CvInvoke.BitwiseXor(a, b, c)));
            SelectOperation.Items.Add(new Operation("AbsDiff", (a, b, c) => CvInvoke.AbsDiff(a, b, c)));
        }

        private void Result_NameChanged(object sender, NewNameEvent e)
        {
            UpdateName(((ICanChangeName)sender).Image, e.OldName, e.NewName);
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

        private void RightInputImage_Load(object sender, EventArgs e)
        {

        }

        private void LeftInputImage_Load(object sender, EventArgs e)
        {

        }
    }
}
