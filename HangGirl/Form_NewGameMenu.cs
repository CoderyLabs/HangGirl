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
    public partial class Form_NewGameMenu : Form
    {
        public Form_NewGameMenu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_NewGameMenu_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ExistingPanel.Visible = true;
            NewPanel.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                        

        }

        private void NewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ExistingPanel.Visible = false;
            NewPanel.Visible = true;
        }

        private void ExistingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
       private void BkButton_Click(object sender, EventArgs e)
        {
            Form1 newGameMenu = new Form1();
            newGameMenu.FormClosed += new FormClosedEventHandler(MakeVisibleAgain);
            newGameMenu.Show();
            this.Visible = false; // hide Form1
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(NewRadioButton.Checked) 
            {
                if (UserNameTextBox.Text.Length > 0 && FNameTextBox.Text.Length > 0 && LNameTextBox.Text.Length > 0)
                {
                    InGame inGameWindow = new InGame();
                    inGameWindow.FormClosed += new FormClosedEventHandler(MakeVisibleAgain);
                    inGameWindow.StartPosition = FormStartPosition.Manual;
                    inGameWindow.Location = this.Location;
                    inGameWindow.Show();
                    this.Visible = false; // hide Form1
                }
            }
            else if (ExistingRadioButton.Checked)
                {
                    if(ExistingListBox.SelectedItems.Count == 1)
                    {
                        InGame inGameWindow = new InGame( ExistingListBox.SelectedItem.ToString() );
                        inGameWindow.FormClosed += new FormClosedEventHandler(MakeVisibleAgain);
                        inGameWindow.StartPosition = FormStartPosition.Manual;
                        inGameWindow.Location = this.Location;
                        inGameWindow.Show();
                        this.Visible = false; // hide Form1
                    }

                }
            }
        
        private void MakeVisibleAgain(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void lkjlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jknToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     }
    
}
