
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BO;
using RMS.User_Controls;

namespace RMS.PLL
{

    public partial class AddWaiter : Form
    {
        
        public AddWaiter()
        {
            InitializeComponent();

        }
        BLLWaiter blw = new BLLWaiter();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtWaiterName.Text == "")
            {
                MessageBox.Show("Please Enter Waiter Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWaiterName.Focus();
                return;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Please Enter Waiter Contact Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Waiter Address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            WaiterDetails wd = new WaiterDetails();
            wd.WaiterName = txtWaiterName.Text;
            wd.WaiterContact = txtContact.Text;
            wd.WaiterAddress = txtAddress.Text;

            bool isexists = blw.CheckContact(txtContact.Text);
            if (isexists)
            {
                MessageBox.Show("Waiter Already Exists in Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact.Text = "";
                txtContact.Focus();
            }
            else
            {
                int i = blw.AddNewWaiter(wd);
                if (i > 0)
                {

                    MessageBox.Show("New Waiter Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtWaiterName.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtWaiterName.Focus();
                }
            }
        }       
    }
}
