
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitwiseOperationControl));
            this.LeftInputImage = new CVBitWiseOperations.Controls.InputControl();
            this.RightInputImage = new CVBitWiseOperations.Controls.InputControl();
            this.SelectOperation = new System.Windows.Forms.ComboBox();
            this.equals = new System.Windows.Forms.Label();
            this.Result = new CVBitWiseOperations.Controls.OutputControl();
            this.SuspendLayout();
            // 
            // LeftInputImage
            // 
            this.LeftInputImage.Location = new System.Drawing.Point(19, 25);
            this.LeftInputImage.Image = ((Emgu.CV.Mat)(resources.GetObject("LeftInputImage.Mat")));
            this.LeftInputImage.Name = "LeftInputImage";
            this.LeftInputImage.Size = new System.Drawing.Size(148, 166);
            this.LeftInputImage.TabIndex = 0;
            // 
            // RightInputImage
            // 
            this.RightInputImage.Location = new System.Drawing.Point(263, 25);
            this.RightInputImage.Image = ((Emgu.CV.Mat)(resources.GetObject("RightInputImage.Mat")));
            this.RightInputImage.Name = "RightInputImage";
            this.RightInputImage.Size = new System.Drawing.Size(148, 166);
            this.RightInputImage.TabIndex = 1;
            this.RightInputImage.Load += new System.EventHandler(this.RightInputImage_Load);
            // 
            // SelectOperation
            // 
            this.SelectOperation.FormattingEnabled = true;
            this.SelectOperation.Location = new System.Drawing.Point(173, 104);
            this.SelectOperation.Name = "SelectOperation";
            this.SelectOperation.Size = new System.Drawing.Size(84, 23);
            this.SelectOperation.TabIndex = 2;
            this.SelectOperation.SelectedIndexChanged += new System.EventHandler(this.SelectOperation_SelectedIndexChanged);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(417, 112);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(41, 15);
            this.equals.TabIndex = 5;
            this.equals.Text = "equals";
            this.equals.Click += new System.EventHandler(this.label1_Click);
            // 
            // Result
            // 
            this.Result.Image = null;
            this.Result.Location = new System.Drawing.Point(464, 25);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(150, 168);
            this.Result.TabIndex = 6;
            // 
            // BitwiseOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Result);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.SelectOperation);
            this.Controls.Add(this.RightInputImage);
            this.Controls.Add(this.LeftInputImage);
            this.Name = "BitwiseOperationControl";
            this.Size = new System.Drawing.Size(631, 224);
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
