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


namespace WClock
{
    
    public partial class FormDeleteContact : Form
    {
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        public FormDeleteContact()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String table = "Table_1";
                int idNumber = Int32.Parse(textBox1.Text);
                cn.Open();
                Console.WriteLine("yo");
                SqlCommand cmd = new SqlCommand("DELETE FROM [" + table + "] WHERE Id = @idNumber", cn);
                Console.WriteLine("hello");
                cmd.Parameters.Add(new SqlParameter(@"idNumber", idNumber));
                cmd.ExecuteNonQuery();
                //cn.Close();
                textBox1.Text = "";

                MessageBox.Show("Contact Deleted Successfully.");

            }
            catch (Exception ex)
            {

            }
        }

        private void FormDeleteContact_Load(object sender, EventArgs e)
        {

        }
    }
}
