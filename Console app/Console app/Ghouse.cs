using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Runtime.InteropServices;

namespace Console_app
{

    public partial class Ghouse : Form
    {

        [DllImport("winmm.dll", EntryPoint = "waveOutGetVolume")]
        private static extern int WaveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume")]
        private static extern int WaveOutSetVolume(IntPtr hwo, uint dwVolume);

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Soun.wav");
        bool a = false;
        Bitmap RotatingBlocks;
        Point DrawHere;
        Rectangle InvalidRect;
        bool A;

        public Ghouse()
        {
            player.Play();
            
            RotatingBlocks = new Bitmap(@"Nice.GIF");

            InitializeComponent();
            
            DrawHere = new Point(0, 0);
            InvalidRect = new Rectangle(DrawHere, RotatingBlocks.Size);

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

            this.Load += new System.EventHandler(this.Form1_Load);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(RotatingBlocks);

            e.Graphics.DrawImage(RotatingBlocks, DrawHere);
        }

        private void OnFrameChanged(object o, EventArgs e)
        {

            this.Invalidate(InvalidRect);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ImageAnimator.CanAnimate(RotatingBlocks))
            {

                ImageAnimator.Animate(RotatingBlocks,
                                      new EventHandler(this.OnFrameChanged));


            }
        }

        private void Ghouse_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            a = !a;
            if (!a)
            {
                player.Stop();
            }
        }

        private void Ghouse_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentListForm StartNewForm = new StudentListForm();
            StartNewForm.Show();
            player.Stop();
        }
    }
}
