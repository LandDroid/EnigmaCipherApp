
namespace EnigmaCipherApp
{
    partial class EncryptFormPnl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label enigmaMessageLabel;
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bassDataSet = new EnigmaCipherApp.BassDataSet();
            this.enigmaMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enigmaMessagesTableAdapter = new EnigmaCipherApp.BassDataSetTableAdapters.EnigmaMessagesTableAdapter();
            this.tableAdapterManager = new EnigmaCipherApp.BassDataSetTableAdapters.TableAdapterManager();
            this.UserIDTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedMsgTextbox = new System.Windows.Forms.TextBox();
            this.EncryptedMsgLabel = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            usernameLabel = new System.Windows.Forms.Label();
            enigmaMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(116, 164);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "Username:";
            usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // enigmaMessageLabel
            // 
            enigmaMessageLabel.AutoSize = true;
            enigmaMessageLabel.Location = new System.Drawing.Point(116, 190);
            enigmaMessageLabel.Name = "enigmaMessageLabel";
            enigmaMessageLabel.Size = new System.Drawing.Size(91, 13);
            enigmaMessageLabel.TabIndex = 9;
            enigmaMessageLabel.Text = "Enigma Message:";
            enigmaMessageLabel.Click += new System.EventHandler(this.enigmaMessageLabel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(426, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(197, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Enter message below to encrypt";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(753, 185);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "ENCRYPT";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bassDataSet
            // 
            this.bassDataSet.DataSetName = "BassDataSet";
            this.bassDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enigmaMessagesBindingSource
            // 
            this.enigmaMessagesBindingSource.DataMember = "EnigmaMessages";
            this.enigmaMessagesBindingSource.DataSource = this.bassDataSet;
            // 
            // enigmaMessagesTableAdapter
            // 
            this.enigmaMessagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EnigmaMessagesTableAdapter = this.enigmaMessagesTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EnigmaCipherApp.BassDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enigmaMessagesBindingSource, "Username", true));
            this.UserIDTextBox.Location = new System.Drawing.Point(260, 161);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.UserIDTextBox.TabIndex = 8;
            this.UserIDTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // EncryptedMsgTextbox
            // 
            this.EncryptedMsgTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enigmaMessagesBindingSource, "EnigmaMessage", true));
            this.EncryptedMsgTextbox.Location = new System.Drawing.Point(260, 187);
            this.EncryptedMsgTextbox.Name = "EncryptedMsgTextbox";
            this.EncryptedMsgTextbox.Size = new System.Drawing.Size(200, 20);
            this.EncryptedMsgTextbox.TabIndex = 10;
            this.EncryptedMsgTextbox.TextChanged += new System.EventHandler(this.enigmaMessageTextBox_TextChanged);
            // 
            // EncryptedMsgLabel
            // 
            this.EncryptedMsgLabel.AutoSize = true;
            this.EncryptedMsgLabel.Location = new System.Drawing.Point(260, 254);
            this.EncryptedMsgLabel.Name = "EncryptedMsgLabel";
            this.EncryptedMsgLabel.Size = new System.Drawing.Size(15, 19);
            this.EncryptedMsgLabel.TabIndex = 3;
            this.EncryptedMsgLabel.Text = "?";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EncryptFormPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 411);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.UserIDTextBox);
            this.Controls.Add(enigmaMessageLabel);
            this.Controls.Add(this.EncryptedMsgTextbox);
            this.Controls.Add(this.EncryptedMsgLabel);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EncryptFormPnl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EncryptFormPnl";
            this.Load += new System.EventHandler(this.EncryptFormPnl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private BassDataSet bassDataSet;
        private System.Windows.Forms.BindingSource enigmaMessagesBindingSource;
        private BassDataSetTableAdapters.EnigmaMessagesTableAdapter enigmaMessagesTableAdapter;
        private BassDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox UserIDTextBox;
        private System.Windows.Forms.TextBox EncryptedMsgTextbox;
        private MetroFramework.Controls.MetroLabel EncryptedMsgLabel;
        private System.Windows.Forms.Timer timer1;
    }
}