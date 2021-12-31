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
    public partial class BaseUserControl : UserControl, ICanUpdateImage, ICanUpdateName
    {
        public static readonly Dictionary<string, Mat> SavedImages = new Dictionary<string, Mat>();
        public static readonly List<BaseUserControl> AllControls = new List<BaseUserControl>();

        public event EventHandler<UpdateImageEvent> ImageUpdate;
        public event EventHandler<UpdateNameEvent> NameUpdated;

        public InputControl[] Inputs { get; set; }

        public virtual Mat Image { get; }

        public BaseUserControl()
        {
            InitializeComponent();
        }

        private void BaseUserControl_Load(object sender, EventArgs e)
        {
            this.ImageUpdate += UpdateForImage;
            this.NameUpdated += UpdateForName;


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

        private void UpdateForImage(object sender, UpdateImageEvent e)
        {
            UpdateImage(((ICanUpdateImage)sender).Name, e.OldImage, e.NewImage);
        }

        private void UpdateForName(object sender, UpdateNameEvent e)
        {
            UpdateName(((ICanUpdateName)sender).Image, e.OldName, e.NewName);
        }

        public void UpdateName(Mat targetMat, string oldName, string newName)
        {
            if (oldName == newName) { 
                return; }
            if (SavedImages.ContainsKey(newName)) { 
                return; }

            if (oldName != null && SavedImages.ContainsKey(oldName))
            {
                for (int z = 0; z < AllControls.Count; z++)
                {
                    for (int i = 0; i < AllControls[z].Inputs.Length; i++)
                    {
                        if(AllControls[z].Inputs[i].SelectedItem == oldName)
                        {
                            AllControls[z].Inputs[i].SetInput(newName);
                        }
                        AllControls[z].Inputs[i].RemoveInput(oldName);
                        AllControls[z].Inputs[i].AddInput(newName);
                    }
                }
                SavedImages.Remove(oldName);
                SavedImages.Add(newName, targetMat);
            }
            else
            {
                SavedImages.Add(newName, targetMat);
                for (int z = 0; z < AllControls.Count; z++)
                {
                    for (int i = 0; i < AllControls[z].Inputs.Length; i++)
                    {
                        AllControls[z].Inputs[i].AddInput(newName);
                    }
                }
            }
        }

        public void UpdateImage(string targetName, Mat oldImage, Mat newImage)
        {
            if (oldImage == newImage) { 
                return; }

            if (oldImage != null && SavedImages.ContainsValue(oldImage) && SavedImages[targetName] == oldImage)
            {
                for (int z = 0; z < AllControls.Count; z++)
                {
                    for (int i = 0; i < AllControls[z].Inputs.Length; i++)
                    {
                        if(AllControls[z].Inputs[i].SelectedItem == targetName)
                        {
                            AllControls[z].Inputs[i].SetImage(newImage, false);
                        }
                    }
                }
                SavedImages.Remove(targetName);
                SavedImages.Add(targetName, newImage);
            }
            else
            {
                SavedImages.Add(targetName, newImage);
                for (int z = 0; z < AllControls.Count; z++)
                {
                    for (int i = 0; i < AllControls[z].Inputs.Length; i++)
                    {
                        if (AllControls[z].Inputs[i].SelectedItem == targetName)
                        {
                            AllControls[z].Inputs[i].SetImage(newImage, false);
                        }
                    }
                }
            }
        }
    }
}
