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
        public static readonly Dictionary<string, OutputControl> SavedOutputs = new Dictionary<string, OutputControl>();
        public static readonly List<BaseUserControl> AllControls = new List<BaseUserControl>();

        public InputControl[] Inputs { get; set; }
        public OutputControl[] Outputs { get; set; }

        public virtual Mat Image { get; }

        public BaseUserControl()
        {
            InitializeComponent();
        }

        private void BaseUserControl_Load(object sender, EventArgs e)
        {

            Outputs = Controls.OfType<OutputControl>().ToArray();
            foreach (OutputControl output in Outputs)
            {
                output.ImageUpdated += UpdateForImage;
                output.NameUpdated += UpdateForName;
            }

            Inputs = Controls.OfType<InputControl>().ToArray();
            foreach (InputControl input in Inputs)
            {
                input.ImageReturned += RunIfReady;
            }

            foreach (KeyValuePair<string, OutputControl> kvp in SavedOutputs)
            {
                for (int i = 0; i < Inputs.Length; i++)
                {
                    Inputs[i].AddInput(kvp.Key);
                }
            }

            AllControls.Add(this);
        }

        public virtual void RunIfReady(object sender, NewImageEvent e)
        {
        }

        private void UpdateForImage(object sender, UpdateImageEvent e)
        {
            UpdateImage(((OutputControl)sender).ImageName, (OutputControl)sender);
        }

        private void UpdateForName(object sender, UpdateNameEvent e)
        {
            UpdateName(((OutputControl)sender), e.OldName, e.NewName);
        }

        public void UpdateName(OutputControl output, string oldName, string newName)
        {
            if (oldName == newName)
            {
                return;
            }
            if (SavedOutputs.ContainsKey(newName))
            {
                return;
            }

            if (oldName != null && SavedOutputs.ContainsKey(oldName))
            {
                SavedOutputs.Add(newName, output);
                for (int z = 0; z < AllControls.Count; z++)
                {
                    for (int i = 0; i < AllControls[z].Inputs.Length; i++)
                    {
                        AllControls[z].Inputs[i].AddInput(newName);
                        if (AllControls[z].Inputs[i].SelectedItem == oldName)
                        {
                            AllControls[z].Inputs[i].SetInput(newName);
                        }
                        AllControls[z].Inputs[i].RemoveInput(oldName);
                    }
                }
                SavedOutputs.Remove(oldName);
            }
            else
            {
                SavedOutputs.Add(newName, output);
                for (int z = 0; z < AllControls.Count; z++)
                {
                    for (int i = 0; i < AllControls[z].Inputs.Length; i++)
                    {
                        AllControls[z].Inputs[i].AddInput(newName);
                    }
                }
            }
        }

        public void UpdateImage(string targetName, OutputControl sender)
        {
            if (!SavedOutputs.ContainsKey(targetName))
            {
                SavedOutputs.Add(targetName, sender);
            }
            for (int z = 0; z < AllControls.Count; z++)
            {
                for (int i = 0; i < AllControls[z].Inputs.Length; i++)
                {
                    if (AllControls[z].Inputs[i].SelectedItem == targetName)
                    {
                        AllControls[z].Inputs[i].SetImage(sender.Image, true);
                    }
                }
            }
        }
    }
}
