using MetroFramework.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnigmaCipherApp
{
    public partial class LoginForm : MetroForm
    {
        static int attempt = 2;

        SqlConnection conn = new SqlConnection(Program.connString);

        [Obsolete]
        public LoginForm()
        {
            InitializeComponent();
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxtBox.Text == "" || PasswordTxtBox.Text == "")
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }
            else
                try
                {
                    SqlCommand cmd = new SqlCommand("User_Login", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", UsernameTxtBox.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTxtBox.Text);

                    conn.Open();

                    int loginResults = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();

                    if (loginResults == 1)
                    {
                        attempt = 0;
              
                        MessageBox.Show("you are granted with access");

                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                    else if ((attempt == 2) && (attempt > 0))
                    {
                       
                        --attempt;
                        MessageBox.Show("Invalid Credentials");
                    }
                    else
                    {
                       
                        --attempt;
                        MessageBox.Show("you are not granted with access");
                    }
                    if (attempt == -1)
                    {
                        
                        MessageBox.Show("Security Features are Shutting Down Application");
                        System.Environment.Exit(1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
    }
