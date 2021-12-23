
namespace CVBitWiseOperations.Controls
{
    partial class SelectionControl
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
            this.Image = new Emgu.CV.UI.ImageBox();
            this.SelectImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(3, 32);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(142, 130);
            this.Image.TabIndex = 2;
            this.Image.TabStop = false;
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(32, 3);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(79, 23);
            this.SelectImage.TabIndex = 3;
            this.SelectImage.Text = "SelectImage";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // SelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.Image);
            this.Name = "SelectionControl";
            this.Size = new System.Drawing.Size(148, 166);
            this.Load += new System.EventHandler(this.SelectionControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Emgu.CV.UI.ImageBox Image;
        private System.Windows.Forms.Button SelectImage;
    }
}
