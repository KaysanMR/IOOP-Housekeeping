using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAssignmentUI_1
{
    public partial class frm_hk_inventory_manager : Form
    {
        public frm_hk_inventory_manager()
        {
            InitializeComponent();
        }

        private void frm_hk_inventory_manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagement_DataSet.SuppliesRequest' table. You can move, or remove it, as needed.
            this.suppliesRequestTableAdapter.Fill(this.hotelManagement_DataSet.SuppliesRequest);

        }
    }
}
