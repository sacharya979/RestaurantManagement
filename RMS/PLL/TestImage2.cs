using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RMS.PLL
{
    public partial class TestImage2 : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source=.;Initial Catalog=RMS;Integrated Security=True");
        MySqlCommand command;
        MySqlDataAdapter da;

        public TestImage2()
        {
            InitializeComponent();

        }

        private void TestImage2_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM tbl_image.picture";
            command = new MySqlCommand(selectQuery, connection);
            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.AllowUserToAddRows = false;

            da.Fill(table);

            dataGridView1.DataSource = table;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            da.Dispose();
        }
    }
}
