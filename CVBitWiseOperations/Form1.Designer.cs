
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
            this.SelectControl = new System.Windows.Forms.ComboBox();
            this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddTab = new System.Windows.Forms.Button();
            this.RenameTab = new System.Windows.Forms.Button();
            this.TabNameText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MyTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BreakImage = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.MyTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectControl
            // 
            this.SelectControl.FormattingEnabled = true;
            this.SelectControl.Location = new System.Drawing.Point(328, 3);
            this.SelectControl.Name = "SelectControl";
            this.SelectControl.Size = new System.Drawing.Size(285, 23);
            this.SelectControl.TabIndex = 3;
            this.SelectControl.SelectedIndexChanged += new System.EventHandler(this.SelectControl_SelectedIndexChanged);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.AddTab);
            this.ButtonPanel.Controls.Add(this.RenameTab);
            this.ButtonPanel.Controls.Add(this.TabNameText);
            this.ButtonPanel.Controls.Add(this.textBox1);
            this.ButtonPanel.Controls.Add(this.SelectControl);
            this.ButtonPanel.Controls.Add(this.BreakImage);
            this.ButtonPanel.Location = new System.Drawing.Point(12, 0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(978, 35);
            this.ButtonPanel.TabIndex = 4;
            // 
            // AddTab
            // 
            this.AddTab.Location = new System.Drawing.Point(3, 3);
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(75, 23);
            this.AddTab.TabIndex = 5;
            this.AddTab.Text = "AddTab";
            this.AddTab.UseVisualStyleBackColor = true;
            this.AddTab.Click += new System.EventHandler(this.AddTab_Click);
            // 
            // RenameTab
            // 
            this.RenameTab.Location = new System.Drawing.Point(84, 3);
            this.RenameTab.Name = "RenameTab";
            this.RenameTab.Size = new System.Drawing.Size(81, 23);
            this.RenameTab.TabIndex = 4;
            this.RenameTab.Text = "RenameTab";
            this.RenameTab.UseVisualStyleBackColor = true;
            this.RenameTab.Click += new System.EventHandler(this.RenameTab_Click_1);
            // 
            // TabNameText
            // 
            this.TabNameText.Location = new System.Drawing.Point(171, 3);
            this.TabNameText.Name = "TabNameText";
            this.TabNameText.Size = new System.Drawing.Size(78, 23);
            this.TabNameText.TabIndex = 7;
            this.TabNameText.Text = "TabNameText";
            this.TabNameText.TextChanged += new System.EventHandler(this.TabNameText_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Operations:";
            // 
            // MyTabs
            // 
            this.MyTabs.Controls.Add(this.tabPage1);
            this.MyTabs.Location = new System.Drawing.Point(12, 41);
            this.MyTabs.Name = "MyTabs";
            this.MyTabs.SelectedIndex = 0;
            this.MyTabs.Size = new System.Drawing.Size(978, 591);
            this.MyTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(964, 557);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BreakImage
            // 
            this.BreakImage.Location = new System.Drawing.Point(619, 3);
            this.BreakImage.Name = "BreakImage";
            this.BreakImage.Size = new System.Drawing.Size(75, 23);
            this.BreakImage.TabIndex = 8;
            this.BreakImage.Text = "button1";
            this.BreakImage.UseVisualStyleBackColor = true;
            this.BreakImage.Click += new System.EventHandler(this.BreakImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 637);
            this.Controls.Add(this.MyTabs);
            this.Controls.Add(this.ButtonPanel);
            this.Name = "Form1";
            this.Text = "AddPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.MyTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox SelectControl;
        private System.Windows.Forms.FlowLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button AddTab;
        private System.Windows.Forms.Button RenameTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl MyTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TabNameText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BreakImage;
    }
}

