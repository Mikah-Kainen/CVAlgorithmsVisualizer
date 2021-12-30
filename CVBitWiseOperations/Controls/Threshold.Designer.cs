
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
            this.SelectThresholdType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaxValueSlider
            // 
            this.MaxValueSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxValueSlider.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.MaxValueSlider.Location = new System.Drawing.Point(170, 121);
            this.MaxValueSlider.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.MaxValueSlider.Max = 100;
            this.MaxValueSlider.Min = 0;
            this.MaxValueSlider.Name = "MaxValueSlider";
            this.MaxValueSlider.Size = new System.Drawing.Size(283, 83);
            this.MaxValueSlider.TabIndex = 2;
            this.MaxValueSlider.Value = 0;
            // 
            // ThresholdSlider
            // 
            this.ThresholdSlider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThresholdSlider.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.ThresholdSlider.Location = new System.Drawing.Point(170, 32);
            this.ThresholdSlider.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.ThresholdSlider.Max = 100;
            this.ThresholdSlider.Min = 0;
            this.ThresholdSlider.Name = "ThresholdSlider";
            this.ThresholdSlider.Size = new System.Drawing.Size(283, 83);
            this.ThresholdSlider.TabIndex = 3;
            this.ThresholdSlider.Value = 0;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(0, 10);
            this.Input.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(165, 179);
            this.Input.TabIndex = 4;
            this.Input.Load += new System.EventHandler(this.Input_Load);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(457, 10);
            this.Result.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(159, 179);
            this.Result.TabIndex = 7;
            // 
            // SelectThresholdType
            // 
            this.SelectThresholdType.FormattingEnabled = true;
            this.SelectThresholdType.Location = new System.Drawing.Point(302, 3);
            this.SelectThresholdType.Name = "SelectThresholdType";
            this.SelectThresholdType.Size = new System.Drawing.Size(121, 23);
            this.SelectThresholdType.TabIndex = 8;
            this.SelectThresholdType.SelectedIndexChanged += new System.EventHandler(this.SelectThresholdType_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Threshold Type:";
            // 
            // Threshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectThresholdType);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.ThresholdSlider);
            this.Controls.Add(this.MaxValueSlider);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "Threshold";
            this.Size = new System.Drawing.Size(616, 207);
            this.Load += new System.EventHandler(this.Threshold_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SliderControl MaxValueSlider;
        private SliderControl ThresholdSlider;
        private InputControl Input;
        private OutputControl Result;
        private System.Windows.Forms.ComboBox SelectThresholdType;
        private System.Windows.Forms.Label label1;
    }
}
