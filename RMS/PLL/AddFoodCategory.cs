using RMS.DAL;
using RMS.User_Controls;
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
    
    public partial class AddFoodCategory : Form
    {
        DBEntities dbn = new DBEntities();
        tbl_category model = new tbl_category();
        public AddFoodCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.CategoryName = txtCategoryName.Text.Trim();
            model.AddedDate = DateTime.Today;
            using (DBEntities db = new DBEntities())
            {
                db.tbl_category.Add(model);

                db.SaveChanges();
                MessageBox.Show("Category Added Successfully");
            }
            this.DialogResult = DialogResult.OK;
            //AllFoodCategory al = new AllFoodCategory();
            //al.getFoodItem();
            //al.PopulateDataGridView();

            //MessageBox.Show("Category Added Successfully");
            



        }

        
    }
}
