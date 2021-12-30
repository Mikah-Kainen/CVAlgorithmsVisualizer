using CVBitWiseOperations.Controls;

using Emgu.CV;

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

        Bitmap loaded;
        private void BreakImage_Click(object sender, EventArgs e)
        {
            OutputControl output1 = new OutputControl();
            OutputControl output2 = new OutputControl();

            FileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                loaded = CvInvoke.Imread(dialog.FileName).ToBitmap();
            }

            Rectangle rectangle1 = new Rectangle(4, 4, 367, 245); 
            Bitmap image1 = new Bitmap(rectangle1.Width, rectangle1.Height);
            Rectangle rectangle2 = new Rectangle(4, 252, 367, 245);
            Bitmap image2 = new Bitmap(rectangle2.Width, rectangle2.Height);

            for (int y = 0; y < rectangle1.Height; y ++)
            {
                for(int x = 0; x < rectangle1.Width; x ++)
                {
                    image1.SetPixel(x, y, loaded.GetPixel(x + rectangle1.X, y + rectangle1.Y));
                }
            }

            for (int y = 0; y < rectangle2.Height; y++)
            {
                for (int x = 0; x < rectangle2.Width; x++)
                {
                    image2.SetPixel(x, y, loaded.GetPixel(x + rectangle2.X, y + rectangle2.Y));
                }
            }

            output1.SetImage(image1.ToMat(), false);
            output2.SetImage(image2.ToMat(), false);
            //maybe I do need to clone

            MyTabs.SelectedTab.Controls.OfType<FlowLayoutPanel>().ToArray()[0].Controls.Add(output1);
            MyTabs.SelectedTab.Controls.OfType<FlowLayoutPanel>().ToArray()[0].Controls.Add(output2);
        }
    }
}
