using RMS.DAL;
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
    public partial class FinalDashboard : Form
    {
        public FinalDashboard()
        {
            InitializeComponent();
            customizeDesign();
            sidePanel.Height = btnOrder.Height;
            sidePanel.Top = btnOrder.Top;
        }
        private void customizeDesign()
        {
            panelFoodItems.Visible = false;
            panelUserSlideMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelFoodItems.Visible == true)
                panelFoodItems.Visible = false;
            if (panelUserSlideMenu.Visible == true)
                panelUserSlideMenu.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { }


        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //normalises window
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }

            //maximises window
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFoodItems_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFoodItems);
            sidePanel.Height = btnFoodItems.Height;
            sidePanel.Top = btnFoodItems.Top;


        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panelMainContainer.BringToFront();
            sidePanel.Height = btnTable.Height;
            sidePanel.Top = btnTable.Top;
            Table sr = new Table();
            MainControlClass.showControl(sr, panelMainContainer);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            sidePanel.Height = btnStaff.Height;
            sidePanel.Top = btnStaff.Top;
            WaiterUC waf = new WaiterUC();
            MainControlClass.showControl(waf, panelMainContainer);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserSlideMenu);
            sidePanel.Height = btnUser.Height;
            sidePanel.Top = btnUser.Top;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            LoginForm objLogin = new LoginForm();
            objLogin.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            sidePanel.Height = btnOrder.Height;
            sidePanel.Top = btnOrder.Top;
            OrderUserControl afc = new OrderUserControl();
            MainControlClass.showControl(afc, panelMainContainer);
            btnAllFoodCategory.ForeColor = Color.Red;


        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            sidePanel.Height = btnSales.Height;
            sidePanel.Top = btnSales.Top;
            SalesReport sr = new SalesReport();
            MainControlClass.showControl(sr, panelMainContainer);
        }

        private void FinalDashboard_Load(object sender, EventArgs e)
        {
            OrderUserControl afc = new OrderUserControl();
            MainControlClass.showControl(afc, panelMainContainer);
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            using (ChangePassword chPw = new ChangePassword())
            {
                chPw.ShowDialog();
            }
        }

        private void panelMiddle_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void btnAllFoodCategory_Click(object sender, EventArgs e)
        {
            AllFoodCategory afc = new AllFoodCategory();
            MainControlClass.showControl(afc, panelMainContainer);
            btnAllFoodCategory.ForeColor = Color.Red;
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenuMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUserSlideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFoodItems_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            AllFoodItems nf = new AllFoodItems();
            MainControlClass.showControl(nf, panelMainContainer);
            btnAllFoodItems.ForeColor = Color.Red;
            buttonNewFoodItem.ForeColor = Color.White;
            btnAllFoodCategory.ForeColor = Color.White;
        }

        private void btnNewFoodItem_Click(object sender, EventArgs e)
        {
            NewFoodItem nf = new NewFoodItem();
            MainControlClass.showControl(nf, panelMainContainer);
            buttonNewFoodItem.ForeColor = Color.Red;
            btnAllFoodCategory.ForeColor = Color.White;

        }

        private void allFoodCategory1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelMainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void waiterUC1_Load(object sender, EventArgs e)
        {

        }

        private void salesReport1_Load(object sender, EventArgs e)
        {

        }

        private void orderUserControl1_Load(object sender, EventArgs e)
        {

        }
    
    }
    
}
