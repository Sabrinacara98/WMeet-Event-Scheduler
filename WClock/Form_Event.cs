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
    public partial class Form_Event : Form

    {
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\sabri\\Desktop\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        string Day;
        String place;
        public Form_Event(String str_day)
        {
            InitializeComponent();
            //this.BackColor = Color.Indigo;
            //this.TransparencyKey = Color.Indigo;
            Day = str_day;
        }

        private void button_add_event_Click(object sender, EventArgs e)
        {
            Add_event openForm = new Add_event(Day);
            openForm.Show();
        }

        private void Form_Event_Shown(object sender, EventArgs e)
        {
            try
            {
                //cn.Open();
            }
            catch (SqlException ex)
            {
                //WriteLine("nono");
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDeleteEvent openForm = new FormDeleteEvent(Day);
            openForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Event_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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
            else if(Day == "Friday")
            {
                eve = "EventFriday";
            }
            else if(Day == "Saturday")
            {
                eve = "EventSaturday";
            }
            else if(Day == "Sunday")
            {
                eve = "EventSunday";
            }

            listViewEvent.Items.Clear();
            SqlCommand cm = new SqlCommand("SELECT * FROM " + eve + " ORDER BY Start ASC", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            //Console.WriteLine("zero");
            string Output = "";
            while (dr.Read())
            {
                listViewEvent.Items.Add(new ListViewItem(new string[] { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(),dr.GetValue(4).ToString() }));
            }
            cn.Close();
            }

        private void listViewEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewEvent_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to share this event?", "Share Event", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (listViewEvent.SelectedItems.Count > 0)
                {
                    ListViewItem item = listViewEvent.SelectedItems[0];

                    String id = item.SubItems[0].ToString();
                    String name = item.SubItems[1].ToString();
                    String startTime = item.SubItems[2].ToString();
                    String endTime = item.SubItems[3].ToString();
                    char[] separator = { '{', '}' };
                    Int32 count = 2;
                    String[] strlist = id.Split(separator, count, StringSplitOptions.None);

                    char[] separator1 = { '}', '}' };
                    count = 2;
                    strlist = strlist[1].Split(separator1, count, StringSplitOptions.None);
                    String ID = strlist[0];

                    strlist = name.Split(separator, count, StringSplitOptions.None);
                    strlist = strlist[1].Split(separator1, count, StringSplitOptions.None);
                    String NAME = strlist[0];

                    strlist = startTime.Split(separator, count, StringSplitOptions.None);
                    strlist = strlist[1].Split(separator1, count, StringSplitOptions.None);
                    String STARTTIME = strlist[0];

                    strlist = endTime.Split(separator, count, StringSplitOptions.None);
                    strlist = strlist[1].Split(separator1, count, StringSplitOptions.None);
                    String ENDTIME = strlist[0];

                    Select_Contact openForm = new Select_Contact( ID,  NAME,  STARTTIME, ENDTIME,place);
                    openForm.Show();

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems = listViewEvent.CheckedItems;
            
            foreach (ListViewItem item in checkedItems) { 

                String id = item.SubItems[0].Text;
                String name = item.SubItems[1].Text;
                String starttime = item.SubItems[2].Text;
                String endtime = item.SubItems[3].Text;
                place = item.SubItems[4].Text;
                FormCheckEvent openForm = new FormCheckEvent(id, name, starttime, endtime,Day, place);
                openForm.Show();

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            String eve = "Table2";
            SqlCommand cm;


            listViewEvent.Items.Clear();
            cm = new SqlCommand("SELECT [Id],[Title] ,[Start] ,[End] ,[Place] FROM [" + eve + "] WHERE Day='" + Day + "' ORDER BY Start ASC", cn);
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            //Console.WriteLine("zero");
            string Output = "";
            while (dr.Read())
            {
                listViewEvent.Items.Add(new ListViewItem(new string[] { dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString() }));
            }
            cn.Close();
            
            
        }
    }
    }
   
