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
            MaxValueSlider.SpecifyValueUse("MaxValue:");
        }
    }
}
