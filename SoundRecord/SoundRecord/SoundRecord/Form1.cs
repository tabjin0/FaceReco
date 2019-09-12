using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;

namespace SoundRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SoundRecord recorder = new SoundRecord();

        private void btnStart_Click(object sender, EventArgs e)
        {
            string wavfile = null;
            wavfile = "test.wav";
            recorder.SetFileName(wavfile);
            recorder.RecStart();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            recorder.RecStop();
            recorder = null;
        }   
    }
}