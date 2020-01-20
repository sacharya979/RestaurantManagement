using System;
using System.Linq;
using System.Windows.Forms;
using RMS.PLL;
using System.Data.Objects;
using BO;
using BLL;
using System.Collections.Generic;

namespace RMS.User_Controls
{
    public partial class AllFoodCategory : UserControl
    {
      
        public AllFoodCategory()
        {
            InitializeComponent();

        }
        BLLCategory blc = new BLLCategory();
        private void button4_Click(object sender, EventArgs e)
        {
            AddFoodCategory adf = new AddFoodCategory();
             adf.Show();
           

            //if (adf.ShowDialog() == DialogResult.OK)
            //{
            //    LoadGrid();
            //}

        }
        private void LoadGrid()
        {
            List<CategoryDetails> lstcd = blc.GetAllCategory();
            grdCategory.DataSource = lstcd;
        }

       
        private void AllFoodCategory_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public int categoryId = 0;
        private void grdCategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryId = Convert.ToInt32(grdCategory.CurrentRow.Cells[0].Value.ToString());

            //this.Hide();
            var category = blc.GetAllCategory().Where(s => s.Id == categoryId).FirstOrDefault();
            AddFoodCategory frm = new AddFoodCategory();
            frm.Show();
            frm.txtCategoryName.Text = category.CategoryName;
            frm.btnUpdate.Visible = true;
            frm.btnUpdate.Enabled = true;
            frm.btnSave.Enabled = false;
            frm.btnSave.Visible = false;
            
        }
    }
}
