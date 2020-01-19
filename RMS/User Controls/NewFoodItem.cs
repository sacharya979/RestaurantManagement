using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using RMS.DAL;
using System.IO;

namespace RMS.User_Controls
{
    public partial class NewFoodItem : UserControl
    {
        DBEntities db = new DBEntities();

        public NewFoodItem()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewFoodItem_Load(object sender, EventArgs e)
        {
            List<tbl_category> li = db.tbl_category.OrderBy(x => x.Id).ToList();
            cmbCategoryName.DataSource = li;
            cmbCategoryName.DisplayMember = "CategoryName";
            cmbCategoryName.ValueMember = "CategoryName";
            getFoodItem();
        }
        public void getFoodItem()
        {
            foodGridView.DataSource = db.view_getfooditems.ToList();



        }

        private void btnRadioInactive_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddFoodItems_Click(object sender, EventArgs e)
        {
            if (labelForImage.Text.Equals("-1"))
            {
                MessageBox.Show("Please upload the image ....");
            }
            else
            {
                tbl_fooditems foi = new tbl_fooditems();
                foi.CategoryName = cmbCategoryName.SelectedValue.ToString();
                foi.FoodName = txtFoodName.Text.Trim();
                foi.Price = txtPrice.Text.Trim();
                if (btnRadioActive.Checked)
                {

                    foi.Status = 1;
                }
                else
                {
                    foi.Status = 0;

                }
                if (isSpecialCheckBox.Checked)
                {
                    foi.IsSpecial = 1;
                }
                else
                {
                    foi.IsSpecial = 0;
                }
                foi.Discount = txtDiscount.Text.Trim();
                foi.ImageUrl = labelForImage.Text.Trim();
                db.tbl_fooditems.Add(foi);
                db.SaveChanges();
                MessageBox.Show("Food Items Added Successfully");
                getFoodItem();
            }
        }

        private void btnRadioActive_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.FileName;
                    File.Copy(iName, Path.Combine(@"../../Resources", Path.GetFileName(iName)));
                    pictureBox1.Image = new Bitmap(opFile.OpenFile());
                    labelForImage.Text = "../../Resources" + Path.GetFileName(iName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open file " + ex.Message);

                    labelForImage.Text = "-1";

                    throw;
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void foodGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
