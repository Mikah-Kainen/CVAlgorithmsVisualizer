using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CVBitWiseOperations.Controls
{
    public partial class SliderControl : BaseUserControl
    {
        public SliderControl()
        {
            InitializeComponent();
        }

        public void SpecifyValueUse(string use) //replaces the "Val:" label with a "use" label
        {
            Size sizeOfText = TextRenderer.MeasureText(use, Font);
            ValueLabel.Text = use;
            ValueLabel.Size = new Size(Math.Min(Math.Max(sizeOfText.Width, 40), 100), ValueLabel.Height);
        }

        private void SliderControl_Load(object sender, EventArgs e)
        {
            MinVal.Text = $"{Slider.Minimum}";
            MaxVal.Text = $"{Slider.Maximum}";
        }

        private void Slider_Scroll(object sender, EventArgs e)
        {
            if ((int)ValText.Value >= Slider.Minimum && (int)ValText.Value <= Slider.Maximum)
            {
                ValText.Value = Slider.Value;
            }
        }

        private void ValText_ValueChanged(object sender, EventArgs e)
        {
            if ((int)ValText.Value >= Slider.Minimum && (int)ValText.Value <= Slider.Maximum)
            {
                Slider.Value = (int)ValText.Value;
            }
        }

        private void MinVal_TextChanged(object sender, EventArgs e)
        {
            int parsed;
            if (int.TryParse(MinVal.Text, out parsed))
            {
                Slider.Minimum = parsed;
            }
        }

        private void MaxVal_TextChanged(object sender, EventArgs e)
        {
            int parsed;
            if (int.TryParse(MaxVal.Text, out parsed))
            {
                Slider.Maximum = parsed;
            }
        }

        
    }
}
