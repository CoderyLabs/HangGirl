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
    public partial class Form_TimeSheet : Form
    {
        public Form_TimeSheet()
        {
            InitializeComponent();
        }

        private void Form_TimeSheet_Load(object sender, EventArgs e)

        { 
        
        }

        private void BkButton_Click(object sender, EventArgs e)
        {
            Form1 newGameMenu = new Form1();
            newGameMenu.FormClosed += new FormClosedEventHandler(MakeVisibleAgain);
            newGameMenu.Show();
            this.Visible = false;
        }

        private void MakeVisibleAgain(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void ScoreGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    String FirstName = 
        //    string LastName = 
        //    string UserName = 
        //    int score = 0;
        //    int time =

        //        public Form_TimeSheet()
        //{
        //    InitializeComponent();
        //}

        //public public Form_TimeSheet() (String userName)
        //{
        //    InitializeComponent();
        //    userNameTextBox.Text = userName;
            
        }
    }
    }

