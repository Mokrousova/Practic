using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = true;
            pictureBox15.Visible = false;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (count < 3 )
            {
                count++;
                pictureBox16.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                count++;
                pictureBox17.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
