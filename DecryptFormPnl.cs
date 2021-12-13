using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaCipherApp
{
    public partial class DecryptFormPnl : Form
    {
        public DecryptFormPnl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string InputString = DecryptMsgTextBox.Text;
         
            string FinalString = "";
            char nextChar = ' ';
            int count = InputString.Split(' ').Length;

            foreach (char letter in InputString)
            {
                if (letter == 'z')
                    nextChar = 'a';
                else if (letter == 'Z')
                    nextChar = 'A';
                else
                    nextChar = (char)(((int)letter) - 1);
                FinalString += nextChar;
            }

            DecryptedMsgLabel.Text = FinalString;
       
        }
    }
}
