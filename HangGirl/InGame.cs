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
    public partial class InGame : Form
    {
        Label[] labels = new Label[27];
        Label[] wordArray = new Label[40];

        String word = "COMPREHEND";
        string hint = "To understand";
        string category = "word";

        int score = 0;
        int chances = 6;
        int time = 0;
        bool gameover = false;
        TimeSpan timer;


        public InGame()
        {
            InitializeComponent();
        }

        public InGame( String userName )
        {
            InitializeComponent();
            userNameTextBox.Text = userName;
            SetupWord(word);
        }

          private void InGame_Load(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            for (int i = 0; i < 26; i++)
            {
                labels[i] = new Label();
                labels[i].Text = Convert.ToChar(i + 65).ToString();
                labels[i].Size = new Size(50, 50);
                labels[i].Font = new Font("Segoe UI", 21, FontStyle.Bold);
                labels[i].ForeColor = System.Drawing.Color.Firebrick;
                labels[i].BackColor = System.Drawing.Color.Transparent;
                labels[i].Location = new Point((x * 50) + LtrPanel.AutoScrollPosition.X, y + LtrPanel.AutoScrollPosition.Y);
                LtrPanel.Controls.Add(labels[i]);
                labels[i].Parent = LtrPanel;

              

                if ((x * 50) >= LtrPanel.Width - 100)
                {
                    y += 50;
                    x = 0;
                }
                else
                    x++;
            }
        }

        private void SetupWord( String word )
        {
            //Label[] labels = new Label[27];
            PictureBox p;

            for (int i = 0; i < word.Length; i++)
            {
                wordArray[i] = new Label();
                wordArray[i].Visible = false;
                wordArray[i].Text = word[i].ToString();
                wordArray[i].TextAlign = ContentAlignment.BottomCenter;

                wordArray[i].Size = new Size(50, 50);
                wordArray[i].Font = new Font("Segoe UI", 21, FontStyle.Bold);
                wordArray[i].ForeColor = System.Drawing.Color.DarkRed;
                wordArray[i].BackColor = System.Drawing.Color.Transparent;
                wordArray[i].Location = new Point((i * 50) + wordPanel.AutoScrollPosition.X, wordPanel.AutoScrollPosition.Y);
                wordPanel.Controls.Add(wordArray[i]);
                wordArray[i].Parent = wordPanel;

                p = new PictureBox();
                p.ClientSize = new Size(50, 15);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.BackgroundImage = HangGirl.Properties.Resources.line;
                p.Location = new Point((i * 50) + wordPanel.AutoScrollPosition.X, wordPanel.AutoScrollPosition.Y + 50);
                wordPanel.Controls.Add(p);
                p.Parent = wordPanel;
            }

                label3.Text = category;
                label5.Text = hint;
          }

             /// <summary>
        /// The keypress function calls the revialWord method and then processes the key 
        /// that was pressed and then scans the list of labels that represent the alphabet 
        /// looking for a match. When a match is found the label containing the matching
        ///  letter is made invisible. Similary the list of labels that represent the word 
        /// is scanned looking for matches and the labels containing the matching letters 
        /// are set to visible. 
        /// </summary>
        private void InGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            int i = 0;
            String letter = e.KeyChar.ToString().ToUpper();
            revealWord(letter);
            if (!gameover)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(letter, @"^[a-zA-Z]+$"))
                    return;
                /*
                while (i < 27)
                {
                    if (labels[i].Text == letter)
                    {
                        labels[i].Visible = false;
                        return;
                    }
                    i++;
                }
                */
            }
            else
                return;
        }

      
       
        /// <summary>
        /// The list of labels that represent the word is scanned looking for matches and 
        /// the labels containing the matching letters are set to visible. 
        /// </summary>
        public void revealWord(String letter)
        {
           int i = 0;
           bool flag = false;
           int visibleCount = 0;

            if (!System.Text.RegularExpressions.Regex.IsMatch(letter, @"^[a-zA-Z]+$"))
                return;

            while (i < word.Length)
            {
                if (wordArray[i].Text == letter)
                {
                    flag = true;
                    if (!wordArray[i].Visible)
                    {
                        wordArray[i].Visible = true;
                        score += 10;
                        ActualScorelbl.Text = score.ToString();
                    }
                }
                if (wordArray[i].Visible)
                {
                    visibleCount++;
                    //MessageBox.Show(visibleCount.ToString() + " " + wordArray.Length);
                }
                if (visibleCount == word.Length) {
                    EndGame(true);
                    return;
                }

                if (i == word.Length - 1 && flag == false)
                {
                    int j=0;

                    while (j < 27)
                    {
                        if (labels[j].Text == letter)
                        {
                            if (labels[j].Visible)
                            {
                                labels[j].Visible = false;
                                break;
                            }
                            else
                                return;
                        }
                        j++;
                    }

                    if (!head.Visible)
                        head.Visible = true;
                    else
                    if (!body.Visible)
                        body.Visible = true;
                    else
                    if (!lArm.Visible)
                        lArm.Visible = true;
                    else
                    if (!rArm.Visible)
                        rArm.Visible = true;
                    else
                    if (!lLeg.Visible)
                        lLeg.Visible = true;
                    else
                    if (!rLeg.Visible) { 
                        rLeg.Visible = true;
                        EndGame(false);
                        return;
                    }
                    ActualChancesLeftlbl.Text = (--chances).ToString();
                }

                i++;
            }
        }

        /// <summary>
        /// The timer control in C# is set to true and the timer tick function
        /// is the set to increment an int that is used to calculate the 
        /// running time
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            timer = TimeSpan.FromSeconds(time);
            TimerLabel.Text = timer.ToString(@"mm\:ss");

            //TimerLabel.Text = (time/60).ToString() + "  :  " + (time % 60).ToString();
            
            if (time == 20 )
            {
                EndGame(false);
                return;
            }
        }

        private void EndGame(bool winner)
        {
            LtrPanel.Visible = false;
            wordPanel.Visible = false;
            panel6.Visible = false;
            timer1.Enabled = false;
            Results_Form Results = new Results_Form(userNameTextBox.Text, ActualScorelbl.Text, TimerLabel.Text, word, winner);
            Results.StartPosition = FormStartPosition.CenterParent;
            Results.FormClosed += new FormClosedEventHandler(MakeVisibleAgain);
            Results.ShowDialog();
            gameover = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InGame_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MakeVisibleAgain(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

       
    }
}
