
namespace CVBitWiseOperations.Controls
{
    partial class InputControl
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
            this.SelectedImage = new Emgu.CV.UI.ImageBox();
            this.SelectImage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedImage
            // 
            this.SelectedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedImage.Location = new System.Drawing.Point(3, 32);
            this.SelectedImage.Name = "SelectedImage";
            this.SelectedImage.Size = new System.Drawing.Size(157, 138);
            this.SelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectedImage.TabIndex = 2;
            this.SelectedImage.TabStop = false;
            this.SelectedImage.Click += new System.EventHandler(this.Image_Click);
            // 
            // SelectImage
            // 
            this.SelectImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectImage.FormattingEnabled = true;
            this.SelectImage.Location = new System.Drawing.Point(0, 3);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(160, 23);
            this.SelectImage.TabIndex = 3;
            this.SelectImage.SelectedIndexChanged += new System.EventHandler(this.SelectImage_SelectedIndexChanged);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.SelectedImage);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(164, 174);
            this.Load += new System.EventHandler(this.SelectionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox SelectedImage;
        private System.Windows.Forms.ComboBox SelectImage;
    }
}
