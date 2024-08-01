using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static OOPAssignmentUI_1.Housekeeping;

namespace OOPAssignmentUI_1
{
    public partial class housekeeper_welcome : Form
    {
        int userId;
        private ManageHousekeeping manager;

        public housekeeper_welcome(int userId = 4)
        {
            InitializeComponent();
            this.userId = userId;
            manager = new ManageHousekeeping();
        }

        private void btn_CleaningSchedule_Click(object sender, EventArgs e)
        {
            frm_hk_room_manager room_manager = new frm_hk_room_manager(userId);
            room_manager.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RequestEquipment_Click(object sender, EventArgs e)
        {
            frm_hk_inventory_manager inventory_manager = new frm_hk_inventory_manager(userId);
            inventory_manager.ShowDialog();
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            frm_hk_profile_edit editProfile = new frm_hk_profile_edit(userId);
            editProfile.ShowDialog();
        }

        private void updateWelcomeMessage(int userId)
        {
            DataRow profileRow = manager.GetUserProfileById(userId);

            if (profileRow != null)
            {
                string name = profileRow["name"].ToString();
                lbl_Welcome.Text = $"Welcome, {name}!";
            }
            else
            {
                MessageBox.Show("No profile found for the provided user ID.");
            }
        }

        private void housekeeper_welcome_Load(object sender, EventArgs e)
        {
            updateWelcomeMessage(userId);
        }
    }
}
