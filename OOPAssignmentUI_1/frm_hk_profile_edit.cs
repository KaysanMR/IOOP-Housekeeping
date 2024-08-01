using System;
using System.Data;
using System.Windows.Forms;
using static OOPAssignmentUI_1.Housekeeping;

namespace OOPAssignmentUI_1
{
    public partial class frm_hk_profile_edit : Form
    {
        private int userId;
        private ManageHousekeeping manager;

        public frm_hk_profile_edit(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            manager = new ManageHousekeeping();
        }

        private void frm_hk_profile_edit_Load(object sender, EventArgs e)
        {
            PopulateProfileDetails(userId);
        }

        private void PopulateProfileDetails(int userId)
        {
            DataRow profileRow = manager.GetUserProfileById(userId);

            if (profileRow != null)
            {
                txtName.Text = profileRow["name"].ToString();
                txtPhoneNumber.Text = profileRow["phone_number"].ToString();
                txtAddress.Text = profileRow["address"].ToString();
                txtNotes.Text = profileRow["notes"].ToString();
                cBoxGender.SelectedItem = profileRow["gender"].ToString();
                txtNationality.Text = profileRow["nationality"].ToString();
            }
            else
            {
                MessageBox.Show("No profile found for the provided user ID.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string notes = txtNotes.Text;
            string gender = cBoxGender.SelectedItem.ToString();
            string nationality = txtNationality.Text;

            manager.UpdateUserProfile(userId, name, phoneNumber, address, notes, gender, nationality);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
