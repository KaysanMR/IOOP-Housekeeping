using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPAssignmentUI_1.Housekeeping;

namespace OOPAssignmentUI_1
{
    public partial class frm_hk_room_manager : Form
    {
        private int userId;

        public frm_hk_room_manager(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void frm_hk_room_manager_Load(object sender, EventArgs e)
        {
            cBoxFilter.SelectedIndex = 0;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            string filterSelection = cBoxFilter.Text;
            ManageHousekeeping manager = new ManageHousekeeping();
            dataGridView_CleaningSchedule.DataSource = manager.GetCleaningScheduleForUser(userId, filterSelection);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CleaningSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_CleaningSchedule.SelectedRows.Count > 0)
            {
                try
                {
                    int scheduleId = Convert.ToInt32(dataGridView_CleaningSchedule.SelectedRows[0].Cells["scheduleidDataGridViewTextBoxColumn"].Value);
                    ManageHousekeeping manager = new ManageHousekeeping();
                    DataRow scheduleRow = manager.GetEntryById(scheduleId);

                    if (scheduleRow != null)
                    {
                        lblIDNum.Text = scheduleRow[1].ToString();
                        int roomId = Convert.ToInt32(scheduleRow[1]);
                        int housekeeperId = Convert.ToInt32(scheduleRow[1]);

                        DataRow roomRow = manager.GetRoomDetailsById(roomId);

                        if (roomRow != null)
                        {
                            lblRoomNo.Text = roomRow["room_number"].ToString();
                            lblType.Text = roomRow["room_type"].ToString();
                        }

                        // Fetch reservation details
                        DataRow reservationRow = manager.GetReservationDetailsById(scheduleId);
                        if (reservationRow != null)
                        {
                            cBoxBookingStatus.SelectedItem = reservationRow["status"].ToString();
                        }

                        string housekeeperName = manager.GetUserNameByHousekeepingId(housekeeperId);
                        lblHousekeepers.Text = housekeeperName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching data: {ex.Message}");
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (dataGridView_CleaningSchedule.SelectedRows.Count > 0)
            {
                int scheduleId = Convert.ToInt32(dataGridView_CleaningSchedule.SelectedRows[0].Cells[0].Value);
                ManageHousekeeping manager = new ManageHousekeeping();
                manager.MarkClean(scheduleId);
                RefreshGrid();
            }
        }

        private void btnDirty_Click(object sender, EventArgs e)
        {
            if (dataGridView_CleaningSchedule.SelectedRows.Count > 0)
            {
                int scheduleId = Convert.ToInt32(dataGridView_CleaningSchedule.SelectedRows[0].Cells[0].Value);
                ManageHousekeeping manager = new ManageHousekeeping();
                manager.MarkDirty(scheduleId);
                RefreshGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblIDNum.Text, out int scheduleId))
            {
                DateTime cleaningDate = datePicker.Value;
                string status = cBoxBookingStatus.SelectedItem.ToString();

                ManageHousekeeping manager = new ManageHousekeeping();
                manager.EditEntry(scheduleId, cleaningDate, status);
                RefreshGrid();
            }
            else
            {
                // Conversion failed; handle the error
                MessageBox.Show("Please select an entry to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_CleaningSchedule.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected entry?",
                                                      "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int scheduleId = Convert.ToInt32(dataGridView_CleaningSchedule.SelectedRows[0].Cells[0].Value);
                        ManageHousekeeping manager = new ManageHousekeeping();
                        manager.DeleteEntry(scheduleId, isCleaningSchedule: true);
                        RefreshGrid();
                        MessageBox.Show("Entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an entry to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }

}
