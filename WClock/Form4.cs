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
    public partial class Form4 : Form
    {
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand read;
            String eve = "Table";
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
            SqlCommand cmd = new SqlCommand("insert into[" + eve + "] values(@counterid ,'" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text.ToString()+ "' )", cn);
            cmd.Parameters.Add(new SqlParameter(@"counterid", counterid));
            Console.WriteLine(cmd);
            cmd.ExecuteNonQuery();

            cn.Close();
            textBox1.Text = "";
            MessageBox.Show("Contact Inserted Successfully.");
        }
    }
}
