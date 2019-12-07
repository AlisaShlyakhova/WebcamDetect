﻿/**
 * @Author: Kheir Eddine FARFAR
 * @Author Github: https://github.com/Reddine
 * @Description: Capture Images from WebCam
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Net;
using System.IO;
using AForge.Vision.Motion;

namespace Inscription
{
    public partial class Form1 : Form
    {
        //
        //From https://github.com/Reddine/Webcam-Capture-AForge.Net
        //
        FilterInfoCollection videoDevices;
        private MotionDetector detector = new MotionDetector((IMotionDetector)new TwoFramesDifferenceDetector(), (IMotionProcessing)null);
        List<Bitmap> currentFrames = new List<Bitmap>();
        List<float> MotionLevels = new List<float>();
        VideoCaptureDevice device;

        long tickCounter = 0;
        public Form1()
        {
            InitializeComponent();

            // show device list
            try
            {
                // enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    devicesCombo.Items.Add(device.Name);
                }
            }
            catch (ApplicationException)
            {
                devicesCombo.Items.Add("No local capture devices");
                devicesCombo.Enabled = false;
                takePictureBtn.Enabled = false;
            }

            devicesCombo.SelectedIndex = 0;

            
        }

        private void takePictureBtn_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;              // Use current time
	        string format = "yyyy_MM_dd_HH_mm_ss";    // Use this format
            String strFilename = "Capture-" + time.ToString(format) + ".jpg";
            if (videoSourcePlayer.IsRunning)
            {
                Bitmap picture = videoSourcePlayer.GetCurrentVideoFrame();
                picture.Save(strFilename, ImageFormat.Jpeg);
                currentFrames.Add(picture);
                labelSaved.Text = "Capture Saved : " + strFilename;                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();
            videoDevices = null;
            videoDevices = null;
        }

        private void devicesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //videoSourcePlayer.SignalToStop();
            //videoSourcePlayer.WaitForStop();
            //VideoCaptureDevice videoCaptureSource = new VideoCaptureDevice(videoDevices[devicesCombo.SelectedIndex].MonikerString);
            //videoSourcePlayer.VideoSource = videoCaptureSource;
            //videoSourcePlayer.Start();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice videoCaptureSource = new VideoCaptureDevice(videoDevices[devicesCombo.SelectedIndex].MonikerString);
            device = videoCaptureSource;    
            videoSourcePlayer.VideoSource = videoCaptureSource;
            videoSourcePlayer.Start();
            timer1.Start();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();
            timer1.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (tickCounter>0 && tickCounter % 300 == 0)
            {
                //count average motion over minute
                float level = AverageMotion(60);//porog 0.07
                float max = MaxMotion(60);
                MessageBox.Show("level=" +level+" max="+max) ;
                
            }
            labelTicks.Text = tickCounter.ToString();
            if (videoSourcePlayer.IsRunning)
            {
                Bitmap picture = videoSourcePlayer.GetCurrentVideoFrame();
                //currentFrames.Add(picture);
                //takePictureBtn_Click(null, null);
                //picture = currentFrames.Last();
                if (tickCounter % 10 == 0 && picture != null)
                {
                    float num = detector.ProcessFrame(picture);
                    MotionLevels.Add(num);
                }
            }
            tickCounter++;
        }
        public float AverageMotion(int seconds)
        {
            try
            {
                float num1 = 0.0f;
                int num2 = MotionLevels.Count - 1 - seconds;
                if (num2 < 0) num2 = 0;
                for (int index = MotionLevels.Count - 1; index > num2; --index)
                    num1 += MotionLevels[index];
                return num1 / (float)seconds;
            }
            catch
            {
                return 0.0f;
            }

        }
        public float MaxMotion(int seconds)
        {
            try
            {
                float max = -10;
                int num2 = MotionLevels.Count - 1 - seconds;
                if (num2 < 0) num2 = 0;
                for (int index = MotionLevels.Count - 1; index > num2; --index)
                    if (MotionLevels[index] > max)
                        max = MotionLevels[index];
                return max;
            }
            catch
            {
                return 0.0f;
            }

        }
    }
}
