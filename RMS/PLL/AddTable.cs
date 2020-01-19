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
    public partial class AddTable : Form
    {
        DBEntities db = new DBEntities();
        public AddTable()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbl_table model = new tbl_table();
            model.TableNumber = txtTableNumber.Text.Trim();
            model.AddedDate = DateTime.Today;
            using (DBEntities db = new DBEntities())
            {
                db.tbl_table.Add(model);

                db.SaveChanges();
            }
            MessageBox.Show("Table Added Successfully");
            this.DialogResult = DialogResult.OK;

        }

        private void AddTable_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
