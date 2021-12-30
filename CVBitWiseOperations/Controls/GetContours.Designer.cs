
namespace CVBitWiseOperations.Controls
{
    partial class GetContours
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
            this.ContourInput = new CVBitWiseOperations.Controls.InputControl();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ColorPicker = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contours = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectOperation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(0, 23);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(161, 174);
            this.Input.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(400, 29);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(159, 186);
            this.Result.TabIndex = 1;
            // 
            // ContourInput
            // 
            this.ContourInput.Location = new System.Drawing.Point(167, 23);
            this.ContourInput.Name = "ContourInput";
            this.ContourInput.Size = new System.Drawing.Size(166, 174);
            this.ContourInput.TabIndex = 11;
            // 
            // ColorPicker
            // 
            this.ColorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPicker.Location = new System.Drawing.Point(329, 114);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(65, 77);
            this.ColorPicker.TabIndex = 12;
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input";
            // 
            // Contours
            // 
            this.Contours.AutoSize = true;
            this.Contours.Location = new System.Drawing.Point(203, 5);
            this.Contours.Name = "Contours";
            this.Contours.Size = new System.Drawing.Size(82, 15);
            this.Contours.TabIndex = 14;
            this.Contours.Text = "Contour Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Color";
            // 
            // WidthValue
            // 
            this.WidthValue.Location = new System.Drawing.Point(339, 59);
            this.WidthValue.Name = "WidthValue";
            this.WidthValue.Size = new System.Drawing.Size(46, 23);
            this.WidthValue.TabIndex = 16;
            this.WidthValue.ValueChanged += new System.EventHandler(this.WidthValue_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Draw:";
            // 
            // SelectOperation
            // 
            this.SelectOperation.FormattingEnabled = true;
            this.SelectOperation.Location = new System.Drawing.Point(438, 2);
            this.SelectOperation.Name = "SelectOperation";
            this.SelectOperation.Size = new System.Drawing.Size(121, 23);
            this.SelectOperation.TabIndex = 19;
            this.SelectOperation.SelectedIndexChanged += new System.EventHandler(this.SelectOperation_SelectedIndexChanged);
            // 
            // GetContours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectOperation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WidthValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Contours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.ContourInput);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Input);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Name = "GetContours";
            this.Size = new System.Drawing.Size(562, 218);
            this.Load += new System.EventHandler(this.GetContours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputControl Input;
        private OutputControl Result;
        private InputControl ContourInput;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Label ColorPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Contours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown WidthValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectOperation;
    }
}
