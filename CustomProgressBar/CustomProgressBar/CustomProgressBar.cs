using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomProgressBar
{
    public partial class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            //InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private int moveOffset;
        /// <summary>
        /// 划动
        /// </summary>
        public int MoveOffset
        {
            get { return moveOffset; }
            set { moveOffset = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);

            if (ProgressBarRenderer.IsSupported)
            {
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);
            }

            Pen pen = new Pen(this.ForeColor, 2);
            e.Graphics.DrawRectangle(pen, rec);
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), 2, 2, rec.Width - 4, rec.Height - 4);

            rec.Height -= 4;
            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            //e.Graphics.FillRectangle(new SolidBrush(this.ForeColor), 40, 2, rec.Width, rec.Height);

            Point[] pt = new Point[]{
                new Point(MoveOffset,Height-4),
                new Point(MoveOffset+20,Height-4),
                new Point(MoveOffset+20,4),
                new Point(MoveOffset+40,4),
                new Point(MoveOffset+40,Height-4),
                new Point(MoveOffset+60,Height-4),
                new Point(MoveOffset+60,4),
                new Point(MoveOffset+80,4),
                new Point(MoveOffset+80,Height-4),
                new Point(MoveOffset+100,Height-4),
            };

            pen.Width = 4;
            e.Graphics.DrawLines(pen, pt);
            
            base.OnPaint(e);
        }

        /// <summary>
        /// 
        /// </summary>
        private int tt;
        /// <summary>
        /// 
        /// </summary>
        public int Tt
        {
            get { return tt; }
            set { tt = value; }
        }

    }
}
