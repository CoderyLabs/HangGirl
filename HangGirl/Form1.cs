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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_NewGameMenu newGameMenu = new Form_NewGameMenu();
            newGameMenu.FormClosed += new FormClosedEventHandler(MakeVisibleAgain);
            newGameMenu.StartPosition = FormStartPosition.Manual;
            newGameMenu.Location = this.Location;
            newGameMenu.Show();
            this.Visible = false; // hide Form1
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_TimeSheet timeSheet = new Form_TimeSheet();
            timeSheet.Show();
        }

        private void MakeVisibleAgain(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
        
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
