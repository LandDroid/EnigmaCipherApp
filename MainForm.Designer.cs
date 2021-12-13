
namespace EnigmaCipherApp
{
    partial class MainForm
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
            this.enigmaMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EncryptLabel = new MetroFramework.Controls.MetroLabel();
            this.ViewMessagesLabel = new MetroFramework.Controls.MetroLabel();
            this.DecryptLabel = new MetroFramework.Controls.MetroLabel();
            this.EncryptButton = new MetroFramework.Controls.MetroButton();
            this.DecryptButton = new MetroFramework.Controls.MetroButton();
            this.ViewMessagesButton = new MetroFramework.Controls.MetroButton();
            this.PnlFormLoader = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // enigmaAppDBDataSet
            // 
            // enigmaMessagesBindingSource
            // 
            this.enigmaMessagesBindingSource.DataMember = "EnigmaMessages";
        
            // 
            // enigmaMessagesTableAdapter
            // 
          
            // 
            // tableAdapterManager
            // 
            
        
            // 
            // EncryptLabel
            // 
            this.EncryptLabel.AutoSize = true;
            this.EncryptLabel.Location = new System.Drawing.Point(305, 125);
            this.EncryptLabel.Name = "EncryptLabel";
            this.EncryptLabel.Size = new System.Drawing.Size(108, 19);
            this.EncryptLabel.TabIndex = 0;
            this.EncryptLabel.Text = "Encrypt Message";
            // 
            // ViewMessagesLabel
            // 
            this.ViewMessagesLabel.AutoSize = true;
            this.ViewMessagesLabel.Location = new System.Drawing.Point(863, 124);
            this.ViewMessagesLabel.Name = "ViewMessagesLabel";
            this.ViewMessagesLabel.Size = new System.Drawing.Size(96, 19);
            this.ViewMessagesLabel.TabIndex = 2;
            this.ViewMessagesLabel.Text = "View Messages";
            // 
            // DecryptLabel
            // 
            this.DecryptLabel.AutoSize = true;
            this.DecryptLabel.Location = new System.Drawing.Point(595, 124);
            this.DecryptLabel.Name = "DecryptLabel";
            this.DecryptLabel.Size = new System.Drawing.Size(110, 19);
            this.DecryptLabel.TabIndex = 3;
            this.DecryptLabel.Text = "Decrypt Message";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(305, 162);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 4;
            this.EncryptButton.Text = "ENCRYPT";
            this.EncryptButton.UseSelectable = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(595, 162);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 5;
            this.DecryptButton.Text = "DECRYPT";
            this.DecryptButton.UseSelectable = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // ViewMessagesButton
            // 
            this.ViewMessagesButton.Location = new System.Drawing.Point(863, 161);
            this.ViewMessagesButton.Name = "ViewMessagesButton";
            this.ViewMessagesButton.Size = new System.Drawing.Size(96, 23);
            this.ViewMessagesButton.TabIndex = 6;
            this.ViewMessagesButton.Text = "VIEW MESSAGES";
            this.ViewMessagesButton.UseSelectable = true;
            this.ViewMessagesButton.Click += new System.EventHandler(this.ViewMessagesButton_Click);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.HorizontalScrollbarBarColor = true;
            this.PnlFormLoader.HorizontalScrollbarHighlightOnWheel = false;
            this.PnlFormLoader.HorizontalScrollbarSize = 10;
            this.PnlFormLoader.Location = new System.Drawing.Point(20, 224);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1278, 450);
            this.PnlFormLoader.TabIndex = 7;
            this.PnlFormLoader.VerticalScrollbarBarColor = true;
            this.PnlFormLoader.VerticalScrollbarHighlightOnWheel = false;
            this.PnlFormLoader.VerticalScrollbarSize = 10;
            this.PnlFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlFormLoader_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 694);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.ViewMessagesButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.DecryptLabel);
            this.Controls.Add(this.ViewMessagesLabel);
            this.Controls.Add(this.EncryptLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.BindingSource enigmaMessagesBindingSource;
 
        private MetroFramework.Controls.MetroLabel EncryptLabel;
        private MetroFramework.Controls.MetroLabel ViewMessagesLabel;
        private MetroFramework.Controls.MetroLabel DecryptLabel;
        private MetroFramework.Controls.MetroButton EncryptButton;
        private MetroFramework.Controls.MetroButton DecryptButton;
        private MetroFramework.Controls.MetroButton ViewMessagesButton;
        private MetroFramework.Controls.MetroPanel PnlFormLoader;
    }
}