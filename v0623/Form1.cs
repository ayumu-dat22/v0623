using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0623
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int score = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if(label1.Left<0)
            {
                vx = Math.Abs(vx)*110/100;
            }
            if(label1.Top<0)
            {
                vy = Math.Abs(vy)*110/100;
            }
            if(label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx)*110/100;
            }
            if(label1.Bottom> ClientSize.Height)
            {
                vy = -Math.Abs(vy)*110/100;
            }
            
            score--;
            label2.Text = $"SCORE{ score}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("町田");
            timer1.Enabled=!timer1.Enabled;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
