
using BLL;
using BO;
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

        public AddFoodCategory()
        {
            InitializeComponent();
        }
        BLLCategory blc = new BLLCategory();
        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }
        private void LoadGrid()
        {
            AllFoodCategory afc = new AllFoodCategory();
            List<CategoryDetails> lstcd = blc.GetAllCategory();
            afc.grdCategory.DataSource = lstcd;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Category Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }

            CategoryDetails cd = new CategoryDetails();
            cd.CategoryName = txtCategoryName.Text;
            cd.AddedDate = System.DateTime.Now;

            bool isexists = blc.CheckCategory(txtCategoryName.Text);
            if (isexists)
            {
                MessageBox.Show("Category Already Exists in Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Text = "";
                txtCategoryName.Focus();
            }
            else
            {
                int i = blc.AddNewCategory(cd);
                if (i > 0)
                {
                    LoadGrid();
                    MessageBox.Show("New Category Added Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtCategoryName.Text = "";
                    txtCategoryName.Focus();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Category Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoryName.Focus();
                return;
            }         
                CategoryDetails cd = new CategoryDetails();
                cd.CategoryName = txtCategoryName.Text;
                cd.AddedDate = System.DateTime.Now;

                bool isexists = blc.CheckCategory(txtCategoryName.Text);
                if (isexists)
                {
                    MessageBox.Show("Category Already Exists in Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCategoryName.Text = "";
                    txtCategoryName.Focus();
                }
                else
                {
                    int i = blc.UpdateCategory(cd);
                    if (i > 0)
                    {

                        MessageBox.Show("Category Updated Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategoryName.Text = "";
                        txtCategoryName.Focus();
                    }
                }
            
        }
    }
}
