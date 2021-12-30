
namespace CVBitWiseOperations.Controls
{
    partial class Threshold
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaxValueSlider = new CVBitWiseOperations.Controls.SliderControl();
            this.ThresholdSlider = new CVBitWiseOperations.Controls.SliderControl();
            this.Input = new CVBitWiseOperations.Controls.InputControl();
            this.Result = new CVBitWiseOperations.Controls.OutputControl();
            this.SuspendLayout();
            // 
            // MaxValueSlider
            // 
            this.MaxValueSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxValueSlider.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.MaxValueSlider.Location = new System.Drawing.Point(445, 291);
            this.MaxValueSlider.Margin = new System.Windows.Forms.Padding(74, 102, 74, 102);
            this.MaxValueSlider.Name = "MaxValueSlider";
            this.MaxValueSlider.Size = new System.Drawing.Size(805, 261);
            this.MaxValueSlider.TabIndex = 2;
            // 
            // ThresholdSlider
            // 
            this.ThresholdSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThresholdSlider.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.ThresholdSlider.Location = new System.Drawing.Point(445, 7);
            this.ThresholdSlider.Margin = new System.Windows.Forms.Padding(74, 102, 74, 102);
            this.ThresholdSlider.Name = "ThresholdSlider";
            this.ThresholdSlider.Size = new System.Drawing.Size(805, 261);
            this.ThresholdSlider.TabIndex = 3;
            // 
            // Input
            // 
            this.Input.Image = null;
            this.Input.Location = new System.Drawing.Point(14, 7);
            this.Input.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(423, 531);
            this.Input.TabIndex = 4;
            this.Input.Load += new System.EventHandler(this.Input_Load);
            // 
            // Result
            // 
            this.Result.Image = null;
            this.Result.Location = new System.Drawing.Point(1256, 7);
            this.Result.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(429, 538);
            this.Result.TabIndex = 7;
            // 
            // Threshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.ThresholdSlider);
            this.Controls.Add(this.MaxValueSlider);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.Name = "Threshold";
            this.Size = new System.Drawing.Size(1706, 570);
            this.Load += new System.EventHandler(this.Threshold_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SliderControl MaxValueSlider;
        private SliderControl ThresholdSlider;
        private InputControl Input;
        private OutputControl Result;
    }
}
