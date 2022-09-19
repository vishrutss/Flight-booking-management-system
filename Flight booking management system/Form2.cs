using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Flight_booking_management_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        public void expandSlidingPanelGUI()
        {
            //gui for expanding

        }
        bool isSlidingPanelExpanded;
        const int MaxSliderWidth=150;
        const int MinSliderWidth=80;

        private void SlidingButton_Click(object sender, EventArgs e)
        {
            if(isSlidingPanelExpanded)
            {
                //retract panel
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //retract panel
                SlidingPanel.Width -= 30;
                if(SlidingPanel.Width<=MinSliderWidth)
                {
                    //stop retract
                    isSlidingPanelExpanded = false;
                    timer1.Stop();
                    this.Refresh();
                }              
            }
            else
            {
                //expand panel
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    isSlidingPanelExpanded = true;
                    timer1.Stop();
                    this.Refresh();
                }
            }
        }

        private void bookTicketsButton_Click(object sender, EventArgs e)
        {
            if (! ContentPanel.Controls.Contains(Flight_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Flight_UserControl.Instance);
                Flight_UserControl.Instance.Dock = DockStyle.Fill;
                Flight_UserControl.Instance.BringToFront();
            }
            else
            {
                Flight_UserControl.Instance.BringToFront();
            }
        }

        private void CancelTicketsButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Cancel_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Cancel_UserControl.Instance);
                Cancel_UserControl.Instance.Dock = DockStyle.Fill;
                Cancel_UserControl.Instance.BringToFront();
            }
            else
            {
                Cancel_UserControl.Instance.BringToFront();
            }
        }
    }
}
