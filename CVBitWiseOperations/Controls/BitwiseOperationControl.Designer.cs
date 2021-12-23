
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
            this.components = new System.ComponentModel.Container();
            this.LeftInputImage = new CVBitWiseOperations.Controls.SelectionControl();
            this.RightInputImage = new CVBitWiseOperations.Controls.SelectionControl();
            this.SelectOperation = new System.Windows.Forms.ComboBox();
            this.ResultImage = new Emgu.CV.UI.ImageBox();
            this.NameResult = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftInputImage
            // 
            this.LeftInputImage.Location = new System.Drawing.Point(19, 25);
            this.LeftInputImage.Name = "LeftInputImage";
            this.LeftInputImage.Size = new System.Drawing.Size(148, 166);
            this.LeftInputImage.TabIndex = 0;
            // 
            // RightInputImage
            // 
            this.RightInputImage.Location = new System.Drawing.Point(263, 25);
            this.RightInputImage.Name = "RightInputImage";
            this.RightInputImage.Size = new System.Drawing.Size(148, 166);
            this.RightInputImage.TabIndex = 1;
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
            // ResultImage
            // 
            this.ResultImage.Location = new System.Drawing.Point(475, 56);
            this.ResultImage.Name = "ResultImage";
            this.ResultImage.Size = new System.Drawing.Size(132, 135);
            this.ResultImage.TabIndex = 2;
            this.ResultImage.TabStop = false;
            // 
            // NameResult
            // 
            this.NameResult.Location = new System.Drawing.Point(505, 27);
            this.NameResult.Name = "NameResult";
            this.NameResult.Size = new System.Drawing.Size(71, 23);
            this.NameResult.TabIndex = 4;
            this.NameResult.Text = "NameResult";
            this.NameResult.TextChanged += new System.EventHandler(this.NameResult_TextChanged);
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
            // BitwiseOperationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.equals);
            this.Controls.Add(this.NameResult);
            this.Controls.Add(this.ResultImage);
            this.Controls.Add(this.SelectOperation);
            this.Controls.Add(this.RightInputImage);
            this.Controls.Add(this.LeftInputImage);
            this.Name = "BitwiseOperationControl";
            this.Size = new System.Drawing.Size(631, 224);
            this.Load += new System.EventHandler(this.BitwiseOperationControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SelectionControl LeftInputImage;
        private SelectionControl RightInputImage;
        private System.Windows.Forms.ComboBox SelectOperation;
        private Emgu.CV.UI.ImageBox ResultImage;
        private System.Windows.Forms.TextBox NameResult;
        private System.Windows.Forms.Label equals;
    }
}
