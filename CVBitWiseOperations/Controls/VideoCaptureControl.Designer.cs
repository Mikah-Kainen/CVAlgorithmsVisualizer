
namespace CVBitWiseOperations.Controls
{
    partial class VideoCaptureControl
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
            this.SelectCamera = new System.Windows.Forms.ComboBox();
            this.AddCamServer = new System.Windows.Forms.Button();
            this.Result = new CVBitWiseOperations.Controls.OutputControl();
            this.TakePicture = new System.Windows.Forms.Button();
            this.CameraFeed = new Emgu.CV.UI.ImageBox();
            this.outputControl1 = new CVBitWiseOperations.Controls.OutputControl();
            this.ToggleVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CameraFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectCamera
            // 
            this.SelectCamera.FormattingEnabled = true;
            this.SelectCamera.Location = new System.Drawing.Point(3, 4);
            this.SelectCamera.Name = "SelectCamera";
            this.SelectCamera.Size = new System.Drawing.Size(245, 23);
            this.SelectCamera.TabIndex = 1;
            this.SelectCamera.SelectedIndexChanged += new System.EventHandler(this.SelectCamera_SelectedIndexChanged);
            // 
            // AddCamServer
            // 
            this.AddCamServer.Location = new System.Drawing.Point(254, 4);
            this.AddCamServer.Name = "AddCamServer";
            this.AddCamServer.Size = new System.Drawing.Size(97, 23);
            this.AddCamServer.TabIndex = 2;
            this.AddCamServer.Text = "AddCamServer";
            this.AddCamServer.UseVisualStyleBackColor = true;
            this.AddCamServer.Click += new System.EventHandler(this.AddCamServer_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(449, 60);
            this.Result.Name = "Result";
            this.Result.OldName = null;
            this.Result.Size = new System.Drawing.Size(159, 178);
            this.Result.TabIndex = 3;
            // 
            // TakePicture
            // 
            this.TakePicture.Location = new System.Drawing.Point(449, 31);
            this.TakePicture.Name = "TakePicture";
            this.TakePicture.Size = new System.Drawing.Size(155, 23);
            this.TakePicture.TabIndex = 4;
            this.TakePicture.Text = "Take Picture";
            this.TakePicture.UseVisualStyleBackColor = true;
            this.TakePicture.Click += new System.EventHandler(this.TakePicture_Click);
            // 
            // CameraFeed
            // 
            this.CameraFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CameraFeed.Location = new System.Drawing.Point(3, 33);
            this.CameraFeed.Name = "CameraFeed";
            this.CameraFeed.Size = new System.Drawing.Size(440, 440);
            this.CameraFeed.TabIndex = 2;
            this.CameraFeed.TabStop = false;
            // 
            // outputControl1
            // 
            this.outputControl1.Location = new System.Drawing.Point(449, 293);
            this.outputControl1.Name = "outputControl1";
            this.outputControl1.OldName = null;
            this.outputControl1.Size = new System.Drawing.Size(159, 180);
            this.outputControl1.TabIndex = 5;
            // 
            // ToggleVideo
            // 
            this.ToggleVideo.Location = new System.Drawing.Point(449, 264);
            this.ToggleVideo.Name = "ToggleVideo";
            this.ToggleVideo.Size = new System.Drawing.Size(159, 23);
            this.ToggleVideo.TabIndex = 6;
            this.ToggleVideo.Text = "Toggle Video";
            this.ToggleVideo.UseVisualStyleBackColor = true;
            // 
            // VideoCaptureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToggleVideo);
            this.Controls.Add(this.outputControl1);
            this.Controls.Add(this.CameraFeed);
            this.Controls.Add(this.TakePicture);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.AddCamServer);
            this.Controls.Add(this.SelectCamera);
            this.Inputs = new CVBitWiseOperations.Controls.InputControl[0];
            this.Name = "VideoCaptureControl";
            this.Size = new System.Drawing.Size(611, 478);
            this.Load += new System.EventHandler(this.VideoCaptureControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CameraFeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox SelectCamera;
        private System.Windows.Forms.Button AddCamServer;
        private OutputControl Result;
        private System.Windows.Forms.Button TakePicture;
        private Emgu.CV.UI.ImageBox CameraFeed;
        private OutputControl outputControl1;
        private System.Windows.Forms.Button ToggleVideo;
    }
}
