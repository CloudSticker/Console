using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Console_app
{

    public partial class Ghouse : Form
    {

        Bitmap RotatingBlocks;
        Point DrawHere;
        Rectangle InvalidRect;

        public Ghouse()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();

           /* RotatingBlocks = new Bitmap(@"Ghouse.gif");
            DrawHere = new Point(10, 10);
            InvalidRect = new Rectangle(DrawHere, RotatingBlocks.Size);

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

            this.Load += new System.EventHandler(this.Form1_Load);
           */
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
    }
}
