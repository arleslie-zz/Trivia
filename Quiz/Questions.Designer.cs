namespace WindowsFormsApplication1
{
    partial class Questions
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
            this.label1 = new System.Windows.Forms.Label();
            this.timeDisplay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.question = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(31)))), ((int)(((byte)(253)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 800, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // timeDisplay
            // 
            this.timeDisplay.AutoSize = true;
            this.timeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(31)))), ((int)(((byte)(253)))));
            this.timeDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeDisplay.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.timeDisplay.ForeColor = System.Drawing.Color.White;
            this.timeDisplay.Location = new System.Drawing.Point(691, 0);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(207, 49);
            this.timeDisplay.TabIndex = 1;
            this.timeDisplay.Text = "15 Seconds";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(31)))), ((int)(((byte)(253)))));
            this.question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.question.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.question.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.question.Location = new System.Drawing.Point(0, 49);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.ShortcutsEnabled = false;
            this.question.Size = new System.Drawing.Size(691, 106);
            this.question.TabIndex = 2;
            this.question.Text = "Which French speaking country\'s citizens cannot gamble in their own country?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(131)))), ((int)(((byte)(253)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(100)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(18)))), ((int)(((byte)(253)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 49);
            this.label4.TabIndex = 5;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(253)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 49);
            this.label5.TabIndex = 6;
            this.label5.Text = "D";
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(131)))), ((int)(((byte)(253)))));
            this.A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.A.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.A.Location = new System.Drawing.Point(12, 62);
            this.A.Multiline = true;
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Size = new System.Drawing.Size(411, 109);
            this.A.TabIndex = 7;
            this.A.Text = "Which French speaking country\'s citizens cannot gamble in their own country?";
            // 
            // B
            // 
            this.B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(100)))), ((int)(((byte)(251)))));
            this.B.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.B.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.B.Location = new System.Drawing.Point(8, 62);
            this.B.Multiline = true;
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Size = new System.Drawing.Size(411, 109);
            this.B.TabIndex = 8;
            this.B.Text = "Which French speaking country\'s citizens cannot gamble in their own country?";
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(18)))), ((int)(((byte)(253)))));
            this.C.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.C.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.C.Location = new System.Drawing.Point(12, 57);
            this.C.Multiline = true;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Size = new System.Drawing.Size(411, 109);
            this.C.TabIndex = 9;
            this.C.Text = "Which French speaking country\'s citizens cannot gamble in their own country?";
            // 
            // D
            // 
            this.D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(253)))));
            this.D.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.D.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold);
            this.D.Location = new System.Drawing.Point(8, 57);
            this.D.Multiline = true;
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Size = new System.Drawing.Size(411, 109);
            this.D.TabIndex = 10;
            this.D.Text = "Which French speaking country\'s citizens cannot gamble in their own country?";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(31)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.question);
            this.panel1.Controls.Add(this.timeDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 155);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(131)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.A);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 177);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(100)))), ((int)(((byte)(251)))));
            this.panel3.Controls.Add(this.B);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 177);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(18)))), ((int)(((byte)(253)))));
            this.panel4.Controls.Add(this.C);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 172);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(64)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.D);
            this.panel5.Location = new System.Drawing.Point(0, 223);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 172);
            this.panel5.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 155);
            this.panel6.MinimumSize = new System.Drawing.Size(898, 392);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(898, 392);
            this.panel6.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Controls.Add(this.panel3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(474, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(424, 392);
            this.panel8.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(481, 392);
            this.panel7.TabIndex = 16;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 544);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Questions";
            this.Text = "Questions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Questions_FormClosing);
            this.Load += new System.EventHandler(this.Questions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Questions_KeyDown);
            this.Resize += new System.EventHandler(this.Questions_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;

    }
}