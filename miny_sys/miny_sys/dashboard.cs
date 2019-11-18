using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miny_sys
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
          
            lblDate.Text = DateTime.Now.ToString(DateTime.Now.Day.ToString() + " MMMM, " + DateTime.Now.Year.ToString() + "  -  " + "dddd");
            lblTime.Text = DateTime.Now.ToShortTimeString();

            //28-Month,year-day
            if (DateTime.Now.Hour < 12) lblDayEvent.Text = "صباح الخير";
            else lblDayEvent.Text = "مساء الخير";
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            budget Objbudget = new budget();
            Objbudget.ShowDialog();
        }

        private void dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {//System.Windows.Forms.Application.Exit();
            System.Environment.Exit(0);
        }
    }
}
