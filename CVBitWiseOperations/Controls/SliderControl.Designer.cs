
namespace CVBitWiseOperations.Controls
{
    partial class SliderControl
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
            this.Slider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ValText = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinVal = new System.Windows.Forms.TextBox();
            this.MaxVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValText)).BeginInit();
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.Location = new System.Drawing.Point(3, 33);
            this.Slider.Maximum = 100;
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(272, 45);
            this.Slider.TabIndex = 0;
            this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Val:";
            // 
            // ValText
            // 
            this.ValText.Location = new System.Drawing.Point(34, 7);
            this.ValText.Name = "ValText";
            this.ValText.Size = new System.Drawing.Size(50, 23);
            this.ValText.TabIndex = 2;
            this.ValText.ValueChanged += new System.EventHandler(this.ValText_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max";
            // 
            // MinVal
            // 
            this.MinVal.Location = new System.Drawing.Point(171, 4);
            this.MinVal.Name = "MinVal";
            this.MinVal.Size = new System.Drawing.Size(37, 23);
            this.MinVal.TabIndex = 5;
            this.MinVal.TextChanged += new System.EventHandler(this.MinVal_TextChanged);
            // 
            // MaxVal
            // 
            this.MaxVal.Location = new System.Drawing.Point(243, 4);
            this.MaxVal.Name = "MaxVal";
            this.MaxVal.Size = new System.Drawing.Size(37, 23);
            this.MaxVal.TabIndex = 6;
            this.MaxVal.TextChanged += new System.EventHandler(this.MaxVal_TextChanged);
            // 
            // SliderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.MaxVal);
            this.Controls.Add(this.MinVal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Slider);
            this.Name = "SliderControl";
            this.Size = new System.Drawing.Size(283, 83);
            this.Load += new System.EventHandler(this.SliderControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Slider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ValText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinVal;
        private System.Windows.Forms.TextBox MaxVal;
    }
}
