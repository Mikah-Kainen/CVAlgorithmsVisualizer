
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
            this.SuspendLayout();
            // 
            // MaxValueSlider
            // 
            this.MaxValueSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxValueSlider.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.MaxValueSlider.Location = new System.Drawing.Point(3, 92);
            this.MaxValueSlider.Name = "MaxValueSlider";
            this.MaxValueSlider.Size = new System.Drawing.Size(283, 83);
            this.MaxValueSlider.TabIndex = 2;
            // 
            // ThresholdSlider
            // 
            this.ThresholdSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThresholdSlider.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.ThresholdSlider.Location = new System.Drawing.Point(3, 3);
            this.ThresholdSlider.Name = "ThresholdSlider";
            this.ThresholdSlider.Size = new System.Drawing.Size(283, 83);
            this.ThresholdSlider.TabIndex = 3;
            // 
            // Threshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThresholdSlider);
            this.Controls.Add(this.MaxValueSlider);
            this.Name = "Threshold";
            this.Size = new System.Drawing.Size(289, 178);
            this.Load += new System.EventHandler(this.Threshold_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SliderControl MaxValueSlider;
        private SliderControl ThresholdSlider;
    }
}
