using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool blab1 = false;
        bool blab2 = false;

        long index = 0;
        long index2 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Visible = blab1;
            //label2.Visible = blab2;

            label1.Text = index.ToString();
            label2.Text = index2.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Uses the second Core or Processor for the Test   
            //Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2);
            // Prevents "Normal" processes    
            // from interrupting Threads   
            //Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

            System.Threading.Thread thrd1 = new System.Threading.Thread(excite1);
            System.Threading.Thread thrd2 = new System.Threading.Thread(excite2);    
            thrd1.Start();
            thrd2.Start();
        }

        void excite1()
        {
            // Prevents "Normal" Threads    
            //Thread.CurrentThread.Priority = ThreadPriority.Highest;   
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            // sw.Stop(); sw.Reset();// sw.Start();
            int cntBak = Environment.TickCount;
            while (true)
            {
                // sw.Stop(); sw.Reset(); sw.Start();
                cntBak = Environment.TickCount;
                System.Threading.Thread.Sleep(100);
                index = Environment.TickCount - cntBak;
                //sw.Stop();
                //index = sw.ElapsedMilliseconds;
                //sw.Stop(); sw.Reset(); sw.Start();
                //sw.Stop();
                //index2 = sw.ElapsedMilliseconds;
            }
        }

        void excite2()
        {
            // Prevents "Normal" Threads    
            //Thread.CurrentThread.Priority = ThreadPriority.Highest;   
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            // sw.Stop(); sw.Reset();// sw.Start();
            int cntBak = Environment.TickCount;
            while (true)
            {
                // sw.Stop(); sw.Reset(); sw.Start();
                //sw.Stop();
                //index = sw.ElapsedMilliseconds;
                //sw.Stop(); sw.Reset(); sw.Start();
                cntBak = Environment.TickCount;
                System.Threading.Thread.Sleep(50);
                index2 = Environment.TickCount - cntBak;
                //sw.Stop();
                //index2 = sw.ElapsedMilliseconds;
            }
        }
    }
}