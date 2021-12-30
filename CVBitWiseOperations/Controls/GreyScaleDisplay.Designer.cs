
namespace CVBitWiseOperations.Controls
{
    partial class GreyScaleDisplay
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
            this.ROutput = new CVBitWiseOperations.Controls.OutputControl();
            this.GOutput = new CVBitWiseOperations.Controls.OutputControl();
            this.BOutput = new CVBitWiseOperations.Controls.OutputControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(3, 18);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(162, 184);
            this.Input.TabIndex = 0;
            this.Input.Load += new System.EventHandler(this.inputControl1_Load);
            // 
            // ROutput
            // 
            this.ROutput.Location = new System.Drawing.Point(212, 18);
            this.ROutput.Name = "ROutput";
            this.ROutput.OldName = null;
            this.ROutput.Size = new System.Drawing.Size(159, 184);
            this.ROutput.TabIndex = 1;
            this.ROutput.Load += new System.EventHandler(this.ROutput_Load);
            // 
            // GOutput
            // 
            this.GOutput.Location = new System.Drawing.Point(377, 18);
            this.GOutput.Name = "GOutput";
            this.GOutput.OldName = null;
            this.GOutput.Size = new System.Drawing.Size(159, 184);
            this.GOutput.TabIndex = 2;
            // 
            // BOutput
            // 
            this.BOutput.Location = new System.Drawing.Point(542, 18);
            this.BOutput.Name = "BOutput";
            this.BOutput.OldName = null;
            this.BOutput.Size = new System.Drawing.Size(159, 184);
            this.BOutput.TabIndex = 3;
            this.BOutput.Load += new System.EventHandler(this.outputControl3_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // GreyScaleDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BOutput);
            this.Controls.Add(this.GOutput);
            this.Controls.Add(this.ROutput);
            this.Controls.Add(this.Input);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Name = "GreyScaleDisplay";
            this.Size = new System.Drawing.Size(710, 205);
            this.Load += new System.EventHandler(this.GreyScaleDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputControl Input;
        private OutputControl ROutput;
        private OutputControl GOutput;
        private OutputControl BOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
