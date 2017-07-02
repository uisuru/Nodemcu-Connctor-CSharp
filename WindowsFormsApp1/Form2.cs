using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "")
            {
                MessageBox.Show("plece select your device type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (textBox1.Text == "")
            {
                MessageBox.Show("plece enter router SSID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (textBox2.Text == "")
            {
                MessageBox.Show("plece enter router Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (textBox3.Text == "")
            {
                MessageBox.Show("plece enter auth Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("plece select Com Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            timer1.Start();









        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(6);
            if (progressBar1.Value==100) {
                this.timer1.Stop();
                this.timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            label6.Visible = true;
            this.timer2.Stop();
        }
    }
}
