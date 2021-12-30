
namespace CVBitWiseOperations.Controls
{
    partial class ImageConversionControl
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
            this.SelectConversion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(0, 3);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(162, 179);
            this.Input.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(295, 3);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(159, 179);
            this.Result.TabIndex = 1;
            this.Result.Load += new System.EventHandler(this.Result_Load);
            // 
            // SelectConversion
            // 
            this.SelectConversion.FormattingEnabled = true;
            this.SelectConversion.Location = new System.Drawing.Point(168, 75);
            this.SelectConversion.Name = "SelectConversion";
            this.SelectConversion.Size = new System.Drawing.Size(121, 23);
            this.SelectConversion.TabIndex = 2;
            this.SelectConversion.SelectedIndexChanged += new System.EventHandler(this.SelectConversion_SelectedIndexChanged);
            // 
            // ImageConversionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectConversion);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Name = "ImageConversionControl";
            this.Size = new System.Drawing.Size(457, 187);
            this.Load += new System.EventHandler(this.ImageConversionControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private InputControl Input;
        private OutputControl Result;
        private System.Windows.Forms.ComboBox SelectConversion;
    }
}
