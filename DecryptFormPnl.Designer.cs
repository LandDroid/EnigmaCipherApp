
namespace EnigmaCipherApp
{
    partial class DecryptFormPnl
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
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.DecryptMsgTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DecryptedMsgLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(750, 182);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "DECRYPT";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DecryptMsgTextBox
            // 
            // 
            // 
            // 
            this.DecryptMsgTextBox.CustomButton.Image = null;
            this.DecryptMsgTextBox.CustomButton.Location = new System.Drawing.Point(523, 1);
            this.DecryptMsgTextBox.CustomButton.Name = "";
            this.DecryptMsgTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DecryptMsgTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DecryptMsgTextBox.CustomButton.TabIndex = 1;
            this.DecryptMsgTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DecryptMsgTextBox.CustomButton.UseSelectable = true;
            this.DecryptMsgTextBox.CustomButton.Visible = false;
            this.DecryptMsgTextBox.Lines = new string[0];
            this.DecryptMsgTextBox.Location = new System.Drawing.Point(280, 142);
            this.DecryptMsgTextBox.MaxLength = 32767;
            this.DecryptMsgTextBox.Name = "DecryptMsgTextBox";
            this.DecryptMsgTextBox.PasswordChar = '\0';
            this.DecryptMsgTextBox.PromptText = "Enter message to decrypt";
            this.DecryptMsgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DecryptMsgTextBox.SelectedText = "";
            this.DecryptMsgTextBox.SelectionLength = 0;
            this.DecryptMsgTextBox.SelectionStart = 0;
            this.DecryptMsgTextBox.ShortcutsEnabled = true;
            this.DecryptMsgTextBox.Size = new System.Drawing.Size(545, 23);
            this.DecryptMsgTextBox.TabIndex = 1;
            this.DecryptMsgTextBox.UseSelectable = true;
            this.DecryptMsgTextBox.WaterMark = "Enter message to decrypt";
            this.DecryptMsgTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DecryptMsgTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(348, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(349, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Enter a encrypted message below to decrypt";
            // 
            // DecryptedMsgLabel
            // 
            this.DecryptedMsgLabel.AutoSize = true;
            this.DecryptedMsgLabel.Location = new System.Drawing.Point(280, 238);
            this.DecryptedMsgLabel.Name = "DecryptedMsgLabel";
            this.DecryptedMsgLabel.Size = new System.Drawing.Size(15, 19);
            this.DecryptedMsgLabel.TabIndex = 3;
            this.DecryptedMsgLabel.Text = "?";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(78, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(182, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Enter Encrypted Message -->";
            // 
            // DecryptFormPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 411);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.DecryptedMsgLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DecryptMsgTextBox);
            this.Controls.Add(this.metroButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DecryptFormPnl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DecryptFormPnl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox DecryptMsgTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel DecryptedMsgLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}