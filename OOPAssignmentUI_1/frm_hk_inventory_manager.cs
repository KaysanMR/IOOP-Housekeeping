using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OOPAssignmentUI_1.Housekeeping;

namespace OOPAssignmentUI_1
{
    public partial class frm_hk_inventory_manager : Form
    {

        private int userId;

        public frm_hk_inventory_manager(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void frm_hk_inventory_manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagement_DataSet.SuppliesRequest' table. You can move, or remove it, as needed.
            this.suppliesRequestTableAdapter.Fill(this.hotelManagement_DataSet.SuppliesRequest);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            ManageHousekeeping manager = new ManageHousekeeping();
            dataGridView_ItemRequest.DataSource = manager.GetAllSupplyRequests();
        }

        private void dataGridView_ItemRequest_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_ItemRequest.SelectedRows.Count > 0)
            {
                try
                {
                    int requestId = Convert.ToInt32(dataGridView_ItemRequest.SelectedRows[0].Cells["requestIdDataGridViewTextBoxColumn"].Value);
                    ManageHousekeeping manager = new ManageHousekeeping();
                    DataRow requestRow = manager.GetSupplyRequestById(requestId);

                    if (requestRow != null)
                    {
                        lblIDNum.Text = requestRow["request_id"].ToString();
                        txtItemName.Text = requestRow["item_name"].ToString();
                        numQuantity.Value = Convert.ToInt32(requestRow["quantity"]);
                        cBoxStatus.SelectedItem = requestRow["status"].ToString();
                        int housekeeperId = Convert.ToInt32(requestRow["housekeeping_id"]);

                        string housekeeperName = manager.GetUserNameByHousekeepingId(housekeeperId);
                        lblRequestedBy.Text = housekeeperName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching data: {ex.Message}");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblIDNum.Text, out int id))
            {
                DateTime? cleaningDate = null;
                string status = cBoxStatus.SelectedItem.ToString();
                string itemName = txtItemName.Text;
                int? quantity = (int)numQuantity.Value;

                ManageHousekeeping manager = new ManageHousekeeping();
                manager.EditEntry(id, cleaningDate, status, itemName, quantity);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please select an entry to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblIDNum.Text, out int id))
            {
                ManageHousekeeping manager = new ManageHousekeeping();
                manager.DeleteEntry(id, isCleaningSchedule: false); // Set to true for CleaningSchedule entries
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please select an entry to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewRequest_Click(object sender, EventArgs e)
        {
            frm_hk_inventory_request inventory_Request = new frm_hk_inventory_request(userId);
            inventory_Request.ShowDialog();
            RefreshGrid();
        }
    }
}
