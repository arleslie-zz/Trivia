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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numofplayers = int.Parse(players.Value.ToString());

            if(numofplayers < 2){
                MessageBox.Show("There must be more then one player.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (file.Text == "")
            {
                MessageBox.Show("You must choose a quiz file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form Questions = new Questions(numofplayers, file.Text);
                Questions.Show();
                this.Hide();
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            List<String> files = new List<String>();
            foreach (string filepath in Directory.GetFiles(Directory.GetCurrentDirectory().ToString(), "*.txt"))
            {
                files.Add(filepath.Replace(Directory.GetCurrentDirectory().ToString() + "\\", "").Replace(".txt", ""));
            }
           
            file.DataSource = files.ToArray();
        }

        private void players_ValueChanged(object sender, EventArgs e)
        {
            if (players.Value != 4)
            {
                MessageBox.Show("Feature coming soon.", "Not Implmented", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            players.Value = 4;
        }
    }
}
