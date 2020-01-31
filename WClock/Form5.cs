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
    public partial class Form5 : Form
    {
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand read;
            string eve = "Table_1";
            cn.Open();
            read = new SqlCommand("SELECT MAX(Id) FROM " + eve, cn);
            int counterid = 0;
            try
            {
                counterid = Convert.ToInt32(read.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            {
  
            }
            Console.WriteLine(counterid);
            counterid = counterid + 1;
            //SqlCommand cmd = new SqlCommand("insert into[EventTable](Id,Title,Start,End) values(@counterid ,'" + textBox1.Text + "', '" + d1.ToString("HH:mm:ss") + "','" + d2.ToString("HH:mm:ss") + "' )", cn);
            SqlCommand cmd = new SqlCommand("insert into[" + eve + "] values(@counterid ,'" + textBox1.Text + "', '" + textBox2.Text + "', '" +textBox3.Text + "' )", cn);
            cmd.Parameters.Add(new SqlParameter(@"counterid", counterid));
            Console.WriteLine(cmd);
            cmd.ExecuteNonQuery();

            cn.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("Contact Inserted Successfully.");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
