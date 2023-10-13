using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangGirl
{
    public partial class Results_Form : Form
    {
        int time = 0;

        public Results_Form()
        {
            InitializeComponent();
        }

        public Results_Form( string username, string score, string time, string word, bool winner)
        {
            InitializeComponent();

            if (winner)
                label8.Text = "You Win!!!!";
            else
                label8.Text = "You Lose!!!!";

            label3.Text = username;
            label5.Text = score;
            label6.Text = time;
            label9.Text = word;

        }

        private void Results_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void MakeVisibleAgain(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 10)
            {
                this.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //(InGame)this.Parent.
            //this.Visible = false; // hide Form1
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}   
