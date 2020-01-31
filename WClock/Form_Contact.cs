using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WClock
{
    public partial class Form_Contact : Form
    {
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        public Form_Contact()
        {
            InitializeComponent();
        }

        private void Form_Contact_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 openForm = new Form5();
            openForm.Show();
        }
        public void display_data()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "select * from [Table_1]";
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(data);
            dataGridView1.DataSource = data;
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display_data();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDeleteContact openForm = new FormDeleteContact();
            openForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
