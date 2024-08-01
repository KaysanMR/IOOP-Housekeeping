namespace OOPAssignmentUI_1
{
    partial class frm_hk_inventory_manager
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
            this.panelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lblIDNum = new System.Windows.Forms.Label();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.lbl_RequestedBy = new System.Windows.Forms.Label();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView_ItemRequest = new System.Windows.Forms.DataGridView();
            this.requestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliesRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagement_DataSet = new OOPAssignmentUI_1.HotelManagement_DataSet();
            this.suppliesRequestTableAdapter = new OOPAssignmentUI_1.HotelManagement_DataSetTableAdapters.SuppliesRequestTableAdapter();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagement_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.ColumnCount = 2;
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelInfo.Controls.Add(this.txtItemName, 1, 1);
            this.panelInfo.Controls.Add(this.lbl_ID, 0, 0);
            this.panelInfo.Controls.Add(this.lbl_ItemName, 0, 1);
            this.panelInfo.Controls.Add(this.lbl_Quantity, 0, 2);
            this.panelInfo.Controls.Add(this.lbl_Status, 0, 3);
            this.panelInfo.Controls.Add(this.lblIDNum, 1, 0);
            this.panelInfo.Controls.Add(this.cBoxStatus, 1, 3);
            this.panelInfo.Controls.Add(this.lbl_RequestedBy, 0, 4);
            this.panelInfo.Controls.Add(this.lblRequestedBy, 1, 4);
            this.panelInfo.Controls.Add(this.numQuantity, 1, 2);
            this.panelInfo.Location = new System.Drawing.Point(25, 104);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RowCount = 5;
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.Size = new System.Drawing.Size(329, 321);
            this.panelInfo.TabIndex = 13;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(167, 67);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(159, 26);
            this.txtItemName.TabIndex = 14;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(3, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(91, 20);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Request ID";
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Location = new System.Drawing.Point(3, 64);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(91, 20);
            this.lbl_ItemName.TabIndex = 1;
            this.lbl_ItemName.Text = "Item Name:";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(3, 128);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(68, 20);
            this.lbl_Quantity.TabIndex = 1;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(3, 192);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(56, 20);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Status";
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Location = new System.Drawing.Point(167, 0);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(132, 40);
            this.lblIDNum.TabIndex = 1;
            this.lblIDNum.Text = "Select an item to preview";
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Completed"});
            this.cBoxStatus.Location = new System.Drawing.Point(167, 195);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(159, 28);
            this.cBoxStatus.TabIndex = 2;
            // 
            // lbl_RequestedBy
            // 
            this.lbl_RequestedBy.AutoSize = true;
            this.lbl_RequestedBy.Location = new System.Drawing.Point(3, 256);
            this.lbl_RequestedBy.Name = "lbl_RequestedBy";
            this.lbl_RequestedBy.Size = new System.Drawing.Size(114, 20);
            this.lbl_RequestedBy.TabIndex = 1;
            this.lbl_RequestedBy.Text = "Requested By:";
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(167, 256);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(35, 20);
            this.lblRequestedBy.TabIndex = 1;
            this.lblRequestedBy.Text = "N/A";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(167, 131);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(159, 26);
            this.numQuantity.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 600);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 47);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Location = new System.Drawing.Point(25, 670);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(326, 47);
            this.btnNewRequest.TabIndex = 8;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(25, 600);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 47);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(25, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 47);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ItemRequest
            // 
            this.dataGridView_ItemRequest.AllowUserToAddRows = false;
            this.dataGridView_ItemRequest.AllowUserToDeleteRows = false;
            this.dataGridView_ItemRequest.AutoGenerateColumns = false;
            this.dataGridView_ItemRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ItemRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestidDataGridViewTextBoxColumn,
            this.housekeepingidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView_ItemRequest.DataSource = this.suppliesRequestBindingSource;
            this.dataGridView_ItemRequest.Location = new System.Drawing.Point(377, 88);
            this.dataGridView_ItemRequest.Name = "dataGridView_ItemRequest";
            this.dataGridView_ItemRequest.ReadOnly = true;
            this.dataGridView_ItemRequest.RowHeadersWidth = 30;
            this.dataGridView_ItemRequest.RowTemplate.Height = 28;
            this.dataGridView_ItemRequest.Size = new System.Drawing.Size(696, 629);
            this.dataGridView_ItemRequest.TabIndex = 6;
            this.dataGridView_ItemRequest.SelectionChanged += new System.EventHandler(this.dataGridView_ItemRequest_SelectionChanged);
            // 
            // requestidDataGridViewTextBoxColumn
            // 
            this.requestidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.requestidDataGridViewTextBoxColumn.DataPropertyName = "request_id";
            this.requestidDataGridViewTextBoxColumn.HeaderText = "request_id";
            this.requestidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestidDataGridViewTextBoxColumn.Name = "requestidDataGridViewTextBoxColumn";
            this.requestidDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestidDataGridViewTextBoxColumn.Width = 120;
            // 
            // housekeepingidDataGridViewTextBoxColumn
            // 
            this.housekeepingidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.housekeepingidDataGridViewTextBoxColumn.DataPropertyName = "housekeeping_id";
            this.housekeepingidDataGridViewTextBoxColumn.HeaderText = "housekeeping_id";
            this.housekeepingidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.housekeepingidDataGridViewTextBoxColumn.Name = "housekeepingidDataGridViewTextBoxColumn";
            this.housekeepingidDataGridViewTextBoxColumn.ReadOnly = true;
            this.housekeepingidDataGridViewTextBoxColumn.Width = 166;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item_name";
            this.itemnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            this.itemnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemnameDataGridViewTextBoxColumn.Width = 124;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 101;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 8;
            // 
            // suppliesRequestBindingSource
            // 
            this.suppliesRequestBindingSource.DataMember = "SuppliesRequest";
            this.suppliesRequestBindingSource.DataSource = this.hotelManagement_DataSet;
            // 
            // hotelManagement_DataSet
            // 
            this.hotelManagement_DataSet.DataSetName = "HotelManagement_DataSet";
            this.hotelManagement_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliesRequestTableAdapter
            // 
            this.suppliesRequestTableAdapter.ClearBeforeFill = true;
            // 
            // frm_hk_inventory_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 744);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView_ItemRequest);
            this.Name = "frm_hk_inventory_manager";
            this.Text = "frm_hk_inventory_manager";
            this.Load += new System.EventHandler(this.frm_hk_inventory_manager_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ItemRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagement_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelInfo;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lblIDNum;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.Label lbl_RequestedBy;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView_ItemRequest;
        private HotelManagement_DataSet hotelManagement_DataSet;
        private System.Windows.Forms.BindingSource suppliesRequestBindingSource;
        private HotelManagement_DataSetTableAdapters.SuppliesRequestTableAdapter suppliesRequestTableAdapter;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeepingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}