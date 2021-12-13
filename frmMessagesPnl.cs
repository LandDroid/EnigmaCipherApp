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
    public partial class frmMessagesPnl : Form
    {
        public frmMessagesPnl()
        {
            InitializeComponent();
        }

        private void enigmaMessagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enigmaMessagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bassDataSet);

        }

        private void frmMessagesPnl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bassDataSet.EnigmaMessages' table. You can move, or remove it, as needed.
            this.enigmaMessagesTableAdapter.Fill(this.bassDataSet.EnigmaMessages);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
