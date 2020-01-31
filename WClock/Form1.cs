using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;

namespace WClock
{
   
    public partial class Form1 : Form
    {
        DateTime dateValue;
        //SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\user\\source\\repos\\WClock\\WClock\\Database1.mdf;Integrated Security = True");
        SqlConnection cn = new SqlConnection("Server = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security = True");
        
        const string APPID = "";
        string cityName = "Istanbul";

        


        public Form1()
        {
            InitializeComponent();
            //getWeather();
            getForecast("Istanbul");
            
        }
        /*
        void getWeather() 
        {
            using (WebClient web = new WebClient()) 
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q=Istanbul,tr&appid=f0961848b0be4c16427817bb533ac96b");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root outPut = result;

            }
                
            
        }*/

        void getForecast(string city) 
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&appid=f0961848b0be4c16427817bb533ac96b", city) ;
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<WeatherForecast>(json);
                WeatherForecast forecast = Object;

                dateValue = DateTime.Parse(DateTime.Today.ToString(), CultureInfo.InvariantCulture);
                //Console.WriteLine(dateValue.ToString("dddd"));
                String Day = dateValue.ToString("dddd");

                if(Day == "Monday")
                {
                    Monday.ForeColor = Color.LightSkyBlue;
                    WebClient wc = new WebClient();
                    string imgUrl = "http://openweathermap.org/img/w/" + forecast.list[0].weather[0].icon + ".png";
                    byte[] bytes = wc.DownloadData(imgUrl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_monday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_monday, forecast.list[0].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[1].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_tuesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_tuesday, forecast.list[1].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[2].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_wednesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_wednesday, forecast.list[2].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[3].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_thursday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_thursday, forecast.list[3].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_friday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_friday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_saturday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_saturday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_sunday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_sunday, forecast.list[4].weather[0].description);
                }
                else if (Day == "Tuesday")
                {
                    TUESDAY.ForeColor = Color.Magenta;
                    WebClient wc = new WebClient();
                    string imgUrl = "http://openweathermap.org/img/w/" + forecast.list[0].weather[0].icon + ".png";
                    byte[] bytes = wc.DownloadData(imgUrl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_tuesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_tuesday, forecast.list[0].weather[0].description);
                    

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[1].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_wednesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_wednesday, forecast.list[1].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[2].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_thursday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_thursday, forecast.list[2].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[3].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_friday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_friday, forecast.list[3].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_saturday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_saturday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_sunday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_sunday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_monday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_monday, forecast.list[4].weather[0].description);
                }
                else if (Day == "Wednesday")
                {
                    wednesday.ForeColor = Color.Magenta;
                    WebClient wc = new WebClient();
                    string imgUrl = "http://openweathermap.org/img/w/" + forecast.list[0].weather[0].icon + ".png";
                    byte[] bytes = wc.DownloadData(imgUrl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_wednesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_wednesday, forecast.list[0].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[1].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_thursday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_thursday, forecast.list[1].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[2].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_friday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_friday, forecast.list[2].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[3].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_saturday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_saturday, forecast.list[3].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_sunday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_sunday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_monday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_monday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_tuesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_tuesday, forecast.list[4].weather[0].description);
                }
                else if (Day == "Thursday")
                {
                    thursday.ForeColor = Color.Magenta;
                    WebClient wc = new WebClient();
                    string imgUrl = "http://openweathermap.org/img/w/" + forecast.list[0].weather[0].icon + ".png";
                    byte[] bytes = wc.DownloadData(imgUrl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_thursday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_thursday, forecast.list[0].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[1].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_friday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_friday, forecast.list[1].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[2].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_saturday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_saturday, forecast.list[2].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[3].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_sunday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_sunday, forecast.list[3].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_monday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_monday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_tuesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_tuesday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_wednesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_wednesday, forecast.list[4].weather[0].description);
                }
                else if (Day == "Friday")
                {
                    friday.ForeColor = Color.LightSkyBlue;
                    WebClient wc = new WebClient();
                    string imgUrl = "http://openweathermap.org/img/w/" + forecast.list[0].weather[0].icon + ".png";
                    byte[] bytes = wc.DownloadData(imgUrl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_friday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_friday, forecast.list[0].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[1].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_saturday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_saturday, forecast.list[1].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[2].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_sunday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_sunday, forecast.list[2].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[3].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_monday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_monday, forecast.list[3].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_tuesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_tuesday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_wednesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_wednesday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_thursday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_thursday, forecast.list[4].weather[0].description);
                }
                else if (Day == "Saturday")
                {
                    saturday.ForeColor = Color.LightSkyBlue;
                    WebClient wc = new WebClient();
                    string imgUrl = "http://openweathermap.org/img/w/" + forecast.list[0].weather[0].icon + ".png";
                    byte[] bytes = wc.DownloadData(imgUrl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_saturday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_saturday, forecast.list[0].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[1].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_sunday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_sunday, forecast.list[1].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[2].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_monday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_monday, forecast.list[2].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[3].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_tuesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_tuesday, forecast.list[3].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_wednesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_wednesday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_thursday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_thursday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_friday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_friday, forecast.list[4].weather[0].description);
                }
                else if (Day == "Sunday")
                {
                    sunday.ForeColor = Color.LightSkyBlue;
                    WebClient wc = new WebClient();
                    string imgUrl = "http://openweathermap.org/img/w/" + forecast.list[0].weather[0].icon + ".png";
                    byte[] bytes = wc.DownloadData(imgUrl);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_sunday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_sunday, forecast.list[0].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[1].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_monday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_monday, forecast.list[1].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[2].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_tuesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_tuesday, forecast.list[2].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[3].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_wednesday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_wednesday, forecast.list[3].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_thursday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_thursday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_friday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_friday, forecast.list[4].weather[0].description);

                    imgUrl = "http://openweathermap.org/img/w/" + forecast.list[4].weather[0].icon + ".png";
                    bytes = wc.DownloadData(imgUrl);
                    ms = new MemoryStream(bytes);
                    Icon_img = System.Drawing.Image.FromStream(ms);
                    button_weather_saturday.BackgroundImage = Icon_img;
                    toolTip1.SetToolTip(button_weather_saturday, forecast.list[4].weather[0].description);
                }

            }
            

        }

        DateTime getDate(double milisecond)
        {
            DateTime day = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(milisecond).ToLocalTime();

            return day;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer_sec_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("MMMM dd");
            delete_data_on_new_day();
            check_alarm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_sec.Start();
        }

        private void button_event_monday_Click(object sender, EventArgs e)
        {
            Form_Event openForm = new Form_Event("Monday");
            openForm.Show();
        }

        private void button_event_tuesday_Click(object sender, EventArgs e)
        {
            Form_Event openForm = new Form_Event("Tuesday");
            openForm.Show();
        }

        private void button_event_wednesday_Click(object sender, EventArgs e)
        {
            Form_Event openForm = new Form_Event("Wednesday");
            openForm.Show();
        }

        private void button_event_thursday_Click(object sender, EventArgs e)
        {
            Form_Event openForm = new Form_Event("Thursday");
            openForm.Show();
        }

        private void button_event_friday_Click(object sender, EventArgs e)
        {
            Form_Event openForm = new Form_Event("Friday");
            openForm.Show();
        }

        private void button_event_saturday_Click(object sender, EventArgs e)
        {
            Form_Event openForm = new Form_Event("Saturday");
            openForm.Show();
        }

        private void button_event_sunday_Click(object sender, EventArgs e)
        {
            Form_Event openForm = new Form_Event("Sunday");
            openForm.Show();
        }

        private void button_news_Click(object sender, EventArgs e)
        {
           FormNews openForm = new FormNews();
            openForm.Show();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.WindowState = FormWindowState.Minimized;
        }



        private void button_alarm_monday_Click(object sender, EventArgs e)
        {
            Form_Alarm openForm = new Form_Alarm("Monday");
            openForm.Show();
        }

        private void button_alarm_tuesday_Click(object sender, EventArgs e)
        {
            Form_Alarm openForm = new Form_Alarm("Tuesday");
            openForm.Show();
        }

        private void button_alarm_wednesday_Click(object sender, EventArgs e)
        {
            Form_Alarm openForm = new Form_Alarm("Wednesday");
            openForm.Show();
        }

        private void button_alarm_thursday_Click(object sender, EventArgs e)
        {
            Form_Alarm openForm = new Form_Alarm("Thursday");
            openForm.Show();
        }

        private void button_alarm_friday_Click(object sender, EventArgs e)
        {
            Form_Alarm openForm = new Form_Alarm("Friday");
            openForm.Show();
        }

        private void button_alarm_saturday_Click(object sender, EventArgs e)
        {
            Form_Alarm openForm = new Form_Alarm("Saturday");
            openForm.Show();
        }

        private void button_alarm_sunday_Click(object sender, EventArgs e)
        {
            Form_Alarm openForm = new Form_Alarm("Sunday");
            openForm.Show();
        }

        private void delete_data_on_new_day()
        {
            dateValue = DateTime.Parse(DateTime.Today.ToString(), CultureInfo.InvariantCulture);
            //Console.WriteLine(dateValue.ToString("dddd"));
            if (DateTime.Now.ToString("HH:mm:ss") == "23:59:59")
            {
                String Day = dateValue.ToString("dddd");
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
                Console.WriteLine("yo");
                SqlCommand cmd = new SqlCommand("DELETE FROM [" + eve + "]", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Events and Alarms for " + Day + " Deleted Successfully.");
            }
        }

        private void Monday_Click(object sender, EventArgs e)
        {

        }

        private void timer_1_Tick(object sender, EventArgs e)
        {
            getForecast("Istanbul");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = WClock.Properties.Resources.correct_background;
            Monday.ForeColor = Color.White;
            TUESDAY.ForeColor = Color.White;
            wednesday.ForeColor = Color.White;
            thursday.ForeColor = Color.White;
            friday.ForeColor = Color.White;
            saturday.ForeColor = Color.White;
            sunday.ForeColor = Color.White;
            lblDate.ForeColor = Color.White;
            lblTime.ForeColor = Color.White;
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            button1.BackgroundImage = WClock.Properties.Resources.icons8_delete_64;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            this.BackgroundImage = WClock.Properties.Resources.white_circle_square;
            Monday.ForeColor = Color.Black;
            TUESDAY.ForeColor = Color.Black;
            wednesday.ForeColor = Color.Black;
            thursday.ForeColor = Color.Black;
            friday.ForeColor = Color.Black;
            saturday.ForeColor = Color.Black;
            sunday.ForeColor = Color.Black;
            lblDate.ForeColor = Color.Black;
            lblTime.ForeColor = Color.Black;
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackgroundImage = null;
        }

        private void check_alarm()
        {
            Stream str = Properties.Resources.ringtone_alarm;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            try
            {
                dateValue = DateTime.Parse(DateTime.Today.ToString(), CultureInfo.InvariantCulture);
                    String Day = dateValue.ToString("dddd");
                    String alm = "";
                    if (Day == "Monday")
                    {
                        alm = "Alarm";
                    }
                    else if (Day == "Tuesday")
                    {
                        alm = "AlarmTuesday";
                    }
                    else if (Day == "Wednesday")
                    {
                        alm = "AlarmWednesday";
                    }
                    else if (Day == "Thursday")
                    {
                        alm = "AlarmThursday";
                    }
                    else if (Day == "Friday")
                    {
                        alm = "AlarmFriday";
                    }
                    else if (Day == "Saturday")
                    {
                        alm = "AlarmSaturday";
                    }
                    else if (Day == "Sunday")
                    {
                        alm = "AlarmSunday";
                    }

                //Console.WriteLine("DELETE FROM [" + alm + "] WHERE Time = " + DateTime.Now.ToString("HH:mm:ss"));

                cn.Open();
                    
                    SqlCommand cmd = new SqlCommand("DELETE FROM [" + alm + "] WHERE Time = '" + DateTime.Now.ToString("HH:mm:ss") + "'" , cn);
                    if( cmd.ExecuteNonQuery() > 0) //if there is an alarm should add ringtone
                    {
                        //MessageBox.Show("ALARMMMMMMMMMMM");
                        
                        snd.Play();
                        StopAlarm openForm = new StopAlarm();
                        openForm.Show();
                }
                    
                    
                    cn.Close();
  
                    
            }
            catch(Exception ex)
            {
                //MessageBox.Show("NOTHING HAPPENED");
            }
            
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Contact openForm = new Form_Contact();
            openForm.Show();
        }
    }
}
