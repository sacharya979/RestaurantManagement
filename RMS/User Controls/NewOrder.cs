using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;

namespace RMS.User_Controls
{
    public partial class NewOrder : UserControl
    {
       
    
        public NewOrder()
        {
        //view_getfooditems vf = new view_getfooditems();
        InitializeComponent();
            showData();

        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
          //List<tbl_category> li = db.tbl_category.OrderBy(x => x.Id).ToList();

          //  cmbCategoryName.DataSource = li;
          //  cmbCategoryName.DisplayMember = "CategoryName";
          //  cmbCategoryName.ValueMember = "CategoryName";

          //  List<tbl_waiter> lis = db.tbl_waiter.OrderBy(x => x.WaiterID).ToList();
          //  cmbWaiter.DataSource = lis;
          //  cmbWaiter.DisplayMember = "WaiterName";
          //  cmbWaiter.ValueMember = "WaiterName";

          //  List<tbl_table> tb = db.tbl_table.OrderBy(x => x.Id).ToList();
          //  cmbTable.DataSource = tb;
          //  cmbTable.DisplayMember = "TableNumber";
          //  cmbTable.ValueMember = "TableNumber";
          //  showData();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbWaiter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void showData()
        {
            //var tmp = db.view_getfooditems.ToList();
            

            //DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            //imageCol.HeaderText = "Image";
            //imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
           

        }

        private void bunifuTextbox1_OnValueChange(object sender, EventArgs e)
        {
            //var data = db.tbl_fooditems.Where(a => a.FoodName.StartsWith(bunifuTextbox1.Text)).ToList();
            
          
    



        }
    }

    
}
