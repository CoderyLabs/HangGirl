namespace HangGirl
{
    partial class InGame
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActualChancesLeftlbl = new System.Windows.Forms.Label();
            this.ActualScorelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userNameTextBox = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wordPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LtrPanel = new System.Windows.Forms.Panel();
            this.body = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.rArm = new System.Windows.Forms.PictureBox();
            this.rLeg = new System.Windows.Forms.PictureBox();
            this.lLeg = new System.Windows.Forms.PictureBox();
            this.lArm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lArm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(642, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Timer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(503, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Score:";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.ActualChancesLeftlbl);
            this.panel1.Controls.Add(this.ActualScorelbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TimerLabel);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 62);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ActualChancesLeftlbl
            // 
            this.ActualChancesLeftlbl.AutoSize = true;
            this.ActualChancesLeftlbl.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualChancesLeftlbl.ForeColor = System.Drawing.Color.Firebrick;
            this.ActualChancesLeftlbl.Location = new System.Drawing.Point(429, 18);
            this.ActualChancesLeftlbl.Name = "ActualChancesLeftlbl";
            this.ActualChancesLeftlbl.Size = new System.Drawing.Size(24, 27);
            this.ActualChancesLeftlbl.TabIndex = 19;
            this.ActualChancesLeftlbl.Text = "6";
            // 
            // ActualScorelbl
            // 
            this.ActualScorelbl.AutoSize = true;
            this.ActualScorelbl.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualScorelbl.ForeColor = System.Drawing.Color.Firebrick;
            this.ActualScorelbl.Location = new System.Drawing.Point(578, 18);
            this.ActualScorelbl.Name = "ActualScorelbl";
            this.ActualScorelbl.Size = new System.Drawing.Size(0, 27);
            this.ActualScorelbl.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tan;
            this.label6.Location = new System.Drawing.Point(281, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 27);
            this.label6.TabIndex = 17;
            this.label6.Text = "Chances left:";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.TimerLabel.Location = new System.Drawing.Point(725, 18);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 27);
            this.TimerLabel.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Location = new System.Drawing.Point(-7, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(831, 6);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(-4, -6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(831, 12);
            this.panel4.TabIndex = 14;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.AutoSize = true;
            this.userNameTextBox.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.userNameTextBox.Location = new System.Drawing.Point(136, 18);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(0, 27);
            this.userNameTextBox.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.wordPanel);
            this.panel3.Location = new System.Drawing.Point(-10, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 143);
            this.panel3.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(228, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(398, 29);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(216, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Blue Highway Linocut", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // wordPanel
            // 
            this.wordPanel.Location = new System.Drawing.Point(67, 11);
            this.wordPanel.Name = "wordPanel";
            this.wordPanel.Size = new System.Drawing.Size(688, 80);
            this.wordPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.LtrPanel);
            this.panel2.Controls.Add(this.body);
            this.panel2.Controls.Add(this.head);
            this.panel2.Controls.Add(this.rArm);
            this.panel2.Controls.Add(this.rLeg);
            this.panel2.Controls.Add(this.lLeg);
            this.panel2.Controls.Add(this.lArm);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-34, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 372);
            this.panel2.TabIndex = 15;
            // 
            // LtrPanel
            // 
            this.LtrPanel.BackColor = System.Drawing.Color.Transparent;
            this.LtrPanel.Location = new System.Drawing.Point(519, 28);
            this.LtrPanel.Name = "LtrPanel";
            this.LtrPanel.Size = new System.Drawing.Size(317, 267);
            this.LtrPanel.TabIndex = 7;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.Transparent;
            this.body.Image = global::HangGirl.Properties.Resources.body1;
            this.body.Location = new System.Drawing.Point(188, 125);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(23, 51);
            this.body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.body.TabIndex = 4;
            this.body.TabStop = false;
            this.body.Visible = false;
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.Transparent;
            this.head.Image = global::HangGirl.Properties.Resources.head2;
            this.head.Location = new System.Drawing.Point(182, 71);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(33, 51);
            this.head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.head.TabIndex = 1;
            this.head.TabStop = false;
            this.head.Visible = false;
            // 
            // rArm
            // 
            this.rArm.BackColor = System.Drawing.Color.Transparent;
            this.rArm.Image = global::HangGirl.Properties.Resources.rArm1;
            this.rArm.Location = new System.Drawing.Point(215, 85);
            this.rArm.Name = "rArm";
            this.rArm.Size = new System.Drawing.Size(20, 46);
            this.rArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rArm.TabIndex = 5;
            this.rArm.TabStop = false;
            this.rArm.Visible = false;
            // 
            // rLeg
            // 
            this.rLeg.BackColor = System.Drawing.Color.Transparent;
            this.rLeg.Image = global::HangGirl.Properties.Resources.rLeg1;
            this.rLeg.Location = new System.Drawing.Point(206, 179);
            this.rLeg.Name = "rLeg";
            this.rLeg.Size = new System.Drawing.Size(21, 50);
            this.rLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rLeg.TabIndex = 3;
            this.rLeg.TabStop = false;
            this.rLeg.Visible = false;
            // 
            // lLeg
            // 
            this.lLeg.BackColor = System.Drawing.Color.Transparent;
            this.lLeg.Image = global::HangGirl.Properties.Resources.lLeg;
            this.lLeg.Location = new System.Drawing.Point(172, 179);
            this.lLeg.Name = "lLeg";
            this.lLeg.Size = new System.Drawing.Size(22, 50);
            this.lLeg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lLeg.TabIndex = 6;
            this.lLeg.TabStop = false;
            this.lLeg.Visible = false;
            // 
            // lArm
            // 
            this.lArm.BackColor = System.Drawing.Color.Transparent;
            this.lArm.Image = global::HangGirl.Properties.Resources.lArm2;
            this.lArm.Location = new System.Drawing.Point(166, 128);
            this.lArm.Name = "lArm";
            this.lArm.Size = new System.Drawing.Size(20, 53);
            this.lArm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lArm.TabIndex = 2;
            this.lArm.TabStop = false;
            this.lArm.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HangGirl.Properties.Resources.gallow1;
            this.pictureBox1.Location = new System.Drawing.Point(76, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "InGame";
            this.Text = "InGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InGame_FormClosed);
            this.Load += new System.EventHandler(this.InGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InGame_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lArm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.PictureBox lArm;
        private System.Windows.Forms.PictureBox rLeg;
        private System.Windows.Forms.PictureBox body;
        private System.Windows.Forms.PictureBox rArm;
        private System.Windows.Forms.PictureBox lLeg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LtrPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userNameTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel wordPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ActualChancesLeftlbl;
        private System.Windows.Forms.Label ActualScorelbl;
        private System.Windows.Forms.Label label6;
    }
}