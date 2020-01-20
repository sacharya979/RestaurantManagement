
using RMS.PLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Threading;
namespace RMS
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            /*Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(3000);
            trd.Abort();*/
           
            InitializeComponent();
        }

        private void formRun()
        {
           /* Application.Run(new SplashScreen());*/
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            //String sql = "Select * from Userdetail where Username='" + txtUserName.Text.Trim() + "' and password='" + txtPassword.Text.Trim() + "'";
            //DataTable dtbl = new DataTable();
            //dtbl = DBConnection.gettablebyquery(sql);

            //if (dtbl.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dtbl.Rows.Count; i++)
            //    {

            //        MessageBox.Show("You are login as" + dtbl.Rows[i][5]);
            //        FinalDashboard objDashboard = new FinalDashboard();
            //        objDashboard.Show();
            //        this.Hide();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Check your username and password");
            //}
        }

    }
}


