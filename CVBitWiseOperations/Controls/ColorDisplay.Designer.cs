
namespace CVBitWiseOperations.Controls
{
    partial class ColorDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorDisplay));
            this.ImageSelection = new CVBitWiseOperations.Controls.InputControl();
            this.R = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.GreyScale = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Button();
            this.RValue = new System.Windows.Forms.Label();
            this.GValue = new System.Windows.Forms.Label();
            this.BValue = new System.Windows.Forms.Label();
            this.GreyScaleValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImageSelection
            // 
            this.ImageSelection.Location = new System.Drawing.Point(3, 3);
            this.ImageSelection.Name = "ImageSelection";
            this.ImageSelection.Size = new System.Drawing.Size(148, 166);
            this.ImageSelection.TabIndex = 0;
            this.ImageSelection.Load += new System.EventHandler(this.ImageSelection_Load);
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(157, 52);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(14, 15);
            this.R.TabIndex = 2;
            this.R.Text = "R";
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // G
            // 
            this.G.AutoSize = true;
            this.G.Location = new System.Drawing.Point(156, 72);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(15, 15);
            this.G.TabIndex = 4;
            this.G.Text = "G";
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(156, 94);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(14, 15);
            this.B.TabIndex = 6;
            this.B.Text = "B";
            // 
            // GreyScale
            // 
            this.GreyScale.AutoSize = true;
            this.GreyScale.Location = new System.Drawing.Point(156, 123);
            this.GreyScale.Name = "GreyScale";
            this.GreyScale.Size = new System.Drawing.Size(58, 15);
            this.GreyScale.TabIndex = 8;
            this.GreyScale.Text = "GreyScale";
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(156, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 23);
            this.Display.TabIndex = 9;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // RValue
            // 
            this.RValue.AutoSize = true;
            this.RValue.Location = new System.Drawing.Point(180, 52);
            this.RValue.Name = "RValue";
            this.RValue.Size = new System.Drawing.Size(42, 15);
            this.RValue.TabIndex = 10;
            this.RValue.Text = "RValue";
            // 
            // GValue
            // 
            this.GValue.AutoSize = true;
            this.GValue.Location = new System.Drawing.Point(180, 72);
            this.GValue.Name = "GValue";
            this.GValue.Size = new System.Drawing.Size(43, 15);
            this.GValue.TabIndex = 11;
            this.GValue.Text = "GValue";
            // 
            // BValue
            // 
            this.BValue.AutoSize = true;
            this.BValue.Location = new System.Drawing.Point(180, 94);
            this.BValue.Name = "BValue";
            this.BValue.Size = new System.Drawing.Size(42, 15);
            this.BValue.TabIndex = 12;
            this.BValue.Text = "BValue";
            // 
            // GreyScaleValue
            // 
            this.GreyScaleValue.AutoSize = true;
            this.GreyScaleValue.Location = new System.Drawing.Point(154, 138);
            this.GreyScaleValue.Name = "GreyScaleValue";
            this.GreyScaleValue.Size = new System.Drawing.Size(86, 15);
            this.GreyScaleValue.TabIndex = 13;
            this.GreyScaleValue.Text = "GreyScaleValue";
            // 
            // ColorDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GreyScaleValue);
            this.Controls.Add(this.BValue);
            this.Controls.Add(this.GValue);
            this.Controls.Add(this.RValue);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.GreyScale);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.ImageSelection);
            this.Name = "ColorDisplay";
            this.Size = new System.Drawing.Size(243, 172);
            this.Load += new System.EventHandler(this.ColorDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InputControl ImageSelection;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label G;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label GreyScale;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Label RValue;
        private System.Windows.Forms.Label GValue;
        private System.Windows.Forms.Label BValue;
        private System.Windows.Forms.Label GreyScaleValue;
    }
}
