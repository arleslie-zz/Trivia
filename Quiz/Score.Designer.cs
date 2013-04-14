namespace WindowsFormsApplication1
{
    partial class Score
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.seconds = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Label();
            this.p1s = new System.Windows.Forms.Label();
            this.p2s = new System.Windows.Forms.Label();
            this.p3s = new System.Windows.Forms.Label();
            this.p4s = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.answer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.p4s);
            this.panel1.Controls.Add(this.p3s);
            this.panel1.Controls.Add(this.p2s);
            this.panel1.Controls.Add(this.p1s);
            this.panel1.Controls.Add(this.p4);
            this.panel1.Controls.Add(this.p3);
            this.panel1.Controls.Add(this.p2);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 387);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // p1
            // 
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.Color.White;
            this.p1.Location = new System.Drawing.Point(44, 46);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(156, 42);
            this.p1.TabIndex = 1;
            this.p1.Text = "Player 1";
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(734, 43);
            this.panel6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Points";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.seconds);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 331);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(734, 56);
            this.panel5.TabIndex = 5;
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Dock = System.Windows.Forms.DockStyle.Right;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.ForeColor = System.Drawing.Color.White;
            this.seconds.Location = new System.Drawing.Point(102, 0);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(632, 55);
            this.seconds.TabIndex = 4;
            this.seconds.Text = "Next Question in 5 Seconds.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(253)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(534, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 10);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(18)))), ((int)(((byte)(253)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 10);
            this.panel3.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.ForeColor = System.Drawing.Color.White;
            this.p2.Location = new System.Drawing.Point(206, 46);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(158, 42);
            this.p2.TabIndex = 2;
            this.p2.Text = "Player 2";
            this.p2.Click += new System.EventHandler(this.p3_Click);
            // 
            // p3
            // 
            this.p3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3.ForeColor = System.Drawing.Color.White;
            this.p3.Location = new System.Drawing.Point(370, 46);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(160, 42);
            this.p3.TabIndex = 7;
            this.p3.Text = "Player 3";
            this.p3.Click += new System.EventHandler(this.label2_Click);
            // 
            // p4
            // 
            this.p4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4.ForeColor = System.Drawing.Color.White;
            this.p4.Location = new System.Drawing.Point(536, 46);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(160, 42);
            this.p4.TabIndex = 8;
            this.p4.Text = "Player 4";
            this.p4.Click += new System.EventHandler(this.label3_Click);
            // 
            // p1s
            // 
            this.p1s.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1s.ForeColor = System.Drawing.Color.White;
            this.p1s.Location = new System.Drawing.Point(51, 88);
            this.p1s.Name = "p1s";
            this.p1s.Size = new System.Drawing.Size(149, 42);
            this.p1s.TabIndex = 9;
            this.p1s.Text = "0";
            this.p1s.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p2s
            // 
            this.p2s.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2s.ForeColor = System.Drawing.Color.White;
            this.p2s.Location = new System.Drawing.Point(213, 88);
            this.p2s.Name = "p2s";
            this.p2s.Size = new System.Drawing.Size(151, 42);
            this.p2s.TabIndex = 10;
            this.p2s.Text = "0";
            this.p2s.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p3s
            // 
            this.p3s.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p3s.ForeColor = System.Drawing.Color.White;
            this.p3s.Location = new System.Drawing.Point(377, 88);
            this.p3s.Name = "p3s";
            this.p3s.Size = new System.Drawing.Size(153, 42);
            this.p3s.TabIndex = 11;
            this.p3s.Text = "0";
            this.p3s.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p4s
            // 
            this.p4s.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p4s.ForeColor = System.Drawing.Color.White;
            this.p4s.Location = new System.Drawing.Point(543, 88);
            this.p4s.Name = "p4s";
            this.p4s.Size = new System.Drawing.Size(153, 42);
            this.p4s.TabIndex = 12;
            this.p4s.Text = "0";
            this.p4s.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.answer);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 288);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(734, 43);
            this.panel7.TabIndex = 13;
            // 
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.Black;
            this.answer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.ForeColor = System.Drawing.Color.White;
            this.answer.Location = new System.Drawing.Point(0, 0);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(734, 43);
            this.answer.TabIndex = 1;
            this.answer.Text = "Answer:";
            this.answer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Score";
            this.Text = "Score";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Score_FormClosing);
            this.Load += new System.EventHandler(this.Score_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.Resize += new System.EventHandler(this.Score_Resize);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p4;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label p4s;
        private System.Windows.Forms.Label p3s;
        private System.Windows.Forms.Label p2s;
        private System.Windows.Forms.Label p1s;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label answer;
    }
}