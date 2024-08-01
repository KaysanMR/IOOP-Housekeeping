using System;
using System.Windows.Forms;
using static OOPAssignmentUI_1.Housekeeping;

namespace OOPAssignmentUI_1
{
    public partial class frm_hk_inventory_request : Form
    {
        private int userId;
        private ManageHousekeeping manager;

        public frm_hk_inventory_request(int userId)
        {
            this.userId = userId;
            InitializeComponent();
            manager = new ManageHousekeeping();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            int itemQuantity = (int)numQuantity.Value;

            if (string.IsNullOrWhiteSpace(itemName) || itemQuantity <= 0)
            {
                MessageBox.Show("Please provide valid item details.");
                return;
            }

            string confirmationMessage = $"Are you sure you want to add the following item request?\n\n";
            confirmationMessage += $"Item Name: {itemName}\n";
            confirmationMessage += $"Quantity: {itemQuantity}";

            DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                manager.NewItemRequest(userId, itemName, itemQuantity);
                MessageBox.Show("Item request successfully added.");
                // Optionally, you can clear the input fields after successful addition
                txtItemName.Clear();
                numQuantity.Value = 1;
            }
        }
    }
}
