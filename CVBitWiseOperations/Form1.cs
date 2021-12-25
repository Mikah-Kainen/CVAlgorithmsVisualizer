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
            Type[] allTypes = GetType().Assembly.GetTypes();
            for(int i = 0; i < allTypes.Length; i++)
            {
                if(allTypes[i].IsSubclassOf(typeof(BaseUserControl)))
                {
                    int ii = i;
                    SelectControl.Items.Add(new SelectControlItem(allTypes[ii].Name, () => (BaseUserControl)Activator.CreateInstance(allTypes[ii])));
                }
            }
        }

        private void AddPanel_Click(object sender, EventArgs e)
        {
            MyTabs.SelectedTab.Controls.OfType<TableLayoutPanel>().ToArray()[0].Controls.Add(new BitwiseOperationControl());
        }

        private void AddColorDisplay_Click(object sender, EventArgs e)
        {
            MyTabs.SelectedTab.Controls.OfType<TableLayoutPanel>().ToArray()[0].Controls.Add(new ColorDisplay());
        }

        private void SelectControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (ComboBox)sender;
            SelectControlItem selectedItem = (SelectControlItem)selected.SelectedItem;
            MyTabs.SelectedTab.Controls.OfType<FlowLayoutPanel>().ToArray()[0].Controls.Add(selectedItem.GetControl());
        }

        private void AddTab_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            FlowLayoutPanel newPanel = new FlowLayoutPanel();
            newPanel.Dock = DockStyle.Fill;
            newPanel.AutoScroll = true;
            newPanel.AutoSize = false;
            newTab.Controls.Add(newPanel);
            MyTabs.TabPages.Add(newTab);
        }

        private void TabNameText_TextChanged(object sender, EventArgs e)
        {
            Size sizeOfText = TextRenderer.MeasureText(TabNameText.Text, Font);

            TabNameText.Size = new Size(Math.Min(Math.Max(sizeOfText.Width, 60), 100), TabNameText.Height);
        }

        private void RenameTab_Click_1(object sender, EventArgs e)
        {
            string newName = TabNameText.Text;
            TabNameText.Text = "TabNameText";
            MyTabs.SelectedTab.Text = newName;
        }
    }
}
