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
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = 2.ToString() + "seconds";
        }
    }
}
