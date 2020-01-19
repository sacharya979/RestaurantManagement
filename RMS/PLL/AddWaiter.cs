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
using RMS.User_Controls;

namespace RMS.PLL
{

    public partial class AddWaiter : Form
    {
        DBEntities db = new DBEntities();
        public AddWaiter()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl_waiter foi = new tbl_waiter();
            foi.WaiterName = txtWaiterName.Text.Trim();
            foi.WaiterContact = txtContact.Text.Trim();
            foi.WaiterAddress = txtAddress.Text.Trim();
            db.tbl_waiter.Add(foi);
            db.SaveChanges();
            MessageBox.Show("New Waiter has been added Successfully");
            this.DialogResult = DialogResult.OK;
        }
        

        private void AddWaiter_Load(object sender, EventArgs e)
        {
         
        }
    }
}
