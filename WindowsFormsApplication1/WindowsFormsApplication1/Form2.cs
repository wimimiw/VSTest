using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int cnt = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cnt++ % 10 == 0)
            {
                this.label2.Text = string.Empty;
                this.Close();
            }
            else
                this.label2.Text += "●";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = string.Empty;
        }
    }
}
