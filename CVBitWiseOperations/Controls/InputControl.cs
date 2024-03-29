﻿using Emgu.CV;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CVBitWiseOperations.Controls
{
    public partial class InputControl : UserControl, ICanReturnImage
    {



        public Mat Image
        {
            get
            {
                return (Mat)SelectedImage.Image;
            }
        }

        public void SetImage(Mat image, bool shouldClone)
        {
            if(shouldClone)
            {
                SelectedImage.Image = image.Clone();
            }
            else
            {
                SelectedImage.Image = image;
            }
        }

        public InputControl()
        {
            InitializeComponent();
        }

        public event EventHandler<NewImageEvent> ImageReturned;

        public void RemoveInput(string input)
        {
            SelectImage.Items.Remove(input);
        }
        public void AddInput(string input)
        {
            SelectImage.Items.Add(input);
        }

        public void SetInput(string input)
        {
            if (SelectImage.Items.Contains(input))
            {
                SelectImage.SelectedItem = input;
            }
        }

        public string SelectedItem => SelectImage.SelectedItem?.ToString();

        private void SelectionControl_Load(object sender, EventArgs e)
        {

        }

        private void SelectImage_SelectedIndexChanged(object sender, EventArgs e)
        {
            using Mat oldImage = Image?.Clone();

            SetImage(BaseUserControl.SavedOutputs[(string)SelectImage.SelectedItem].Image, true);
            if (oldImage != null)
            {
                ImageReturned?.Invoke(this, new NewImageEvent(oldImage, Image));
            }
            else
            {
                ImageReturned?.Invoke(this, new NewImageEvent(null, Image));
            }

        }

        private void Image_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                SetImage(CvInvoke.Imread(dialog.FileName), true);
            }
            ImageReturned?.Invoke(this, new NewImageEvent(null, Image));
        }
    }
}
