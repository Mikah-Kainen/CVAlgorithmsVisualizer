
namespace CVBitWiseOperations.Controls
{
    partial class BlurControl
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
            this.Input = new CVBitWiseOperations.Controls.InputControl();
            this.Result = new CVBitWiseOperations.Controls.OutputControl();
            this.label1 = new System.Windows.Forms.Label();
            this.CernelValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectBlur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CernelValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 3);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(169, 177);
            this.Input.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(257, 0);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(159, 180);
            this.Result.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cernel Size";
            // 
            // CernelValue
            // 
            this.CernelValue.Location = new System.Drawing.Point(178, 119);
            this.CernelValue.Name = "CernelValue";
            this.CernelValue.Size = new System.Drawing.Size(61, 23);
            this.CernelValue.TabIndex = 4;
            this.CernelValue.ValueChanged += new System.EventHandler(this.CernelValue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Blur Type";
            // 
            // SelectBlur
            // 
            this.SelectBlur.FormattingEnabled = true;
            this.SelectBlur.Location = new System.Drawing.Point(167, 60);
            this.SelectBlur.Name = "SelectBlur";
            this.SelectBlur.Size = new System.Drawing.Size(84, 23);
            this.SelectBlur.TabIndex = 6;
            this.SelectBlur.SelectedIndexChanged += new System.EventHandler(this.SelectBlur_SelectedIndexChanged);
            // 
            // BlurControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SelectBlur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CernelValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Name = "BlurControl";
            this.Size = new System.Drawing.Size(414, 180);
            this.Load += new System.EventHandler(this.BlurControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CernelValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputControl Input;
        private OutputControl Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CernelValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectBlur;
    }
}
