using System;
using System.Windows.Forms;
using static OOPAssignmentUI_1.Housekeeping;

namespace OOPAssignmentUI_1
{
    public partial class housekeeper_welcome : Form
    {
        int userId = 8;
        public housekeeper_welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_hk_room_manager room_manager = new frm_hk_room_manager(userId);
            room_manager.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_hk_inventory_manager inventory_manager = new frm_hk_inventory_manager();
            inventory_manager.ShowDialog();
        }
    }
}
