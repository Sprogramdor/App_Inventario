using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos_y_botones
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        Timer tmr;
        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            iManager mf = new iManager();

            mf.Show();

            //hide this form

            this.Hide();

        }


        private void splash_Shown(object sender, EventArgs e)
        {
            //Use timer class

      

           

                tmr = new Timer();

                //set time interval 5 sec

                tmr.Interval = 8000;

                //starts the timer

                tmr.Start();

                tmr.Tick += tmr_Tick;

            

           
        }







    }
}
