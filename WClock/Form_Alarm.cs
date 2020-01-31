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
    public partial class Form_Alarm : Form
    {
        //Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\WClock\WClock\Database1.mdf;Integrated Security = True
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        string Day;
        public Form_Alarm(String str_day)
        {
            InitializeComponent();
            //this.BackColor = Color.Indigo;
            //this.TransparencyKey = Color.Indigo;
            Day = str_day;
            this.label1.Text = Day;
        }

        private void Form_Alarm_Shown(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                //WriteLine("nono");
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }


        private void Form_Alarm_Load(object sender, EventArgs e)
        {
 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button_add_event_Click(object sender, EventArgs e)
        {
            AddAlarm openForm = new AddAlarm(Day);
            openForm.Show();
        }
        public void display_data()
        {
            //cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            if (Day == "Monday") 
            {
                cmd.CommandText = "select * from [Alarm]";
            }
            else if (Day == "Tuesday")
            {
                cmd.CommandText = "select * from [AlarmTuesday]";
            }
            else if (Day == "Wednesday")
            {
                cmd.CommandText = "select * from [AlarmWednesday]";
            }
            else if (Day == "Thursday")
            {
                cmd.CommandText = "select * from [AlarmThursday]";
            }
            else if (Day == "Friday")
            {
                cmd.CommandText = "select * from [AlarmFriday]";
            }
            else if (Day == "Saturday")
            {
                cmd.CommandText = "select * from [AlarmSaturday]";
            }
            else if (Day == "Sunday")
            {
                cmd.CommandText = "select * from [AlarmSunday]";
            }

            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(data);
            dataGridView1.DataSource = data;
            //cn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDelete openForm = new FormDelete(Day);
            openForm.Show();
        }
    }
}
