
namespace EnigmaCipherApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PasswordTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.UsernameTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(156, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(244, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CIPHER SECURED MESSAGING";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Location = new System.Drawing.Point(79, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LoginBtn);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(35, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 271);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(125, 232);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseSelectable = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PasswordTxtBox);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Controls.Add(this.UsernameTxtBox);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Location = new System.Drawing.Point(7, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 187);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // PasswordTxtBox
            // 
            // 
            // 
            // 
            this.PasswordTxtBox.CustomButton.Image = null;
            this.PasswordTxtBox.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.PasswordTxtBox.CustomButton.Name = "";
            this.PasswordTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PasswordTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PasswordTxtBox.CustomButton.TabIndex = 1;
            this.PasswordTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PasswordTxtBox.CustomButton.UseSelectable = true;
            this.PasswordTxtBox.CustomButton.Visible = false;
            this.PasswordTxtBox.Lines = new string[0];
            this.PasswordTxtBox.Location = new System.Drawing.Point(89, 121);
            this.PasswordTxtBox.MaxLength = 32767;
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.PromptText = "Enter username";
            this.PasswordTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTxtBox.SelectedText = "";
            this.PasswordTxtBox.SelectionLength = 0;
            this.PasswordTxtBox.SelectionStart = 0;
            this.PasswordTxtBox.ShortcutsEnabled = true;
            this.PasswordTxtBox.Size = new System.Drawing.Size(139, 23);
            this.PasswordTxtBox.TabIndex = 3;
            this.PasswordTxtBox.UseSelectable = true;
            this.PasswordTxtBox.WaterMark = "Enter username";
            this.PasswordTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PasswordTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(90, 99);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Password:";
            // 
            // UsernameTxtBox
            // 
            // 
            // 
            // 
            this.UsernameTxtBox.CustomButton.Image = null;
            this.UsernameTxtBox.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.UsernameTxtBox.CustomButton.Name = "";
            this.UsernameTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UsernameTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UsernameTxtBox.CustomButton.TabIndex = 1;
            this.UsernameTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UsernameTxtBox.CustomButton.UseSelectable = true;
            this.UsernameTxtBox.CustomButton.Visible = false;
            this.UsernameTxtBox.Lines = new string[0];
            this.UsernameTxtBox.Location = new System.Drawing.Point(90, 69);
            this.UsernameTxtBox.MaxLength = 32767;
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.PasswordChar = '\0';
            this.UsernameTxtBox.PromptText = "Enter username";
            this.UsernameTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameTxtBox.SelectedText = "";
            this.UsernameTxtBox.SelectionLength = 0;
            this.UsernameTxtBox.SelectionStart = 0;
            this.UsernameTxtBox.ShortcutsEnabled = true;
            this.UsernameTxtBox.Size = new System.Drawing.Size(119, 23);
            this.UsernameTxtBox.TabIndex = 1;
            this.UsernameTxtBox.UseSelectable = true;
            this.UsernameTxtBox.WaterMark = "Enter username";
            this.UsernameTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UsernameTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(90, 46);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Username:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(107, 16);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(163, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Sign-in to send a message";
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(548, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox PasswordTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox UsernameTxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton LoginBtn;
    }
}