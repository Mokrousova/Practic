using System;
using System.Drawing;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.BackColor = Color.Transparent;

            foreach (var match in this.flowLayoutPanel1.Controls)
            {
                (match as PictureBox).Image = game.Properties.Resources.match1;
                (match as PictureBox).SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void MatchVisible(object sender, MouseEventArgs e)
        {
            if(sender is PictureBox)
            {
                (sender as PictureBox).Image = game.Properties.Resources.match3;
                (sender as PictureBox).SizeMode = PictureBoxSizeMode.StretchImage; 
            }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var match in this.flowLayoutPanel1.Controls)
            {
                (match as PictureBox).Image = game.Properties.Resources.match1;
                (match as PictureBox).SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
