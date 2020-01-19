using System;
using System.Linq;
using System.Windows.Forms;
using RMS.PLL;
using RMS.DAL;
using System.Data.Objects;

namespace RMS.User_Controls
{
    public partial class AllFoodCategory : UserControl
    {
       private DBEntities db = new DBEntities();
        tbl_category model = new tbl_category();
        public AllFoodCategory()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (AddFoodCategory foodcat = new AddFoodCategory())
            {
                if(foodcat.ShowDialog()==DialogResult.OK)
                {
                    PopulateDataGridView();
                }
            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
      public void PopulateDataGridView()
        {
            using (DBEntities db = new DBEntities())
            {
                grdCategory.DataSource = db.tbl_category.ToList<tbl_category>();
                cmbFilter.DataSource = db.tbl_category.ToList();
                cmbFilter.DisplayMember = "CategoryName";
                cmbFilter.ValueMember = "CategoryName";
            }
        }

        public void getFoodItem()
        {
            grdCategory.DataSource = db.tbl_category.ToList();

        }
        private void AllFoodCategory_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void grdCategory_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        public void searchData(string valueToSearch)
        {
           
        }

        private void FilterList(object sender, EventArgs e)
        {
            //String sql = "SELECT id, CategoryName, FoodName, Price from tbl_fooditems";
            //cmbFilter.DataSource = sql;
        }

        private void bunifuMetroTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
