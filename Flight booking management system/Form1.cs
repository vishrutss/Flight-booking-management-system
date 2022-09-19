using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_booking_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Uname = "username", Upass = "password", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(Uname) && pass.Equals(Upass))
            {
                Form2 obj = new Form2();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect");
            }
        }
    }
    }

