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
using System.Timers;
using System.Media;

namespace WClock
{
    public partial class AddAlarm : Form
    {
        String Day;
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\sabri\\Desktop\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        private System.Timers.Timer timer;

        public System.Timers.Timer Timer { get => timer; set => timer = value; }

        public AddAlarm(String str)
        {
            InitializeComponent();
            Day = str;
        }

        private void alarmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alarmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void AddAlarm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Alarm' table. You can move, or remove it, as needed.
            this.alarmTableAdapter.Fill(this.database1DataSet.Alarm);
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += Timer_Elapsed;

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if((currentTime.Hour == userTime.Hour) && (currentTime.Minute == userTime.Minute) && (currentTime.Second == userTime.Second))
            {
                Timer.Stop();
                try
                {
                    SoundPlayer player = new SoundPlayer();
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                    player.PlayLooping();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alarmDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            
            cn.Open();
            String stat = "SELECT MAX(Id) FROM " + alarm ;
            SqlCommand  read = new SqlCommand(stat, cn);
            Console.WriteLine(read.ExecuteScalar().ToString());
            int counterid = 0;
            try
            {
                counterid = Convert.ToInt32(read.ExecuteScalar().ToString());
            }
            catch(Exception ex)
            {

            }
            //int counterid = Convert.ToInt32(read.ExecuteScalar().ToString());
            Console.WriteLine(counterid);
            counterid = counterid + 1;
            DateTime d = DateTime.Parse(this.dateTimePicker1.Text);
            SqlCommand cmd =new SqlCommand("insert into[" + alarm + "](Id, Title, Time) values(@counterid ,'" + textBox1.Text +"', '" + d.ToString("HH:mm:ss") + "')", cn);
            cmd.Parameters.Add(new SqlParameter(@"counterid", counterid));
            Console.WriteLine(d.ToString("HH:mm:ss"));
         
            cmd.ExecuteNonQuery();
            cn.Close();
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            MessageBox.Show("Data Inserted Successfully.");
            Timer.Start();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }
    }
}
