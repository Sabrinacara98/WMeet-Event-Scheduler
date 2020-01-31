using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using EAGetMail;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using TextmagicRest;
using TextmagicRest.Model;

namespace WClock
{
    public partial class Select_Contact : Form
    {
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        List<string> email = new List<string>();
        List<string> number = new List<string>();
        String id;
        String name;
        String starttime;
        String endtime;
        String place;
        public Select_Contact(String ID, String NAME, String STARTTIME, String ENDTIME, String PLACE)
        {
            InitializeComponent();
            id = ID;
            name = NAME;
            starttime = STARTTIME;
            endtime = ENDTIME;
            place = PLACE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select openForm = new Select();
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

            for (int i = 0; i < email.Count; i++)
            {
                sendEmail("computerproject714@gmail.com", "computerproject1", email[i], name, starttime, endtime, place);
            }
            MessageBox.Show("Invitation(s) sent!");


        }
        private void sendEmail(String sendr, String password, String receiver, String name, String starttime, String endtime, String place)
        {
            var message = new MailMessage(sendr, receiver);
            message.Subject = name;
            message.Body = "You have an event invitation from " + starttime + " to " + endtime + ". Its location is" + place + ".\n If you want to attend, reply ACCEPT. Otherwise, reply REJECT.\n Thank you! ";

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential(sendr, password);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }
        }

     
        class Program
        {
            static void sendWhatsapp(string[] args)
            {
                TwilioClient.Init(
                    Environment.GetEnvironmentVariable("AC8c1e6696c3c0c6b935ad3927dbee2ce7"),
                    Environment.GetEnvironmentVariable("1cd0ba052daa6774a9a3ee75e7d30520")
                );

                var message = MessageResource.Create(
                    from: new PhoneNumber("whatsapp:00905050577559"),
                    to: new PhoneNumber("whatsapp:00355675491460"),
                    body: "Ahoy from Twilio!"
                );

                Console.WriteLine("Message SID: " + message.Sid);
            }
        }


        private void Select_Contact_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to select this contact?","Select", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;

                    email.Add(dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString());
                    number.Add(dataGridView1.Rows[e.RowIndex].Cells["Phone Number"].FormattedValue.ToString());

                }
                email.ToArray();
                number.ToArray();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
