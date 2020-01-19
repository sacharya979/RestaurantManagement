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
    public partial class SplashScreen : Form
    {
        int move = 0;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Width += 2;
            if (panelSlide.Width> 500)
            {
                panelSlide.Width = 0;

            }
            if (panelSlide.Width<0)
            {
                move = 2;
               
            }
           
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
