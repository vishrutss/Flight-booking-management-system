using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Flight_booking_management_system
{


    public partial class Flight_UserControl : UserControl
    {
        private static Flight_UserControl _instance;
        public static Flight_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Flight_UserControl();
                }
                return _instance;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

        public Flight_UserControl()
        {
            InitializeComponent();
        }

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowFlightData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Operation\n" + ex);
                }
                con.Close();
                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("FlightAdd_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@Ph", textBox2.Text);
            cmd.Parameters.AddWithValue("@Destination", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Origin", comboBox1.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Operation\n" + ex);
            }
            con.Close();
            refresh_DataGridView();
        }

        private void Flight_UserControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
