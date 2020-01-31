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
    public partial class FormDelete : Form
    {
        String Day;
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\sabri\\Desktop\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        public FormDelete(String str)
        {
            InitializeComponent();
            Day = str;
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String alarm = "";
                if (Day == "Monday")
                {
                    alarm = "Alarm";
                }
                else if (Day == "Tuesday")
                {
                    alarm = "AlarmTuesday";
                }
                else if (Day == "Wednesday")
                {
                    alarm = "AlarmWednesday";
                }
                else if (Day == "Thursday")
                {
                    alarm = "AlarmThursday";
                }
                else if (Day == "Friday")
                {
                    alarm = "AlarmFriday";
                }
                else if (Day == "Saturday")
                {
                    alarm = "AlarmSaturday";
                }
                else if (Day == "Sunday")
                {
                    alarm = "AlarmSunday";
                }

                int idNumber = Int32.Parse (textBox1.Text);
                cn.Open();
                Console.WriteLine("yo");
                SqlCommand cmd = new SqlCommand("DELETE FROM [" + alarm + "] WHERE Id = @idNumber", cn);
                Console.WriteLine("hello");
                cmd.Parameters.Add(new SqlParameter(@"idNumber", idNumber));
                cmd.ExecuteNonQuery();
                //cn.Close();
                textBox1.Text = "";
       
                MessageBox.Show("Data Deleted Successfully.");

            }
            catch (Exception ex)
            {

            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
