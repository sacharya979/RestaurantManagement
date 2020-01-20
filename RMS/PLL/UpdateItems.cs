
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
    public partial class UpdateItems : Form
    {
        
        public UpdateItems()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdateFoodItem_Click(object sender, EventArgs e)
        {
            //update the food item information 
            //int id = Convert.ToInt32(txtItemID.Text);
            //tbl_fooditems wt = db.tbl_fooditems.Where(x => x.Id == id).SingleOrDefault();
            //wt.FoodName = txtFoodName.Text;
            //wt.Price = txtPrice.Text;
            //wt.Discount = txtDiscount.Text;
            //db.SaveChanges();
            //MessageBox.Show("Data has been Updated Successfully");
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(txtItemID.Text);
            //tbl_fooditems wt = db.tbl_fooditems.Where(x => x.Id == id).SingleOrDefault();
            //if (wt != null)
            //{
            //    txtCategoryName.Text = wt.CategoryName;
            //    txtFoodName.Text = wt.FoodName;
            //    txtPrice.Text = wt.Price;
            //    if (wt.Status == 1)
            //    {
            //        radioBtnActive.Checked = true; 
            //    }
            //    else
            //    {
            //        radioBtnActive.Checked = true;
            //    }
            //    txtDiscount.Text = wt.Discount;
            //    if (chkIsSpecial.Checked==true)
            //    {
            //        wt.IsSpecial = 1;
            //    }
            //    else
            //    {
            //        wt.IsSpecial = 0;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No records were found");
            //}

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

        }
    }
}
