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
    public partial class Questions : Form
    {
        public int players;
        public string file;
        public Questions(int players2, string file2)
        {
            InitializeComponent();
            players = players2;
            file = file2;
            
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            question.Anchor = AnchorStyles.Top;
        }
    }
}
