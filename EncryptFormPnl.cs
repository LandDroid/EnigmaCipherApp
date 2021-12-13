using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaCipherApp
{
    public partial class EncryptFormPnl : Form
    {


        public EncryptFormPnl()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            string InputString = EncryptedMsgTextbox.Text;
           

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
                    nextChar = (char)(((int)letter) + 1);
                FinalString += nextChar;
            }

            EncryptedMsgLabel.Text = FinalString;


            SqlConnection con = new SqlConnection("Data Source =localhost;Initial Catalog=Bass; User ID=BusinessAnalysisSynergySuite_Account;Password=Bass;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into EnigmaMessages(UserID,EnigmaMessage) values ('" + UserIDTextBox.Text + "', '" + EncryptedMsgLabel.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Error");
            }
            con.Close();
        }

        private void enigmaMessagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enigmaMessagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bassDataSet);

        }

        private void EncryptFormPnl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bassDataSet.EnigmaMessages' table. You can move, or remove it, as needed.
            this.enigmaMessagesTableAdapter.Fill(this.bassDataSet.EnigmaMessages);

        }


        private void enigmaMessageIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void enigmaMessageIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enigmaMessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void enigmaMessageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enigmaMessageEncodedLabel_Click(object sender, EventArgs e)
        {

        }

        private void enigmaMessageEncodedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enigmaMessageDecodedLabel_Click(object sender, EventArgs e)
        {

        }

        private void enigmaMessageDecodedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createdOnLabel_Click(object sender, EventArgs e)
        {

        }

        private void createdOnDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
    }
}
