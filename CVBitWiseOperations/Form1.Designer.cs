
namespace CVBitWiseOperations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddPanel = new System.Windows.Forms.Button();
            this.ControlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.AddColorDisplay = new System.Windows.Forms.Button();
            this.SelectControl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddPanel
            // 
            this.AddPanel.Location = new System.Drawing.Point(667, 12);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(75, 23);
            this.AddPanel.TabIndex = 0;
            this.AddPanel.Text = "AddPanel";
            this.AddPanel.UseVisualStyleBackColor = true;
            this.AddPanel.Click += new System.EventHandler(this.AddPanel_Click);
            // 
            // ControlContainer
            // 
            this.ControlContainer.Location = new System.Drawing.Point(12, 41);
            this.ControlContainer.Name = "ControlContainer";
            this.ControlContainer.Size = new System.Drawing.Size(1152, 682);
            this.ControlContainer.TabIndex = 1;
            // 
            // AddColorDisplay
            // 
            this.AddColorDisplay.Location = new System.Drawing.Point(748, 12);
            this.AddColorDisplay.Name = "AddColorDisplay";
            this.AddColorDisplay.Size = new System.Drawing.Size(107, 23);
            this.AddColorDisplay.TabIndex = 2;
            this.AddColorDisplay.Text = "AddColorDisplay";
            this.AddColorDisplay.UseVisualStyleBackColor = true;
            this.AddColorDisplay.Click += new System.EventHandler(this.AddColorDisplay_Click);
            // 
            // SelectControl
            // 
            this.SelectControl.FormattingEnabled = true;
            this.SelectControl.Location = new System.Drawing.Point(12, 13);
            this.SelectControl.Name = "SelectControl";
            this.SelectControl.Size = new System.Drawing.Size(121, 23);
            this.SelectControl.TabIndex = 3;
            this.SelectControl.SelectedIndexChanged += new System.EventHandler(this.SelectControl_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 735);
            this.Controls.Add(this.SelectControl);
            this.Controls.Add(this.AddColorDisplay);
            this.Controls.Add(this.ControlContainer);
            this.Controls.Add(this.AddPanel);
            this.Name = "Form1";
            this.Text = "AddPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPanel;
        private System.Windows.Forms.FlowLayoutPanel ControlContainer;
        private System.Windows.Forms.Button AddColorDisplay;
        private System.Windows.Forms.ComboBox SelectControl;
    }
}

