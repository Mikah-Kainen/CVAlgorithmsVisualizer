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
        public struct SelectControlItem
        {
            public string Name { get; set; }
            public Func<UserControl> GetControl { get; set; }
            public SelectControlItem(string name, Func<UserControl> getControl)
            {
                Name = name;
                GetControl = getControl;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectControl.Items.Add(new SelectControlItem("BitwiseOperations", () => new BitwiseOperationControl()));
            SelectControl.Items.Add(new SelectControlItem("ColorDisplay", () => new ColorDisplay()));
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
            ControlContainer.Controls.Add(new ColorDisplay());
        }

        private void SelectControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (ComboBox)sender;
            SelectControlItem selectedItem = (SelectControlItem)selected.SelectedItem;
            ControlContainer.Controls.Add(selectedItem.GetControl());
        }
    }
}
