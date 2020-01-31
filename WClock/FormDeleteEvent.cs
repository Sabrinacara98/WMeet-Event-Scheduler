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
    public partial class FormDeleteEvent : Form
    {
        String Day;
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\sabri\\Desktop\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        public FormDeleteEvent(String str)
        {
            InitializeComponent();
            Day = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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

                int idNumber = Int32.Parse(textBox1.Text);
                cn.Open();
                Console.WriteLine("yo");
                SqlCommand cmd = new SqlCommand("DELETE FROM ["+ eve + "] WHERE Id = @idNumber", cn);
                Console.WriteLine("hello");
                cmd.Parameters.Add(new SqlParameter(@"idNumber", idNumber));
                cmd.ExecuteNonQuery();
                cn.Close();
                textBox1.Text = "";

                MessageBox.Show("Event Deleted Successfully.");

            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
