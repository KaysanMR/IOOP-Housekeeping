using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPAssignmentUI_1.Housekeeping;

namespace OOPAssignmentUI_1
{
    public partial class frm_hk_room_manager : Form
    {
        public frm_hk_room_manager()
        {
            InitializeComponent();
        }


        private void frm_hk_room_manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagement_DataSet.CleaningSchedule' table. You can move, or remove it, as needed.
            this.cleaningScheduleTableAdapter.Fill(this.hotelManagement_DataSet.CleaningSchedule);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CleaningSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_CleaningSchedule.SelectedRows.Count > 0)
                try
                {
                    int scheduleId = Convert.ToInt32(dataGridView_CleaningSchedule.SelectedRows[0].Cells["scheduleidDataGridViewTextBoxColumn"].Value);
                    RoomManager manager = new RoomManager();
                    DataRow scheduleRow = manager.GetEntryById(scheduleId);

                    if (scheduleRow != null)
                    {
                        lbl_IDNum.Text = scheduleRow[1].ToString(); 
                        int roomId = Convert.ToInt32(scheduleRow[1]); //room ID

                        DataRow roomRow = manager.GetRoomDetailsById(roomId);

                        if (roomRow != null)
                        {
                            txtRoomNo.Text = roomRow["room_number"].ToString();
                            cBoxType.SelectedItem = roomRow["room_type"].ToString();
                        }

                        cBoxStatus.SelectedItem = scheduleRow[4].ToString();
                        datePicker.Value = Convert.ToDateTime(scheduleRow[3]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching data: {ex.Message}");
                }
        }
    }
}
