using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunicLearningApp
{
    public partial class InfoDisplay : Form
    {

        public int select_number;
        public int info_or_rune; //will load info slide or rune slides
        public Image img;

        public InfoDisplay()
        {
            InitializeComponent();
            InfoDisplay_Load();
            
        }

       private void InfoDisplay_Load() 
        {
            TextHolder tx = new TextHolder();
            // tx.DescriptionText(select_number);

            if (info_or_rune == 0)
            {
                runedescript.Text = tx.DescriptionText(select_number);
                RuneInfoDisplay.Image = img;
            }else if (info_or_rune == 1) 
            {
                runedescript.Text = tx.InfoText();
            }

            
            
        }

        

        private void InfoDisplay_Shown(object sender, EventArgs e)
        {
            InfoDisplay_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {//return home btn
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void InfoDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RuneInfoDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
