namespace Inscription
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.devicesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.takePictureBtn = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTicks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // devicesCombo
            // 
            this.devicesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesCombo.FormattingEnabled = true;
            this.devicesCombo.Location = new System.Drawing.Point(12, 34);
            this.devicesCombo.Name = "devicesCombo";
            this.devicesCombo.Size = new System.Drawing.Size(328, 21);
            this.devicesCombo.TabIndex = 0;
            this.devicesCombo.SelectedIndexChanged += new System.EventHandler(this.devicesCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Источник кадров:";
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.videoSourcePlayer.Location = new System.Drawing.Point(13, 151);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(325, 281);
            this.videoSourcePlayer.TabIndex = 2;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // takePictureBtn
            // 
            this.takePictureBtn.Location = new System.Drawing.Point(15, 447);
            this.takePictureBtn.Name = "takePictureBtn";
            this.takePictureBtn.Size = new System.Drawing.Size(320, 28);
            this.takePictureBtn.TabIndex = 4;
            this.takePictureBtn.Text = "Save current frame";
            this.takePictureBtn.UseVisualStyleBackColor = true;
            this.takePictureBtn.Click += new System.EventHandler(this.takePictureBtn_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 86);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(73, 25);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(206, 86);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(63, 25);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelTicks
            // 
            this.labelTicks.AutoSize = true;
            this.labelTicks.Location = new System.Drawing.Point(10, 65);
            this.labelTicks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicks.Name = "labelTicks";
            this.labelTicks.Size = new System.Drawing.Size(30, 13);
            this.labelTicks.TabIndex = 7;
            this.labelTicks.Text = "Tiks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Motion Index:";
            // 
            // buttonVideo
            // 
            this.buttonVideo.Location = new System.Drawing.Point(284, 86);
            this.buttonVideo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(54, 25);
            this.buttonVideo.TabIndex = 9;
            this.buttonVideo.Text = "Video";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.ButtonVideo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 493);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTicks);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.takePictureBtn);
            this.Controls.Add(this.videoSourcePlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devicesCombo);
            this.Name = "Form1";
            this.Text = "Webcam Spy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesCombo;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button takePictureBtn;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTicks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.ImageList imageList1;
    }
}

