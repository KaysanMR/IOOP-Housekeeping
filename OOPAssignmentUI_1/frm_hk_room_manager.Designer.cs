namespace OOPAssignmentUI_1
{
    partial class frm_hk_room_manager
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
            this.dataGridView_CleaningSchedule = new System.Windows.Forms.DataGridView();
            this.scheduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagement_DataSet = new OOPAssignmentUI_1.HotelManagement_DataSet();
            this.cleaningScheduleTableAdapter = new OOPAssignmentUI_1.HotelManagement_DataSetTableAdapters.CleaningScheduleTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new OOPAssignmentUI_1.HotelManagement_DataSetTableAdapters.RoomsTableAdapter();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDirty = new System.Windows.Forms.Button();
            this.cBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CleaningSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagement_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_CleaningSchedule
            // 
            this.dataGridView_CleaningSchedule.AllowUserToAddRows = false;
            this.dataGridView_CleaningSchedule.AllowUserToDeleteRows = false;
            this.dataGridView_CleaningSchedule.AutoGenerateColumns = false;
            this.dataGridView_CleaningSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CleaningSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleidDataGridViewTextBoxColumn,
            this.housekeepingidDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.cleaningdateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView_CleaningSchedule.DataSource = this.cleaningScheduleBindingSource;
            this.dataGridView_CleaningSchedule.Location = new System.Drawing.Point(382, 89);
            this.dataGridView_CleaningSchedule.Name = "dataGridView_CleaningSchedule";
            this.dataGridView_CleaningSchedule.ReadOnly = true;
            this.dataGridView_CleaningSchedule.RowHeadersWidth = 30;
            this.dataGridView_CleaningSchedule.RowTemplate.Height = 28;
            this.dataGridView_CleaningSchedule.Size = new System.Drawing.Size(696, 546);
            this.dataGridView_CleaningSchedule.TabIndex = 0;
            this.dataGridView_CleaningSchedule.SelectionChanged += new System.EventHandler(this.dataGridView_CleaningSchedule_SelectionChanged);
            // 
            // scheduleidDataGridViewTextBoxColumn
            // 
            this.scheduleidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scheduleidDataGridViewTextBoxColumn.DataPropertyName = "schedule_id";
            this.scheduleidDataGridViewTextBoxColumn.HeaderText = "schedule_id";
            this.scheduleidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.scheduleidDataGridViewTextBoxColumn.Name = "scheduleidDataGridViewTextBoxColumn";
            this.scheduleidDataGridViewTextBoxColumn.ReadOnly = true;
            this.scheduleidDataGridViewTextBoxColumn.Width = 130;
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
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomidDataGridViewTextBoxColumn.Width = 102;
            // 
            // cleaningdateDataGridViewTextBoxColumn
            // 
            this.cleaningdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cleaningdateDataGridViewTextBoxColumn.DataPropertyName = "cleaning_date";
            this.cleaningdateDataGridViewTextBoxColumn.HeaderText = "cleaning_date";
            this.cleaningdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cleaningdateDataGridViewTextBoxColumn.Name = "cleaningdateDataGridViewTextBoxColumn";
            this.cleaningdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cleaningdateDataGridViewTextBoxColumn.Width = 145;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 89;
            // 
            // cleaningScheduleBindingSource
            // 
            this.cleaningScheduleBindingSource.DataMember = "CleaningSchedule";
            this.cleaningScheduleBindingSource.DataSource = this.hotelManagement_DataSet;
            // 
            // hotelManagement_DataSet
            // 
            this.hotelManagement_DataSet.DataSetName = "HotelManagement_DataSet";
            this.hotelManagement_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cleaningScheduleTableAdapter
            // 
            this.cleaningScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelManagement_DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "Rooms";
            this.roomsBindingSource1.DataSource = this.hotelManagement_DataSet;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(30, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 47);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.panelInfo.Location = new System.Drawing.Point(30, 89);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RowCount = 6;
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.panelInfo.Size = new System.Drawing.Size(329, 321);
            this.panelInfo.TabIndex = 5;
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(30, 588);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 588);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(30, 446);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(326, 47);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Mark Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnDirty
            // 
            this.btnDirty.Location = new System.Drawing.Point(30, 515);
            this.btnDirty.Name = "btnDirty";
            this.btnDirty.Size = new System.Drawing.Size(326, 47);
            this.btnDirty.TabIndex = 2;
            this.btnDirty.Text = "Mark Dirty";
            this.btnDirty.UseVisualStyleBackColor = true;
            this.btnDirty.Click += new System.EventHandler(this.btnDirty_Click);
            // 
            // cBoxFilter
            // 
            this.cBoxFilter.FormattingEnabled = true;
            this.cBoxFilter.Items.AddRange(new object[] {
            "All",
            "Reserved",
            "Checked-in",
            "Checked-out",
            "Cancelled"});
            this.cBoxFilter.Location = new System.Drawing.Point(957, 37);
            this.cBoxFilter.Name = "cBoxFilter";
            this.cBoxFilter.Size = new System.Drawing.Size(121, 28);
            this.cBoxFilter.TabIndex = 6;
            this.cBoxFilter.SelectedIndexChanged += new System.EventHandler(this.cBoxFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(903, 45);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(48, 20);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter:";
            // 
            // frm_hk_room_manager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1108, 664);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cBoxFilter);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDirty);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView_CleaningSchedule);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_hk_room_manager";
            this.Text = "frm_hk_room_manager";
            this.Load += new System.EventHandler(this.frm_hk_room_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CleaningSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagement_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HotelManagement_DataSet hotelManagement_DataSet;
        private System.Windows.Forms.BindingSource cleaningScheduleBindingSource;
        private HotelManagement_DataSetTableAdapters.CleaningScheduleTableAdapter cleaningScheduleTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelManagement_DataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView_CleaningSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housekeepingidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleaningdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel panelInfo;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_RoomNo;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lblIDNum;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDirty;
        private System.Windows.Forms.Label lbl_Assigned;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblHousekeepers;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cBoxBookingStatus;
        private System.Windows.Forms.ComboBox cBoxFilter;
        private System.Windows.Forms.Label lblFilter;
    }
}