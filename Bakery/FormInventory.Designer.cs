namespace Bakery
{
    partial class FormInventory
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
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStocksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.productBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryShopDataSet2 = new Bakery.BakeryShopDataSet2();
            this.productBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryShopDataSet1 = new Bakery.BakeryShopDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRM = new System.Windows.Forms.TextBox();
            this.tbPS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPStocks = new System.Windows.Forms.TextBox();
            this.tbRQ = new System.Windows.Forms.Label();
            this.tbRemQ = new System.Windows.Forms.TextBox();
            this.tbPP = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbPN = new System.Windows.Forms.Label();
            this.tbProductN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.productBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Bakery.BakeryShopDataSet1TableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Bakery.BakeryShopDataSet1TableAdapters.TableAdapterManager();
            this.productTableAdapter1 = new Bakery.BakeryShopDataSet2TableAdapters.ProductTableAdapter();
            this.tableAdapterManager1 = new Bakery.BakeryShopDataSet2TableAdapters.TableAdapterManager();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(25, 424);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 19);
            label4.TabIndex = 32;
            label4.Text = "Total";
            // 
            // dgvStocks
            // 
            this.dgvStocks.AutoGenerateColumns = false;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.remainingQuantityDataGridViewTextBoxColumn,
            this.productStocksDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.rawMaterialsDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvStocks.DataSource = this.productBindingSource4;
            this.dgvStocks.Location = new System.Drawing.Point(294, 133);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.RowHeadersVisible = false;
            this.dgvStocks.Size = new System.Drawing.Size(639, 549);
            this.dgvStocks.TabIndex = 44;
            this.dgvStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStocks_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // remainingQuantityDataGridViewTextBoxColumn
            // 
            this.remainingQuantityDataGridViewTextBoxColumn.DataPropertyName = "RemainingQuantity";
            this.remainingQuantityDataGridViewTextBoxColumn.HeaderText = "RemainingQuantity";
            this.remainingQuantityDataGridViewTextBoxColumn.Name = "remainingQuantityDataGridViewTextBoxColumn";
            // 
            // productStocksDataGridViewTextBoxColumn
            // 
            this.productStocksDataGridViewTextBoxColumn.DataPropertyName = "ProductStocks";
            this.productStocksDataGridViewTextBoxColumn.HeaderText = "ProductStocks";
            this.productStocksDataGridViewTextBoxColumn.Name = "productStocksDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // rawMaterialsDataGridViewTextBoxColumn
            // 
            this.rawMaterialsDataGridViewTextBoxColumn.DataPropertyName = "RawMaterials";
            this.rawMaterialsDataGridViewTextBoxColumn.HeaderText = "RawMaterials";
            this.rawMaterialsDataGridViewTextBoxColumn.Name = "rawMaterialsDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // bakeryShopDataSet1
            // 
            this.bakeryShopDataSet1.DataSetName = "BakeryShopDataSet1";
            this.bakeryShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Search";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(294, 107);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(302, 20);
            this.tbS.TabIndex = 42;
            this.tbS.TextChanged += new System.EventHandler(this.tbS_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(37, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 53);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpload.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(96, 106);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 27);
            this.btnUpload.TabIndex = 29;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(45, 8);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(190, 92);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 24;
            this.pbImage.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(143, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 53);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Raw Materials";
            // 
            // tbRM
            // 
            this.tbRM.Location = new System.Drawing.Point(25, 500);
            this.tbRM.Name = "tbRM";
            this.tbRM.Size = new System.Drawing.Size(235, 20);
            this.tbRM.TabIndex = 27;
            // 
            // tbPS
            // 
            this.tbPS.AutoSize = true;
            this.tbPS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPS.Location = new System.Drawing.Point(25, 375);
            this.tbPS.Name = "tbPS";
            this.tbPS.Size = new System.Drawing.Size(103, 19);
            this.tbPS.TabIndex = 26;
            this.tbPS.Text = "Product Stocks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "List of Products and Materials";
            // 
            // tbPStocks
            // 
            this.tbPStocks.Location = new System.Drawing.Point(25, 401);
            this.tbPStocks.Name = "tbPStocks";
            this.tbPStocks.Size = new System.Drawing.Size(235, 20);
            this.tbPStocks.TabIndex = 25;
            // 
            // tbRQ
            // 
            this.tbRQ.AutoSize = true;
            this.tbRQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbRQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRQ.Location = new System.Drawing.Point(25, 317);
            this.tbRQ.Name = "tbRQ";
            this.tbRQ.Size = new System.Drawing.Size(126, 19);
            this.tbRQ.TabIndex = 24;
            this.tbRQ.Text = "Remaining Quantity";
            // 
            // tbRemQ
            // 
            this.tbRemQ.Location = new System.Drawing.Point(25, 343);
            this.tbRemQ.Name = "tbRemQ";
            this.tbRemQ.Size = new System.Drawing.Size(235, 20);
            this.tbRemQ.TabIndex = 23;
            // 
            // tbPP
            // 
            this.tbPP.AutoSize = true;
            this.tbPP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPP.Location = new System.Drawing.Point(25, 257);
            this.tbPP.Name = "tbPP";
            this.tbPP.Size = new System.Drawing.Size(92, 19);
            this.tbPP.TabIndex = 22;
            this.tbPP.Text = "Product Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(25, 283);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(235, 20);
            this.tbPrice.TabIndex = 21;
            // 
            // tbPN
            // 
            this.tbPN.AutoSize = true;
            this.tbPN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbPN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPN.Location = new System.Drawing.Point(29, 197);
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(98, 19);
            this.tbPN.TabIndex = 20;
            this.tbPN.Text = "Product Name";
            // 
            // tbProductN
            // 
            this.tbProductN.Location = new System.Drawing.Point(29, 223);
            this.tbProductN.Name = "tbProductN";
            this.tbProductN.Size = new System.Drawing.Size(231, 20);
            this.tbProductN.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.tbTotal);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbRM);
            this.panel1.Controls.Add(this.tbPS);
            this.panel1.Controls.Add(this.tbPStocks);
            this.panel1.Controls.Add(this.tbRQ);
            this.panel1.Controls.Add(this.tbRemQ);
            this.panel1.Controls.Add(this.tbPP);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbPN);
            this.panel1.Controls.Add(this.tbProductN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 601);
            this.panel1.TabIndex = 41;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(25, 450);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(235, 20);
            this.tbTotal.TabIndex = 31;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(29, 167);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(231, 20);
            this.tbID.TabIndex = 17;
            // 
            // productBindingSource2
            // 
            this.productBindingSource2.DataMember = "Product";
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bakery.BakeryShopDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Bakery.BakeryShopDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 717);
            this.Controls.Add(this.dgvStocks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.BindingSource productBindingSource2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRM;
        private System.Windows.Forms.Label tbPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPStocks;
        private System.Windows.Forms.Label tbRQ;
        private System.Windows.Forms.TextBox tbRemQ;
        private System.Windows.Forms.Label tbPP;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label tbPN;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private System.Windows.Forms.TextBox tbProductN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbID;
        private BakeryShopDataSet1 bakeryShopDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource3;
        private BakeryShopDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private BakeryShopDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbTotal;
        private BakeryShopDataSet2 bakeryShopDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource4;
        private BakeryShopDataSet2TableAdapters.ProductTableAdapter productTableAdapter1;
        private BakeryShopDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStocksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}