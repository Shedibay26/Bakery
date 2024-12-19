namespace Bakery
{
    partial class FormSuppliers
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
            System.Windows.Forms.Label label4;
            this.supplierTableAdapter = new Bakery.BakeryShopDataSet3TableAdapters.SupplierTableAdapter();
            this.tbS = new System.Windows.Forms.TextBox();
            this.bakeryShopDataSet1 = new Bakery.BakeryShopDataSet1();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryShopDataSet3 = new Bakery.BakeryShopDataSet3();
            this.label3 = new System.Windows.Forms.Label();
            this.productBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryShopDataSet2 = new Bakery.BakeryShopDataSet2();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager2 = new Bakery.BakeryShopDataSet3TableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new Bakery.BakeryShopDataSet2TableAdapters.TableAdapterManager();
            this.productTableAdapter1 = new Bakery.BakeryShopDataSet2TableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Bakery.BakeryShopDataSet1TableAdapters.TableAdapterManager();
            this.productTableAdapter = new Bakery.BakeryShopDataSet1TableAdapters.ProductTableAdapter();
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSupplierN = new System.Windows.Forms.TextBox();
            this.tbPN = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPP = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbRQ = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbMuni = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(19, 343);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 19);
            label4.TabIndex = 32;
            label4.Text = "Phone";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(294, 105);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(302, 20);
            this.tbS.TabIndex = 52;
            // 
            // bakeryShopDataSet1
            // 
            this.bakeryShopDataSet1.DataSetName = "BakeryShopDataSet1";
            this.bakeryShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoGenerateColumns = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.municipalityDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvSupplier.DataSource = this.supplierBindingSource;
            this.dgvSupplier.Location = new System.Drawing.Point(294, 131);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersVisible = false;
            this.dgvSupplier.Size = new System.Drawing.Size(639, 558);
            this.dgvSupplier.TabIndex = 54;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // municipalityDataGridViewTextBoxColumn
            // 
            this.municipalityDataGridViewTextBoxColumn.DataPropertyName = "Municipality";
            this.municipalityDataGridViewTextBoxColumn.HeaderText = "Municipality";
            this.municipalityDataGridViewTextBoxColumn.Name = "municipalityDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.bakeryShopDataSet3;
            // 
            // bakeryShopDataSet3
            // 
            this.bakeryShopDataSet3.DataSetName = "BakeryShopDataSet3";
            this.bakeryShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Search";
            // 
            // productBindingSource4
            // 
            this.productBindingSource4.DataMember = "Product";
            this.productBindingSource4.DataSource = this.bakeryShopDataSet2;
            // 
            // bakeryShopDataSet2
            // 
            this.bakeryShopDataSet2.DataSetName = "BakeryShopDataSet2";
            this.bakeryShopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource3
            // 
            this.productBindingSource3.DataMember = "Product";
            this.productBindingSource3.DataSource = this.bakeryShopDataSet1;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.SupplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Bakery.BakeryShopDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Bakery.BakeryShopDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bakery.BakeryShopDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "List of Suppliers";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(18, 58);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(236, 20);
            this.tbID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // tbSupplierN
            // 
            this.tbSupplierN.Location = new System.Drawing.Point(18, 116);
            this.tbSupplierN.Name = "tbSupplierN";
            this.tbSupplierN.Size = new System.Drawing.Size(236, 20);
            this.tbSupplierN.TabIndex = 19;
            // 
            // tbPN
            // 
            this.tbPN.AutoSize = true;
            this.tbPN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPN.Location = new System.Drawing.Point(19, 94);
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(100, 19);
            this.tbPN.TabIndex = 20;
            this.tbPN.Text = "Supplier Name";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(19, 174);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(235, 20);
            this.tbAddress.TabIndex = 21;
            // 
            // tbPP
            // 
            this.tbPP.AutoSize = true;
            this.tbPP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPP.Location = new System.Drawing.Point(18, 152);
            this.tbPP.Name = "tbPP";
            this.tbPP.Size = new System.Drawing.Size(60, 19);
            this.tbPP.TabIndex = 22;
            this.tbPP.Text = "Address";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(19, 237);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(235, 20);
            this.tbCity.TabIndex = 23;
            // 
            // tbRQ
            // 
            this.tbRQ.AutoSize = true;
            this.tbRQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbRQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRQ.Location = new System.Drawing.Point(18, 215);
            this.tbRQ.Name = "tbRQ";
            this.tbRQ.Size = new System.Drawing.Size(34, 19);
            this.tbRQ.TabIndex = 24;
            this.tbRQ.Text = "City";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(19, 302);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(235, 20);
            this.tbM.TabIndex = 25;
            // 
            // tbMuni
            // 
            this.tbMuni.AutoSize = true;
            this.tbMuni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbMuni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMuni.Location = new System.Drawing.Point(19, 280);
            this.tbMuni.Name = "tbMuni";
            this.tbMuni.Size = new System.Drawing.Size(82, 19);
            this.tbMuni.TabIndex = 26;
            this.tbMuni.Text = "Municipality";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(143, 418);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 53);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(37, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 53);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(19, 365);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(235, 20);
            this.tbP.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.tbP);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tbMuni);
            this.panel1.Controls.Add(this.tbM);
            this.panel1.Controls.Add(this.tbRQ);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.tbPP);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.tbPN);
            this.panel1.Controls.Add(this.tbSupplierN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 558);
            this.panel1.TabIndex = 51;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(86, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 53);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 717);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BakeryShopDataSet3TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.TextBox tbS;
        private BakeryShopDataSet1 bakeryShopDataSet1;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private BakeryShopDataSet3 bakeryShopDataSet3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource productBindingSource4;
        private BakeryShopDataSet2 bakeryShopDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private BakeryShopDataSet3TableAdapters.TableAdapterManager tableAdapterManager2;
        private BakeryShopDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private BakeryShopDataSet2TableAdapters.ProductTableAdapter productTableAdapter1;
        private BakeryShopDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private BakeryShopDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSupplierN;
        private System.Windows.Forms.Label tbPN;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label tbPP;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label tbRQ;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label tbMuni;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
    }
}