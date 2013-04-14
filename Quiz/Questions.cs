using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Questions : Form
    {
        public int players;
        public string file2;
        public int time = 15;
        public string answer;
        public string file;
        public string points;
        public Questions(int players2, string file2, string points2 = "0, 0, 0, 0")
        {
            InitializeComponent();
            players = players2;
            file = file2;
            points = points2;
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            file2 = Directory.GetCurrentDirectory().ToString() + "\\" + file + ".txt";
            string[] lines = File.ReadAllLines(file2);
            Random rand = new Random();
            string question2 = lines[rand.Next(lines.Length)];
            string[] options = question2.Split("|".ToCharArray());
            question.Text = options[0];
            A.Text = options[1];
            B.Text = options[2];
            C.Text = options[3];
            D.Text = options[4];
            answer = options[5];

            timer1.Enabled = true;
            timer1.Start();

        }

        private void Questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Questions_Resize(object sender, EventArgs e)
        {
            int w = this.Size.Width;
            int h = this.Size.Height;

            panel7.Size = new Size(w / 2, h - panel1.Size.Height);
            panel8.Size = new Size(w / 2, h - panel1.Size.Height);

            int h2 = panel7.Size.Height;

            panel2.Size = new Size(w / 2, h2 / 2);
            panel3.Size = new Size(w / 2, h2 / 2);

            panel4.Location = new Point(0, h2 /2 - 5);
            panel4.Size = new Size(w / 2, h2 / 2);

            panel5.Location = new Point(0, h2 / 2 - 5);
            panel5.Size = new Size(w / 2, h2 / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            timeDisplay.Text = time.ToString() + " Seconds";

            if (time == 14)
            {
                Form score = new Score(answer, file, players, points);
                score.Show();
                this.Dispose();
            }
        }
    }
}
