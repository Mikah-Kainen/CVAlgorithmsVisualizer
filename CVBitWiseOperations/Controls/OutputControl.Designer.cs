
namespace CVBitWiseOperations.Controls
{
    partial class OutputControl
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
            this.OutputImage = new Emgu.CV.UI.ImageBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).BeginInit();
            this.FlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputImage
            // 
            this.OutputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputImage.Location = new System.Drawing.Point(0, 118);
            this.OutputImage.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.OutputImage.Name = "OutputImage";
            this.OutputImage.Size = new System.Drawing.Size(454, 438);
            this.OutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OutputImage.TabIndex = 2;
            this.OutputImage.TabStop = false;
            this.OutputImage.Click += new System.EventHandler(this.Output_Click);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(9, 10);
            this.NameText.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(287, 55);
            this.NameText.TabIndex = 3;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(314, 10);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(117, 74);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FlowPanel
            // 
            this.FlowPanel.Controls.Add(this.NameText);
            this.FlowPanel.Controls.Add(this.SaveButton);
            this.FlowPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(449, 106);
            this.FlowPanel.TabIndex = 5;
            this.FlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowPanel_Paint);
            // 
            // OutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.OutputImage);
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "OutputControl";
            this.Size = new System.Drawing.Size(454, 557);
            this.Load += new System.EventHandler(this.OutputControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).EndInit();
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox OutputImage;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
    }
}
