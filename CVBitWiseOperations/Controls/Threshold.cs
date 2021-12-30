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
    public partial class Threshold : BaseUserControl
    {
        public struct SelectThresholdTypeItem
        {
            public string Name { get; set; }
            public Action Operation { get; set; }

            public SelectThresholdTypeItem(string name, Action operation)
            {
                Name = name;
                Operation = operation;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private Action operation;
        public Threshold()
        {
            InitializeComponent();
        }

        private void Threshold_Load(object sender, EventArgs e)
        {
            ThresholdSlider.SpecifyValueUse("Threshold:");
            ThresholdSlider.Max = 255;
            ThresholdSlider.Min = 0;
            ThresholdSlider.CanChangeMax = false;
            ThresholdSlider.CanChangeMin = false;
            ThresholdSlider.Value = 255;

            MaxValueSlider.SpecifyValueUse("MaxValue:");
            MaxValueSlider.Max = 255;
            MaxValueSlider.Min = 0;
            MaxValueSlider.CanChangeMax = false;
            MaxValueSlider.CanChangeMin = false;
            MaxValueSlider.Value = 255;
        }

        private Mat temp;
        private void Input_Load(object sender, EventArgs e)
        {
            operation = () => { };
            ThresholdSlider.IntReturned += ThresholdSlider_IntReturned;
            MaxValueSlider.IntReturned += MaxValueSlider_IntReturned;


            string[] names = Enum.GetNames(typeof(Emgu.CV.CvEnum.ThresholdType));
            Emgu.CV.CvEnum.ThresholdType[] types = (Emgu.CV.CvEnum.ThresholdType[])Enum.GetValues(typeof(Emgu.CV.CvEnum.ThresholdType));
            temp = new Mat();
            for (int i = 0; i < types.Length; i ++)
            {
                int ii = i;
                SelectThresholdType.Items.Add(new SelectThresholdTypeItem(names[ii], () =>
                {
                    CvInvoke.Threshold(Input.Image.Clone(), temp, ThresholdSlider.Value, MaxValueSlider.Value, types[ii]);
                    Result.SetImage(temp, true);
                    }));
            }
        }

        private void ThresholdSlider_IntReturned(object sender, int e)
        {
            operation();
        }

        private void MaxValueSlider_IntReturned(object sender, int e)
        {
            operation();
        }


        private void SelectThresholdType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            operation = ((SelectThresholdTypeItem)SelectThresholdType.SelectedItem).Operation;
            operation();
        }
    }
}
