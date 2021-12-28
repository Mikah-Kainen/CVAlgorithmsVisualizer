
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
            this.SelectCernelSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Image = null;
            this.Input.Location = new System.Drawing.Point(3, 3);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(148, 166);
            this.Input.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Image = null;
            this.Result.Location = new System.Drawing.Point(244, 0);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(159, 174);
            this.Result.TabIndex = 1;
            // 
            // SelectCernelSize
            // 
            this.SelectCernelSize.FormattingEnabled = true;
            this.SelectCernelSize.Location = new System.Drawing.Point(157, 40);
            this.SelectCernelSize.Name = "SelectCernelSize";
            this.SelectCernelSize.Size = new System.Drawing.Size(81, 23);
            this.SelectCernelSize.TabIndex = 2;
            this.SelectCernelSize.SelectedIndexChanged += new System.EventHandler(this.SelectCernelSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "CernelSize";
            // 
            // BlurControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectCernelSize);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Name = "BlurControl";
            this.Size = new System.Drawing.Size(407, 178);
            this.Load += new System.EventHandler(this.BlurControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputControl Input;
        private OutputControl Result;
        private System.Windows.Forms.ComboBox SelectCernelSize;
        private System.Windows.Forms.Label label1;
    }
}
