﻿namespace HangGirl
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.button1.ForeColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(353, 400);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button1.Size = new System.Drawing.Size(190, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Score";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Stereofidelic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Tan;
            this.button2.Location = new System.Drawing.Point(353, 203);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button2.Size = new System.Drawing.Size(190, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.button3.ForeColor = System.Drawing.Color.Tan;
            this.button3.Location = new System.Drawing.Point(353, 292);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button3.Size = new System.Drawing.Size(190, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Timer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.button4.ForeColor = System.Drawing.Color.Tan;
            this.button4.Location = new System.Drawing.Point(631, 469);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.button4.Size = new System.Drawing.Size(159, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "About";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::HangGirl.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "HangGirl V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

