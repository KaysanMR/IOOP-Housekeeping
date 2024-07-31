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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_RoomNo = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lblIDNum = new System.Windows.Forms.Label();
            this.cBoxBookingStatus = new System.Windows.Forms.ComboBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_Assigned = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblHousekeepers = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView_CleaningSchedule = new System.Windows.Forms.DataGridView();
            this.hotelManagement_DataSet = new OOPAssignmentUI_1.HotelManagement_DataSet();
            this.suppliesRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesRequestTableAdapter = new OOPAssignmentUI_1.HotelManagement_DataSetTableAdapters.SuppliesRequestTableAdapter();
            this.requestidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CleaningSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagement_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.ColumnCount = 2;
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelInfo.Controls.Add(this.lbl_ID, 0, 0);
            this.panelInfo.Controls.Add(this.lbl_RoomNo, 0, 1);
            this.panelInfo.Controls.Add(this.lbl_Type, 0, 2);
            this.panelInfo.Controls.Add(this.lbl_Status, 0, 3);
            this.panelInfo.Controls.Add(this.lblIDNum, 1, 0);
            this.panelInfo.Controls.Add(this.cBoxBookingStatus, 1, 3);
            this.panelInfo.Controls.Add(this.lbl_Date, 0, 5);
            this.panelInfo.Controls.Add(this.datePicker, 1, 5);
            this.panelInfo.Controls.Add(this.lbl_Assigned, 0, 4);
            this.panelInfo.Controls.Add(this.lblRoomNo, 1, 1);
            this.panelInfo.Controls.Add(this.lblHousekeepers, 1, 4);
            this.panelInfo.Controls.Add(this.lblType, 1, 2);
            this.panelInfo.Location = new System.Drawing.Point(25, 104);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RowCount = 6;
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.Size = new System.Drawing.Size(329, 321);
            this.panelInfo.TabIndex = 13;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(3, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(73, 20);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Room ID";
            // 
            // lbl_RoomNo
            // 
            this.lbl_RoomNo.AutoSize = true;
            this.lbl_RoomNo.Location = new System.Drawing.Point(3, 53);
            this.lbl_RoomNo.Name = "lbl_RoomNo";
            this.lbl_RoomNo.Size = new System.Drawing.Size(80, 20);
            this.lbl_RoomNo.TabIndex = 1;
            this.lbl_RoomNo.Text = "Room No.";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(3, 106);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(43, 20);
            this.lbl_Type.TabIndex = 1;
            this.lbl_Type.Text = "Type";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(3, 159);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(118, 20);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Booking Status";
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Location = new System.Drawing.Point(167, 0);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(142, 40);
            this.lblIDNum.TabIndex = 1;
            this.lblIDNum.Text = "Select A Room To Preview";
            // 
            // cBoxBookingStatus
            // 
            this.cBoxBookingStatus.FormattingEnabled = true;
            this.cBoxBookingStatus.Items.AddRange(new object[] {
            "Reserved",
            "Checked-in",
            "Checked-out",
            "Cancelled"});
            this.cBoxBookingStatus.Location = new System.Drawing.Point(167, 162);
            this.cBoxBookingStatus.Name = "cBoxBookingStatus";
            this.cBoxBookingStatus.Size = new System.Drawing.Size(159, 28);
            this.cBoxBookingStatus.TabIndex = 2;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(3, 265);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(110, 20);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Cleaning Date";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy";
            this.datePicker.Location = new System.Drawing.Point(167, 268);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(159, 26);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2024, 7, 31, 22, 4, 31, 0);
            // 
            // lbl_Assigned
            // 
            this.lbl_Assigned.AutoSize = true;
            this.lbl_Assigned.Location = new System.Drawing.Point(3, 212);
            this.lbl_Assigned.Name = "lbl_Assigned";
            this.lbl_Assigned.Size = new System.Drawing.Size(101, 20);
            this.lbl_Assigned.TabIndex = 1;
            this.lbl_Assigned.Text = "Assigned To:";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(167, 53);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(35, 20);
            this.lblRoomNo.TabIndex = 1;
            this.lblRoomNo.Text = "N/A";
            // 
            // lblHousekeepers
            // 
            this.lblHousekeepers.AutoSize = true;
            this.lblHousekeepers.Location = new System.Drawing.Point(167, 212);
            this.lblHousekeepers.Name = "lblHousekeepers";
            this.lblHousekeepers.Size = new System.Drawing.Size(35, 20);
            this.lblHousekeepers.TabIndex = 1;
            this.lblHousekeepers.Text = "N/A";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(167, 106);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "N/A";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 600);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 47);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Location = new System.Drawing.Point(25, 670);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(326, 47);
            this.btnNewRequest.TabIndex = 8;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(25, 600);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 47);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
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
            // dataGridView_CleaningSchedule
            // 
            this.dataGridView_CleaningSchedule.AllowUserToAddRows = false;
            this.dataGridView_CleaningSchedule.AllowUserToDeleteRows = false;
            this.dataGridView_CleaningSchedule.AutoGenerateColumns = false;
            this.dataGridView_CleaningSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CleaningSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestidDataGridViewTextBoxColumn,
            this.housekeepingidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView_CleaningSchedule.DataSource = this.suppliesRequestBindingSource;
            this.dataGridView_CleaningSchedule.Location = new System.Drawing.Point(377, 88);
            this.dataGridView_CleaningSchedule.Name = "dataGridView_CleaningSchedule";
            this.dataGridView_CleaningSchedule.ReadOnly = true;
            this.dataGridView_CleaningSchedule.RowHeadersWidth = 30;
            this.dataGridView_CleaningSchedule.RowTemplate.Height = 28;
            this.dataGridView_CleaningSchedule.Size = new System.Drawing.Size(696, 629);
            this.dataGridView_CleaningSchedule.TabIndex = 6;
            // 
            // hotelManagement_DataSet
            // 
            this.hotelManagement_DataSet.DataSetName = "HotelManagement_DataSet";
            this.hotelManagement_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliesRequestBindingSource
            // 
            this.suppliesRequestBindingSource.DataMember = "SuppliesRequest";
            this.suppliesRequestBindingSource.DataSource = this.hotelManagement_DataSet;
            // 
            // suppliesRequestTableAdapter
            // 
            this.suppliesRequestTableAdapter.ClearBeforeFill = true;
            // 
            // requestidDataGridViewTextBoxColumn
            // 
            this.requestidDataGridViewTextBoxColumn.DataPropertyName = "request_id";
            this.requestidDataGridViewTextBoxColumn.HeaderText = "request_id";
            this.requestidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.requestidDataGridViewTextBoxColumn.Name = "requestidDataGridViewTextBoxColumn";
            this.requestidDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestidDataGridViewTextBoxColumn.Width = 150;
            // 
            // housekeepingidDataGridViewTextBoxColumn
            // 
            this.housekeepingidDataGridViewTextBoxColumn.DataPropertyName = "housekeeping_id";
            this.housekeepingidDataGridViewTextBoxColumn.HeaderText = "housekeeping_id";
            this.housekeepingidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.housekeepingidDataGridViewTextBoxColumn.Name = "housekeepingidDataGridViewTextBoxColumn";
            this.housekeepingidDataGridViewTextBoxColumn.ReadOnly = true;
            this.housekeepingidDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "item_name";
            this.itemnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            this.itemnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // frm_hk_inventory_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 746);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView_CleaningSchedule);
            this.Name = "frm_hk_inventory_manager";
            this.Text = "frm_hk_inventory_manager";
            this.Load += new System.EventHandler(this.frm_hk_inventory_manager_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CleaningSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagement_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesRequestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelInfo;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_RoomNo;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lblIDNum;
        private System.Windows.Forms.ComboBox cBoxBookingStatus;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lbl_Assigned;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblHousekeepers;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView_CleaningSchedule;
        private HotelManagement_DataSet hotelManagement_DataSet;
        private System.Windows.Forms.BindingSource suppliesRequestBindingSource;
        private HotelManagement_DataSetTableAdapters.SuppliesRequestTableAdapter suppliesRequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeepingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}