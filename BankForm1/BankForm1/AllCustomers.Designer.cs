namespace BankForm1
{
    partial class AllCustomers
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
            System.Windows.Forms.Label sSNLabel;
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label fIRSTNAMELabel;
            System.Windows.Forms.Label sECONDNAMELabel;
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankSystemDataSet = new BankForm1.BankSystemDataSet();
            this.cUSTOMERTableAdapter = new BankForm1.BankSystemDataSetTableAdapters.CUSTOMERTableAdapter();
            this.cUSTOMERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new BankForm1.BankSystemDataSetTableAdapters.TableAdapterManager();
            this.cUSTOMERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNTextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.fIRSTNAMETextBox = new System.Windows.Forms.TextBox();
            this.sECONDNAMETextBox = new System.Windows.Forms.TextBox();
            sSNLabel = new System.Windows.Forms.Label();
            aDDRESSLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            fIRSTNAMELabel = new System.Windows.Forms.Label();
            sECONDNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sSNLabel
            // 
            sSNLabel.AutoSize = true;
            sSNLabel.Location = new System.Drawing.Point(55, 132);
            sSNLabel.Name = "sSNLabel";
            sSNLabel.Size = new System.Drawing.Size(38, 16);
            sSNLabel.TabIndex = 1;
            sSNLabel.Text = "SSN:";
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Location = new System.Drawing.Point(44, 223);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(76, 16);
            aDDRESSLabel.TabIndex = 3;
            aDDRESSLabel.Text = "ADDRESS:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(55, 254);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(58, 16);
            pHONELabel.TabIndex = 5;
            pHONELabel.Text = "PHONE:";
            // 
            // fIRSTNAMELabel
            // 
            fIRSTNAMELabel.AutoSize = true;
            fIRSTNAMELabel.Location = new System.Drawing.Point(44, 163);
            fIRSTNAMELabel.Name = "fIRSTNAMELabel";
            fIRSTNAMELabel.Size = new System.Drawing.Size(91, 16);
            fIRSTNAMELabel.TabIndex = 11;
            fIRSTNAMELabel.Text = "FIRST NAME:";
            // 
            // sECONDNAMELabel
            // 
            sECONDNAMELabel.AutoSize = true;
            sECONDNAMELabel.Location = new System.Drawing.Point(26, 191);
            sECONDNAMELabel.Name = "sECONDNAMELabel";
            sECONDNAMELabel.Size = new System.Drawing.Size(109, 16);
            sECONDNAMELabel.TabIndex = 13;
            sECONDNAMELabel.Text = "SECOND NAME:";
            sECONDNAMELabel.Click += new System.EventHandler(this.sECONDNAMELabel_Click);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.bankSystemDataSetBindingSource;
            // 
            // bankSystemDataSetBindingSource
            // 
            this.bankSystemDataSetBindingSource.DataSource = this.bankSystemDataSet;
            this.bankSystemDataSetBindingSource.Position = 0;
            // 
            // bankSystemDataSet
            // 
            this.bankSystemDataSet.DataSetName = "BankSystemDataSet";
            this.bankSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERBindingSource1
            // 
            this.cUSTOMERBindingSource1.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource1.DataSource = this.bankSystemDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTTableAdapter = null;
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANKTableAdapter = null;
            this.tableAdapterManager.BRANCHTableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.DEALS_WITHTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.LOANTableAdapter = null;
            this.tableAdapterManager.OPENSTableAdapter = null;
            this.tableAdapterManager.SERVESTableAdapter = null;
            this.tableAdapterManager.TAKESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BankForm1.BankSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cUSTOMERDataGridView
            // 
            this.cUSTOMERDataGridView.AutoGenerateColumns = false;
            this.cUSTOMERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cUSTOMERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cUSTOMERDataGridView.DataSource = this.cUSTOMERBindingSource1;
            this.cUSTOMERDataGridView.Location = new System.Drawing.Point(290, 29);
            this.cUSTOMERDataGridView.Name = "cUSTOMERDataGridView";
            this.cUSTOMERDataGridView.RowHeadersWidth = 51;
            this.cUSTOMERDataGridView.RowTemplate.Height = 24;
            this.cUSTOMERDataGridView.Size = new System.Drawing.Size(754, 350);
            this.cUSTOMERDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SSN";
            this.dataGridViewTextBoxColumn1.HeaderText = "SSN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ADDRESS";
            this.dataGridViewTextBoxColumn2.HeaderText = "ADDRESS";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "PHONE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FIRSTNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "FIRSTNAME";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SECONDNAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "SECONDNAME";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // sSNTextBox
            // 
            this.sSNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "SSN", true));
            this.sSNTextBox.Location = new System.Drawing.Point(156, 126);
            this.sSNTextBox.Name = "sSNTextBox";
            this.sSNTextBox.Size = new System.Drawing.Size(100, 22);
            this.sSNTextBox.TabIndex = 2;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(156, 220);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(100, 22);
            this.aDDRESSTextBox.TabIndex = 4;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(156, 248);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(100, 22);
            this.pHONETextBox.TabIndex = 6;
            // 
            // fIRSTNAMETextBox
            // 
            this.fIRSTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "FIRSTNAME", true));
            this.fIRSTNAMETextBox.Location = new System.Drawing.Point(156, 160);
            this.fIRSTNAMETextBox.Name = "fIRSTNAMETextBox";
            this.fIRSTNAMETextBox.Size = new System.Drawing.Size(100, 22);
            this.fIRSTNAMETextBox.TabIndex = 12;
            // 
            // sECONDNAMETextBox
            // 
            this.sECONDNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "SECONDNAME", true));
            this.sECONDNAMETextBox.Location = new System.Drawing.Point(156, 188);
            this.sECONDNAMETextBox.Name = "sECONDNAMETextBox";
            this.sECONDNAMETextBox.Size = new System.Drawing.Size(100, 22);
            this.sECONDNAMETextBox.TabIndex = 14;
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 613);
            this.Controls.Add(fIRSTNAMELabel);
            this.Controls.Add(this.fIRSTNAMETextBox);
            this.Controls.Add(sECONDNAMELabel);
            this.Controls.Add(this.sECONDNAMETextBox);
            this.Controls.Add(sSNLabel);
            this.Controls.Add(this.sSNTextBox);
            this.Controls.Add(aDDRESSLabel);
            this.Controls.Add(this.aDDRESSTextBox);
            this.Controls.Add(pHONELabel);
            this.Controls.Add(this.pHONETextBox);
            this.Controls.Add(this.cUSTOMERDataGridView);
            this.Name = "AllCustomers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bankSystemDataSetBindingSource;
        private BankSystemDataSet bankSystemDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private BankSystemDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource1;
        private BankSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cUSTOMERDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox sSNTextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox fIRSTNAMETextBox;
        private System.Windows.Forms.TextBox sECONDNAMETextBox;
    }
}