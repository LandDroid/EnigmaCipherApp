using MetroFramework.Forms;
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
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

        }


        public void EncryptButton_Click(object sender, EventArgs e)
        {
         
            this.PnlFormLoader.Controls.Clear();
            EncryptFormPnl frmDashboard_vrb = new EncryptFormPnl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
           DecryptFormPnl frmDashboard_vrb = new DecryptFormPnl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
           this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void ViewMessagesButton_Click(object sender, EventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmMessagesPnl frmDashboard_vrb = new frmMessagesPnl() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmDashboard_vrb);
            frmDashboard_vrb.Show();
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
