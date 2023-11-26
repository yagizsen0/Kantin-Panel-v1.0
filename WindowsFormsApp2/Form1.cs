using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int su = 5;
            int tost = 35;
            int cay = 8;
            int kahve = 10;
            int cikolata = 13;
            int simit = 10;
            int toplam;
            int sutoplam = Convert.ToInt16(textBox1.Text) * su;
            int tosttoplam = Convert.ToInt16(textBox2.Text) * tost;
            int caytoplam = Convert.ToInt16(textBox3.Text) * cay;
            int kahvetoplam = Convert.ToInt16(textBox4.Text) * kahve;
            int cikolatatoplam = Convert.ToInt16(textBox5.Text) * cikolata;
            int simittoplam = Convert.ToInt16(textBox6.Text) * simit;

            
            toplam = sutoplam + tosttoplam + caytoplam + kahvetoplam + cikolatatoplam + simittoplam;
            label2.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://instagram.com/biberzahirecords");
        }

        private void button4_Click(object sender, EventArgs e)
        {
   
        }
    }
}
