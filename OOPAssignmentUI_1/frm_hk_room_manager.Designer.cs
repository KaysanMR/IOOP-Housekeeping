﻿namespace OOPAssignmentUI_1
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
            this.cleaningScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagement_DataSet = new OOPAssignmentUI_1.HotelManagement_DataSet();
            this.cleaningScheduleTableAdapter = new OOPAssignmentUI_1.HotelManagement_DataSetTableAdapters.CleaningScheduleTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new OOPAssignmentUI_1.HotelManagement_DataSetTableAdapters.RoomsTableAdapter();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housekeepingidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_RoomNo = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_IDNum = new System.Windows.Forms.Label();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDirty = new System.Windows.Forms.Button();
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
            this.dataGridView_CleaningSchedule.RowHeadersWidth = 62;
            this.dataGridView_CleaningSchedule.RowTemplate.Height = 28;
            this.dataGridView_CleaningSchedule.Size = new System.Drawing.Size(696, 629);
            this.dataGridView_CleaningSchedule.TabIndex = 0;
            this.dataGridView_CleaningSchedule.SelectionChanged += new System.EventHandler(this.dataGridView_CleaningSchedule_SelectionChanged);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 26);
            this.textBox1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(923, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(30, 26);
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
            this.panelInfo.Controls.Add(this.txtRoomNo, 1, 1);
            this.panelInfo.Controls.Add(this.lbl_ID, 0, 0);
            this.panelInfo.Controls.Add(this.lbl_RoomNo, 0, 1);
            this.panelInfo.Controls.Add(this.lbl_Type, 0, 2);
            this.panelInfo.Controls.Add(this.lbl_Status, 0, 3);
            this.panelInfo.Controls.Add(this.lbl_IDNum, 1, 0);
            this.panelInfo.Controls.Add(this.cBoxType, 1, 2);
            this.panelInfo.Controls.Add(this.cBoxStatus, 1, 3);
            this.panelInfo.Controls.Add(this.lbl_Date, 0, 4);
            this.panelInfo.Controls.Add(this.datePicker, 1, 4);
            this.panelInfo.Location = new System.Drawing.Point(30, 105);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RowCount = 5;
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.panelInfo.Size = new System.Drawing.Size(329, 321);
            this.panelInfo.TabIndex = 5;
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(167, 66);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(159, 26);
            this.txtRoomNo.TabIndex = 0;
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
            this.lbl_RoomNo.Location = new System.Drawing.Point(3, 63);
            this.lbl_RoomNo.Name = "lbl_RoomNo";
            this.lbl_RoomNo.Size = new System.Drawing.Size(80, 20);
            this.lbl_RoomNo.TabIndex = 1;
            this.lbl_RoomNo.Text = "Room No.";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(3, 126);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(43, 20);
            this.lbl_Type.TabIndex = 1;
            this.lbl_Type.Text = "Type";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(3, 189);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(118, 20);
            this.lbl_Status.TabIndex = 1;
            this.lbl_Status.Text = "Booking Status";
            // 
            // lbl_IDNum
            // 
            this.lbl_IDNum.AutoSize = true;
            this.lbl_IDNum.Location = new System.Drawing.Point(167, 0);
            this.lbl_IDNum.Name = "lbl_IDNum";
            this.lbl_IDNum.Size = new System.Drawing.Size(27, 20);
            this.lbl_IDNum.TabIndex = 1;
            this.lbl_IDNum.Text = "00";
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "Single",
            "Twin",
            "Triple",
            "Family"});
            this.cBoxType.Location = new System.Drawing.Point(167, 129);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(159, 28);
            this.cBoxType.TabIndex = 2;
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Completed"});
            this.cBoxStatus.Location = new System.Drawing.Point(167, 192);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(159, 28);
            this.cBoxStatus.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(30, 601);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(155, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 601);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Location = new System.Drawing.Point(30, 671);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(326, 47);
            this.btnNewRequest.TabIndex = 2;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(3, 252);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(110, 20);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Cleaning Date";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(167, 255);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(159, 26);
            this.datePicker.TabIndex = 3;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(30, 459);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(326, 47);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Mark Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // btnDirty
            // 
            this.btnDirty.Location = new System.Drawing.Point(30, 528);
            this.btnDirty.Name = "btnDirty";
            this.btnDirty.Size = new System.Drawing.Size(326, 47);
            this.btnDirty.TabIndex = 2;
            this.btnDirty.Text = "Mark Dirty";
            this.btnDirty.UseVisualStyleBackColor = true;
            // 
            // frm_hk_room_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1110, 750);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNewRequest);
            this.Controls.Add(this.btnDirty);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel panelInfo;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_RoomNo;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_IDNum;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.ComboBox cBoxStatus;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDirty;
    }
}