using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EAGetMail;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;

namespace WClock
{
    public partial class FormCheckEvent : Form
    {
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        String ID;
        String NAME;
        String STARTTIME;
        String ENDTIME;
        String DAY;
        String result1;
        String result2;
        String PLACE;
        List<string> acceptEmails = new List<string>();
        List<string> rejectEmails = new List<string>();
        int acceptCount;
        int rejectCount;

        public FormCheckEvent(String id, String name, String starttime, String endtime, String day, String place)
        {
            InitializeComponent();
            ID = id;
            NAME = name;
            STARTTIME = starttime;
            ENDTIME = endtime;
            label1.Text = NAME;
            label4.Text = STARTTIME;
            label5.Text = ENDTIME;
            DAY = day;
            PLACE = place;
            readInbox(NAME);
            label8.Text = acceptCount.ToString();
            label9.Text = rejectCount.ToString();
            
        }
        private void readInbox(String event_name)
        {
            int accept_count = 0;
            string localInbox = string.Format("{0}\\inbox",Directory.GetCurrentDirectory());

            if (!Directory.Exists(localInbox))
            {
                Directory.CreateDirectory(localInbox);
            }

            MailServer oServer = new MailServer("imap.gmail.com","computerproject714@gmail.com", "computerproject1",ServerProtocol.Imap4);
            oServer.SSLConnection = true;
            oServer.Port = 993;

            MailClient oClient = new MailClient("TryIt");
            oClient.Connect(oServer);

            MailInfo[] infos = oClient.GetMailInfos();
            Console.WriteLine("Index {0} email(s) \r\n", infos.Length);
            MessageBox.Show("Total  " + infos.Length);
            for (int i = 0; i < infos.Length; i++)
            {
                MailInfo info = infos[i];

                Mail oMail = oClient.GetMail(info);

                //MessageBox.Show("From " + oMail.From.ToString());
                String from = oMail.From.ToString();
                char[] separator = { '<', '>' };
                Int32 count = 2;
                String[] strlist = from.Split(separator, count,StringSplitOptions.None);

                char[] separator1 = { '>', '>' };
                count = 2;
                strlist = strlist[1].Split(separator1, count,StringSplitOptions.None);

                String FROM = strlist[0];

                //MessageBox.Show("Subject: " + oMail.Subject);

                String subject = oMail.Subject;
                char[] separator2 = { ':', ':' };
                count = 2;
                strlist = subject.Split(separator2, count,StringSplitOptions.None);

                char[] separator3 = { '(', '(' };
                count = 2;
                try
                {
                    strlist = strlist[1].Split(separator3, count, StringSplitOptions.None);
                }
                catch
                {
                    MessageBox.Show(strlist[0]);
                }
                String Subject = strlist[0].Trim();

                //MessageBox.Show("Text: " + oMail.TextBody);

                String text = oMail.TextBody;
                char[] separator4 = { '\n', ' ' };
                count = 2;
                strlist = text.Split(separator4, count,StringSplitOptions.None);

                String reply = strlist[0].Trim();

                if (Subject.Equals(event_name.Trim()))
                {
                    //MessageBox.Show("SOMEBODY REPLIED");
                    if (reply.Equals("ACCEPT"))
                    {
                        //MessageBox.Show("SOMEBODY ACCEPTED");
                        acceptCount++;
                        acceptEmails.Add(FROM);
                    }
                    else if (reply.Equals("REJECT"))
                    {
                        //MessageBox.Show("SOMEBODY REJECTED");
                        rejectCount++;
                        rejectEmails.Add(FROM);
                    }
                }

            }

        }

        private void FormCheckEvent_Load(object sender, EventArgs e)
        {

        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            result1 = String.Join("\n", acceptEmails.ToArray());
            result2 = String.Join("\n", rejectEmails.ToArray());
            toolTip1.SetToolTip(label8, result1);
            toolTip1.SetToolTip(label9, result2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand read;
            String eve = "Table2";

            cn.Open();

            //SqlCommand cmd = new SqlCommand("insert into[EventTable](Id,Title,Start,End) values(@counterid ,'" + textBox1.Text + "', '" + d1.ToString("HH:mm:ss") + "','" + d2.ToString("HH:mm:ss") + "' )", cn);
            SqlCommand cmd = new SqlCommand("insert into[" + eve + "] values(@ID ,'" + NAME + "', '" + STARTTIME + "', '" + ENDTIME + "','" + PLACE + "','" + result1 + "','" + DAY + "' )", cn);
            cmd.Parameters.Add(new SqlParameter(@"ID", ID));
            Console.WriteLine(cmd);
            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("Event Scheduled Successfully.");

            
            for (int i = 0; i < acceptEmails.Count; i++)
            {
                sendEmail("computerproject714@gmail.com", "computerproject1", acceptEmails[i], NAME, STARTTIME, ENDTIME, PLACE);
            }
            MessageBox.Show("Invitation(s) sent!");
        }
        private void sendEmail(String sendr, String password, String receiver, String name, String starttime, String endtime, String place)
        {
            var message = new MailMessage(sendr, receiver);
            message.Subject = name;
            message.Body = "Email of Confirmation. You have an event from " + starttime + " to " + endtime + ". Location is :" + place + ".\n Thank you for accepting. See you there!";

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential(sendr, password);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }
        }
    }
    }

