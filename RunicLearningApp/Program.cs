using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunicLearningApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        
    }

    class TextHolder
    {
        public string displayText;
        public void DescriptionText(int txt)
        {
            string chosen_txt = "runic learning";

            switch (txt) 
            {
                case 0: chosen_txt = "The Fehu Rune";
                    break;
            }


            displayText = chosen_txt;
        }

    }
}
