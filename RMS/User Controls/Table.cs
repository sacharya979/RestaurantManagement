using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.PLL;
using BO;
using BLL;

namespace RMS.User_Controls
{
    public partial class Table : UserControl
    {

        public Table()
        {
            InitializeComponent();
        }
        BLLTable blt = new BLLTable();
        private void btnNew_Click(object sender, EventArgs e)
        {
            AddTable tbl = new AddTable();
            if (tbl.ShowDialog() == DialogResult.OK)
            {
                LoadGrid();
            }
        }
        private void LoadGrid()
        {
            List<TableDetails> lsttable = blt.GetAllTables();
            grdTable.DataSource = lsttable;
        }
        
        //public void PopulateDataGridView()
        //{
        //    using (DBEntities db = new DBEntities())
        //    {
        //        grdTable.DataSource = db.tbl_table.ToList<tbl_table>();
        //    }
        //}

        //public void getFoodItem()
        //{
        //    grdTable.DataSource = db.tbl_table.ToList();

        //}

        //private void Table_Load(object sender, EventArgs e)
        //{
        //    PopulateDataGridView();
        //}

        //private void grdTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    PopulateDataGridView();
        //}

        //private void grdTable_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    PopulateDataGridView();
        //}
    }
}
