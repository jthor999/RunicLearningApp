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
        

        TextHolder tx = new TextHolder();

        public InfoDisplay()
        {
            InitializeComponent();
            InfoDisplay_Load();
            
        }

       private void InfoDisplay_Load() 
        { 
            Label DisplayLabel = new Label();
            DisplayLabel.Location = new Point(199, 104);
            DisplayLabel.Text = tx.displayText;
        }
        


        
    }
}
