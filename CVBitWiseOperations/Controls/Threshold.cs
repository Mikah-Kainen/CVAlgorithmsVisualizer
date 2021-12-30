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

        private void Input_Load(object sender, EventArgs e)
        {

        }
    }
}
