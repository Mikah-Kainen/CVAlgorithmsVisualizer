using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CVBitWiseOperations.Controls
{
    public partial class SliderControl : BaseUserControl, ICanReturnInt
    {
        public bool CanChangeMax = true;
        public bool CanChangeMin = true;

        public event EventHandler<int> IntReturned;

        public int Max
        {
            get { return Slider.Maximum; }
            set { MaxVal.Text = $"{value}"; ValText.Maximum = value; Slider.Maximum = value; }
        }
        public int Min {
            get { return Slider.Minimum; }
            set { MinVal.Text = $"{value}"; ValText.Minimum = value; Slider.Minimum = value; }
        }

        public int Value {
            get { return Slider.Value; }
            set { ValText.Value = value; Slider.Value = value; }
        }
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
            MaxVal.Text = $"{Slider.Maximum}";
            MinVal.Text = $"{Slider.Minimum}";
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
                IntReturned?.Invoke(this, (int)ValText.Value);
            }
        }


        private void MaxVal_TextChanged(object sender, EventArgs e)
        {
            if (CanChangeMax)
            {
                int parsed;
                if (int.TryParse(MaxVal.Text, out parsed))
                {
                    Slider.Maximum = parsed;
                }
            }
            else
            {
                MaxVal.Text = $"{Slider.Maximum}";
            }
        }
        private void MinVal_TextChanged(object sender, EventArgs e)
        {
            if (CanChangeMin)
            {
                int parsed;
                if (int.TryParse(MinVal.Text, out parsed))
                {
                    Slider.Minimum = parsed;
                }
            }
            else
            {
                MinVal.Text = $"{Slider.Minimum}";
            }
        }

        
    }
}
