using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CiscoWebClient
{
    public partial class Form1 : Form
    {
        bool aboutrun = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!aboutrun)
            {
                AboutBox1 frmAbout = new AboutBox1();
                frmAbout.Show();
                aboutrun = true;
                timer1.Stop();
            }
        }

    }
}
