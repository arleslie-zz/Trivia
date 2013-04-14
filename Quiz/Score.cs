using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Score : Form
    {
        public int place = 1;
        public string points;
        public int temp;
        public int time = 5;
        public int players;
        public string file;
        public Score(string answer, string file2, int players2, string points2 = "0, 0, 0, 0")
        {
            InitializeComponent();
            points = points2;
            file = file2;
            players = players2;
            seconds.Visible = false;
        }

        private void Score_Load(object sender, EventArgs e)
        {
            string[] listpoints = points.Split(", ".ToCharArray());
            p1s.Text = listpoints[0];
            p2s.Text = listpoints[1];
            p3s.Text = listpoints[2];
            p4s.Text = listpoints[3];
        }

        private void Score_Resize(object sender, EventArgs e)
        {
            int w = this.Size.Width;
            int h = this.Size.Height;

            panel3.Size = new Size(w / 2, 10);
            panel4.Location = new Point(w, 0);
            panel4.Size = new Size(w / 2, 10);

            int w2 = w / 5;
            p1.Location = new Point(w2, 42);
            p2.Location = new Point(w2 * 2, 42);
            p3.Location = new Point(w2 * 3, 42);
            p4.Location = new Point(w2 * 4, 42);
            p1s.Location = new Point(w2, 88);
            p2s.Location = new Point(w2 * 2, 88);
            p3s.Location = new Point(w2 * 3, 88);
            p4s.Location = new Point(w2 * 4, 88);
        }

        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void p1_Click(object sender, EventArgs e)
        {
            if (place == 1)
            {
                temp = int.Parse(p1s.Text) + 10;
                p1s.Text = temp.ToString();
            }
            else if (place == 2)
            {
                temp = int.Parse(p1s.Text) + 7;
                p1s.Text = temp.ToString();
            }
            else if (place == 3)
            {
                temp = int.Parse(p1s.Text) + 5;
                p1s.Text = temp.ToString();
            }
            else if (place == 4)
            {
                seconds.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            temp = 0;
            place++;
        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (place == 1)
            {
                temp = int.Parse(p1s.Text) + 10;
                p2s.Text = temp.ToString();
            }
            else if (place == 2)
            {
                temp = int.Parse(p1s.Text) + 7;
                p2s.Text = temp.ToString();
            }
            else if (place == 3)
            {
                temp = int.Parse(p1s.Text) + 5;
                p2s.Text = temp.ToString();
            }
            else if (place == 4)
            {
                seconds.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            temp = 0;
            place++;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (place == 1)
            {
                temp = int.Parse(p1s.Text) + 10;
                p3s.Text = temp.ToString();
            }
            else if (place == 2)
            {
                temp = int.Parse(p1s.Text) + 7;
                p3s.Text = temp.ToString();
            }
            else if (place == 3)
            {
                temp = int.Parse(p1s.Text) + 5;
                p3s.Text = temp.ToString();
            }
            else if (place == 4)
            {
                seconds.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            temp = 0;
            place++;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (place == 1)
            {
                temp = int.Parse(p1s.Text) + 10;
                p4s.Text = temp.ToString();
            }
            else if (place == 2)
            {
                temp = int.Parse(p1s.Text) + 7;
                p4s.Text = temp.ToString();
            }
            else if (place == 3)
            {
                temp = int.Parse(p1s.Text) + 5;
                p4s.Text = temp.ToString();
            }
            else if (place == 4)
            {
                seconds.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
            place++;
            temp = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            seconds.Text = "Next Question in " + time.ToString() + " Seconds.";

            if (time == 0)
            {
                points = p1s.Text + ", " + p2s.Text + ", " + p3s.Text + ", " +p4s.Text;
                Form quesiton = new Questions(players, file, points);
                quesiton.Show();
                this.Dispose();
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (place == 4)
            {
                seconds.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
            }
        }
    }
}
