using CVBitWiseOperations.Controls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVBitWiseOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    tableLayoutPanel1.Controls.Add(new Button());
        //}

        private void AddPanel_Click(object sender, EventArgs e)
        {
            ControlContainer.Controls.Add(new BitwiseOperationControl());
        }

        private void AddColorDisplay_Click(object sender, EventArgs e)
        {
            ColorDisplayContainer.Controls.Add(new ColorDisplayControl());
        }
    }
}
