
namespace CVBitWiseOperations.Controls
{
    partial class BitwiseOperationControl
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
            this.LeftInputImage = new CVBitWiseOperations.Controls.InputControl();
            this.RightInputImage = new CVBitWiseOperations.Controls.InputControl();
            this.SelectOperation = new System.Windows.Forms.ComboBox();
            this.equals = new System.Windows.Forms.Label();
            this.Result = new CVBitWiseOperations.Controls.OutputControl();
            this.SuspendLayout();
            // 
            // LeftInputImage
            // 
            this.LeftInputImage.Image = null;
            this.LeftInputImage.Location = new System.Drawing.Point(14, 10);
            this.LeftInputImage.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.LeftInputImage.Name = "LeftInputImage";
            this.LeftInputImage.Size = new System.Drawing.Size(423, 531);
            this.LeftInputImage.TabIndex = 0;
            this.LeftInputImage.Load += new System.EventHandler(this.LeftInputImage_Load);
            // 
            // RightInputImage
            // 
            this.RightInputImage.Image = null;
            this.RightInputImage.Location = new System.Drawing.Point(722, 10);
            this.RightInputImage.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.RightInputImage.Name = "RightInputImage";
            this.RightInputImage.Size = new System.Drawing.Size(423, 531);
            this.RightInputImage.TabIndex = 1;
            this.RightInputImage.Load += new System.EventHandler(this.RightInputImage_Load);
            // 
            // SelectOperation
            // 
            this.SelectOperation.FormattingEnabled = true;
            this.SelectOperation.Location = new System.Drawing.Point(454, 242);
            this.SelectOperation.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.SelectOperation.Name = "SelectOperation";
            this.SelectOperation.Size = new System.Drawing.Size(233, 56);
            this.SelectOperation.TabIndex = 2;
            this.SelectOperation.SelectedIndexChanged += new System.EventHandler(this.SelectOperation_SelectedIndexChanged);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(1150, 250);
            this.equals.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(122, 48);
            this.equals.TabIndex = 5;
            this.equals.Text = "equals";
            this.equals.Click += new System.EventHandler(this.label1_Click);
            // 
            // Result
            // 
            this.Result.Image = null;
            this.Result.Location = new System.Drawing.Point(1284, 10);
            this.Result.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(429, 538);
            this.Result.TabIndex = 6;
            // 
            // BitwiseOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Result);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.SelectOperation);
            this.Controls.Add(this.RightInputImage);
            this.Controls.Add(this.LeftInputImage);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Margin = new System.Windows.Forms.Padding(26, 32, 26, 32);
            this.Name = "BitwiseOperationControl";
            this.Size = new System.Drawing.Size(1728, 563);
            this.Load += new System.EventHandler(this.BitwiseOperationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputControl LeftInputImage;
        private InputControl RightInputImage;
        private System.Windows.Forms.ComboBox SelectOperation;
        private System.Windows.Forms.Label equals;
        private OutputControl Result;
    }
}
