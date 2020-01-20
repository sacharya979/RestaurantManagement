using BLL;
using BO;
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
    public partial class AddTable : Form
    {
      
        public AddTable()
        {
            InitializeComponent();
        }
        BLLTable blt = new BLLTable();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTableNumber.Text == "")
            {
                MessageBox.Show("Please Enter Table Number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTableNumber.Focus();
                return;
            }

            TableDetails td = new TableDetails();
            td.TableNumber = txtTableNumber.Text;

            bool isexists = blt.CheckTable(txtTableNumber.Text);
            if (isexists)
            {
                MessageBox.Show("Table Number Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTableNumber.Text = "";
                txtTableNumber.Focus();
            }
            else
            {
                int i = blt.AddNewTable(td);
                if (i > 0)
                {
                   
                    MessageBox.Show("New Table Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTableNumber.Text = "";
                    txtTableNumber.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
