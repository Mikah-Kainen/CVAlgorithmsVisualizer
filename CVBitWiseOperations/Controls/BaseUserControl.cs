using Emgu.CV;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;

namespace CVBitWiseOperations.Controls
{
    public partial class BaseUserControl : UserControl
    {
        public static readonly Dictionary<string, Mat> SavedImages = new Dictionary<string, Mat>();
        public static readonly List<BaseUserControl> AllControls = new List<BaseUserControl>();

        public static InputControl[] Inputs { get; set; }

        public BaseUserControl()
        {
            InitializeComponent();
        }

        private void BaseUserControl_Load(object sender, EventArgs e)
        {
            AllControls.Add(this);
            Inputs = Controls.OfType<InputControl>().ToArray();
            foreach(KeyValuePair<string, Mat> kvp in SavedImages)
            {
                for(int i = 0; i < Inputs.Length; i ++)
                {
                    Inputs[i].AddInput(kvp.Key);
                }
            }
        }

        public void UpdateName(Mat targetMat, string oldName, string newName)
        {
            if (oldName == newName) { return; }
            if (SavedImages.ContainsKey(newName)) { return; }

            if (oldName != null)
            {
                SavedImages.Remove(oldName);
            }
            SavedImages.Add(newName, targetMat);
            for (int i = 0; i < Inputs.Length; i++)
            {
                Inputs[i].RemoveInput(oldName);
                Inputs[i].AddInput(newName);
            }

        }
    }
}
