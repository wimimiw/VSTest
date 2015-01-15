using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.dataGridView1.Rows.Add(10);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // DataGridViewButtonCell dgbc = new DataGridViewButtonCell();

           // this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] = dgbc;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Type tt = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType();

            //if ( tt.Name != "DataGridViewButtonCell")
            //{
            //    DataGridViewButtonCell dgbc = new DataGridViewButtonCell();
            //  //  this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Dispose();
            //    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] = dgbc;
            //}
            //else
            //{
            //    DataGridViewCheckBoxCell dgcbc = new DataGridViewCheckBoxCell();
            //    //(this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell).Dispose(); 
            //   // Type jh = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType();
            //    //this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].InitializeEditingControl(e.RowIndex,null,DataGridViewCellStyle.);
            //    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] = dgcbc;

            //}




        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            pb.Image = Properties.Resources.Ubuntu_10_Icon_108;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            pb.Image = Properties.Resources.Ubuntu_10_Icon_49;
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {          
                DataGridViewImageCell dgvic = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;

                dgvic.Value = Properties.Resources.Ubuntu_10_Icon_108;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                DataGridViewImageCell dgvic = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;

                dgvic.Value = Properties.Resources.Ubuntu_10_Icon_49;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        Form2 fm;
        Thread thd;

        private void button1_Click(object sender, EventArgs e)
        {
            thd = new Thread(new ThreadStart(delegate {
                fm = new Form2();
                fm.ShowDialog();                     
            }));

            thd.Start();

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            thd.Abort();
            thd = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
        }
    }
}
