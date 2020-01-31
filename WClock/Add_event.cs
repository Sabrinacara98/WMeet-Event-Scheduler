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
    
    public partial class Add_event : Form
    {
        string Day;
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\sabri\\Desktop\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        public Add_event(string str)
        {
            InitializeComponent();
            label4.Text = str;
            Day = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Add_event_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_event_Click(object sender, EventArgs e)
        {

            SqlCommand read;
            String eve = "";
            if (Day == "Monday")
            {
                eve = "EventTable";
            }
            else if (Day == "Tuesday")
            {
                eve = "EventTuesday";
            }
            else if (Day == "Wednesday")
            {
                eve = "EventWednesday";
            }
            else if (Day == "Thursday")
            {
                eve = "EventThursday";
            }
            else if (Day == "Friday")
            {
                eve = "EventFriday";
            }
            else if (Day == "Saturday")
            {
                eve = "EventSaturday";
            }
            else if (Day == "Sunday")
            {
                eve = "EventSunday";
            }

            cn.Open();
            read = new SqlCommand("SELECT MAX(Id) FROM "+ eve, cn);
            int counterid = 0;
            try
            {
                counterid = Convert.ToInt32(read.ExecuteScalar().ToString());
            }
            catch(Exception ex)
            {

            }
            Console.WriteLine(counterid);
            counterid = counterid + 1;
            DateTime d1 = DateTime.Parse(this.dateTimePicker1.Text);
            DateTime d2 = DateTime.Parse(this.dateTimePicker2.Text);
            //SqlCommand cmd = new SqlCommand("insert into[EventTable](Id,Title,Start,End) values(@counterid ,'" + textBox1.Text + "', '" + d1.ToString("HH:mm:ss") + "','" + d2.ToString("HH:mm:ss") + "' )", cn);
            SqlCommand cmd = new SqlCommand("insert into["+ eve + "] values(@counterid ,'" + textBox1.Text + "', '" + d1.ToString("HH:mm:ss") + "', '" + d2.ToString("HH:mm:ss") + "', '" + textBox2.Text + "' )", cn);
            cmd.Parameters.Add(new SqlParameter(@"counterid", counterid));
            Console.WriteLine(cmd);
            cmd.ExecuteNonQuery();

            cn.Close();
            textBox1.Text = "";
            MessageBox.Show("Event Inserted Successfully.");
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
