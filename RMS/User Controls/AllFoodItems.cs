using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.DAL;
using RMS.PLL;

namespace RMS.User_Controls
{
    public partial class AllFoodItems : UserControl
    {
        DBEntities db = new DBEntities();
        public AllFoodItems()
        {
            InitializeComponent();
        }

        private void AllFoodItems_Load(object sender, EventArgs e)
        {
            getFoodItem();
        }
        public void getFoodItem()
        {
            var tmp = db.view_getfooditems.ToList();
            foodGridView.DataSource = db.view_getfooditems.ToList();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (UpdateItems updItems = new UpdateItems())
            {
                updItems.ShowDialog();
            }
        }

        private void bunifuMetroSearchBox_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
