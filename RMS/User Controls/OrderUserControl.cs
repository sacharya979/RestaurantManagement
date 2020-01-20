using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.User_Controls
{
    public partial class OrderUserControl : UserControl
    {
        public OrderUserControl()
        {
            InitializeComponent();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            //NewOrder afc = new NewOrder();
            //MainControlClass.showControl(afc, panelMainContainer);

        }

        private void OrderUserControl_Load(object sender, EventArgs e)
        {
            //NewOrder afc = new NewOrder();
            //MainControlClass.showControl(afc, panelMainContainer);
        }

        private void btnOngoingOrder_Click(object sender, EventArgs e)
        {
            //OngoingOrder afc = new OngoingOrder();
            //MainControlClass.showControl(afc, panelMainContainer);
        }
    }
}
