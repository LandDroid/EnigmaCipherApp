
namespace EnigmaCipherApp
{
    partial class frmMessagesPnl
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
            this.bassDataSet = new EnigmaCipherApp.BassDataSet();
            this.enigmaMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enigmaMessagesTableAdapter = new EnigmaCipherApp.BassDataSetTableAdapters.EnigmaMessagesTableAdapter();
            this.tableAdapterManager = new EnigmaCipherApp.BassDataSetTableAdapters.TableAdapterManager();
            this.enigmaMessagesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.bassDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // enigmaMessagesDataGridView
            // 
            this.enigmaMessagesDataGridView.AutoGenerateColumns = false;
            this.enigmaMessagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enigmaMessagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.enigmaMessagesDataGridView.DataSource = this.enigmaMessagesBindingSource;
            this.enigmaMessagesDataGridView.Location = new System.Drawing.Point(122, 42);
            this.enigmaMessagesDataGridView.Name = "enigmaMessagesDataGridView";
            this.enigmaMessagesDataGridView.Size = new System.Drawing.Size(745, 220);
            this.enigmaMessagesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EnigmaMessageId";
            this.dataGridViewTextBoxColumn1.HeaderText = "EnigmaMessageId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn3.HeaderText = "Username";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EnigmaMessage";
            this.dataGridViewTextBoxColumn4.HeaderText = "EnigmaMessage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EnigmaMessageEncoded";
            this.dataGridViewTextBoxColumn5.HeaderText = "EnigmaMessageEncoded";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EnigmaMessageDecoded";
            this.dataGridViewTextBoxColumn6.HeaderText = "EnigmaMessageDecoded";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CreatedOn";
            this.dataGridViewTextBoxColumn7.HeaderText = "CreatedOn";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(888, 76);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "REFRESH";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmMessagesPnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 411);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.enigmaMessagesDataGridView);
            this.Name = "frmMessagesPnl";
            this.Text = "frmMessageForm";
            this.Load += new System.EventHandler(this.frmMessagesPnl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bassDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enigmaMessagesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BassDataSet bassDataSet;
        private System.Windows.Forms.BindingSource enigmaMessagesBindingSource;
        private BassDataSetTableAdapters.EnigmaMessagesTableAdapter enigmaMessagesTableAdapter;
        private BassDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView enigmaMessagesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}