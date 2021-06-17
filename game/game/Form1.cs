using System;
using System.Drawing;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int match_count = 15;
        int match_take = 0;
        int turns = 0;

        public Form1()
        {
            InitializeComponent();
            flowLayoutPanel1.BackColor = Color.Transparent;
        }

        private void MatchVisible(object sender, MouseEventArgs e)
        {
            if (match_take < 3)
            {
                if (sender is PictureBox)
                {
                    match_take++;
                    (sender as PictureBox).Image = null;
                    (sender as PictureBox).BackColor = Color.Transparent;
                    (sender as PictureBox).Enabled = false;

                    match_count--;
                    label4.Text = match_count.ToString();
                }
            }
            else
            {
                MessageBox.Show("Вы не можете взять более 3х спичек за один ход!");
            }
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (PictureBox match in this.flowLayoutPanel1.Controls)
            {
                match.Image = game.Properties.Resources.game1;
                match.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turns++;
            label2.Text = turns.ToString();
            match_take = 0;

            Random random = new Random();
            int botNum = random.Next(1, 4);
            foreach (PictureBox pb in this.flowLayoutPanel1.Controls)
            {
                if (pb.Enabled)
                {
                    pb.Image = null;
                    pb.BackColor = Color.Transparent;
                    pb.Enabled = false;
                    botNum--;
                    match_count--;
                    label4.Text = match_count.ToString();
                    if (botNum <= 0) break;
                }
            }
        }
    }
}
