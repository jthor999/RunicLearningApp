using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RunicLearningApp.Properties;

namespace RunicLearningApp
{
    public partial class Form1 : Form
    {
        InfoDisplay infod = new InfoDisplay();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Fehu_btn_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.Fehu;
            id.select_number = 0;
            id.info_or_rune = 0;
            id.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.uruz;
            id.select_number = 1;
            id.info_or_rune = 0;
            id.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.Thuriaz;
            id.select_number = 2;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
           
            InfoDisplay id = new InfoDisplay();
            id.select_number = 0;
            id.info_or_rune = 0;
            id.Show(); 


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.ansuz;
            id.select_number = 3;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay(); id.img = Resources.Raidho;
            id.select_number = 4;
            id.info_or_rune = 0;
            id.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.kaunaz;
            id.select_number = 5;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.gebo;
            id.select_number = 6;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.wunjo;
            id.select_number = 7;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.hagalaz;
            id.select_number = 8;
            id.info_or_rune = 0;
            id.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.Naudiz;
            id.select_number = 9;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.isza;
            id.select_number = 10;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.jera;
            id.select_number = 11;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.eihwaz;
            id.select_number = 12;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.perthro;
            id.select_number = 13;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.algiz;
            id.select_number = 14;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.swoilo;
            id.select_number = 15;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.tiwaz;
            id.select_number = 16;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.Berkanon;
            id.select_number = 17;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.Ehwaz;
            id.select_number = 18;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.mannaz;
            id.select_number = 19;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.Laguz;
            id.select_number = 20;
            id.info_or_rune = 0;
            id.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.ingwaz;
            id.select_number = 21;
            id.info_or_rune = 0;
            id.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.othalan;
            id.select_number = 22;
            id.info_or_rune = 0;
            id.Show(); 
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.img = Resources.Dagaz;
            id.info_or_rune = 0;
            id.select_number = 23;

            id.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoDisplay id = new InfoDisplay();
            id.info_or_rune = 1;

            id.Show(); 
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
