using RMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.PLL
{
    public partial class UpdateWaiter : Form
    {
        DBEntities db = new DBEntities();
        public UpdateWaiter()
        {
            InitializeComponent();
        }

        private void UpdateWaiter_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtWaiterID.Text);
            tbl_waiter wt = db.tbl_waiter.Where(x => x.WaiterID ==id).SingleOrDefault();
            if (wt!=null)
            {
                txtWaiterName.Text = wt.WaiterName;
                txtContact.Text = wt.WaiterContact;
                txtAddress.Text = wt.WaiterAddress;
            }
            else
            {
                MessageBox.Show("No records were found");
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update the waiter information 
            int id = Convert.ToInt32(txtWaiterID.Text);
            tbl_waiter wt = db.tbl_waiter.Where(x => x.WaiterID ==id).SingleOrDefault();
            wt.WaiterName = txtWaiterName.Text;
            wt.WaiterContact = txtContact.Text;
            wt.WaiterAddress = txtAddress.Text;
            db.SaveChanges();
            MessageBox.Show("Data has been Updated Successfully");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        
        }
    }
}
