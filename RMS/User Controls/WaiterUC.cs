using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.PLL;
using RMS.DAL;

namespace RMS.User_Controls
{
    public partial class WaiterUC : UserControl
    {
        tbl_waiter model = new tbl_waiter();
        public WaiterUC()
        {
            InitializeComponent();
        }

        private void btnAddNewWaiter_Click(object sender, EventArgs e)
        {
            using (AddWaiter foodcat = new AddWaiter())
            {
                if (foodcat.ShowDialog() == DialogResult.OK)
                {
                    PopulateDataGridView();
                }
            }
            }
        void PopulateDataGridView()
        {
            using (DBEntities db = new DBEntities())
            {
                grdWaiterList.DataSource = db.tbl_waiter.ToList<tbl_waiter>();
            }
        }

        private void WaiterUC_Load(object sender, EventArgs e)
        {

            // loadStudentCombo();
        }

        private void grdWaiterList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        private void ShowData()
        {
            PopulateDataGridView();
        }

        private void grdWaiterList_Click(object sender, EventArgs e)
        {
            
        }

        private void WaiterUC_Load_1(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (UpdateWaiter upduser = new UpdateWaiter())
            {
                upduser.ShowDialog();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
