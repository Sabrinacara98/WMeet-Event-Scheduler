namespace WClock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Monday = new System.Windows.Forms.Label();
            this.TUESDAY = new System.Windows.Forms.Label();
            this.wednesday = new System.Windows.Forms.Label();
            this.thursday = new System.Windows.Forms.Label();
            this.friday = new System.Windows.Forms.Label();
            this.saturday = new System.Windows.Forms.Label();
            this.sunday = new System.Windows.Forms.Label();
            this.button_event_tuesday = new System.Windows.Forms.Button();
            this.button_news = new System.Windows.Forms.Button();
            this.button_event_sunday = new System.Windows.Forms.Button();
            this.button_event_monday = new System.Windows.Forms.Button();
            this.button_event_saturday = new System.Windows.Forms.Button();
            this.button_event_friday = new System.Windows.Forms.Button();
            this.button_event_thursday = new System.Windows.Forms.Button();
            this.button_event_wednesday = new System.Windows.Forms.Button();
            this.button_alarm_monday = new System.Windows.Forms.Button();
            this.button_alarm_sunday = new System.Windows.Forms.Button();
            this.button_alarm_tuesday = new System.Windows.Forms.Button();
            this.button_alarm_wednesday = new System.Windows.Forms.Button();
            this.button_alarm_saturday = new System.Windows.Forms.Button();
            this.button_alarm_friday = new System.Windows.Forms.Button();
            this.button_alarm_thursday = new System.Windows.Forms.Button();
            this.button_weather_monday = new System.Windows.Forms.Button();
            this.button_weather_sunday = new System.Windows.Forms.Button();
            this.button_weather_tuesday = new System.Windows.Forms.Button();
            this.button_weather_saturday = new System.Windows.Forms.Button();
            this.button_weather_wednesday = new System.Windows.Forms.Button();
            this.button_weather_friday = new System.Windows.Forms.Button();
            this.button_weather_thursday = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer_sec = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Monday
            // 
            this.Monday.AllowDrop = true;
            this.Monday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Monday.BackColor = System.Drawing.Color.Transparent;
            this.Monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.ForeColor = System.Drawing.Color.Snow;
            this.Monday.Location = new System.Drawing.Point(274, 105);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(63, 23);
            this.Monday.TabIndex = 0;
            this.Monday.Text = "MONDAY";
            this.Monday.Click += new System.EventHandler(this.Monday_Click);
            // 
            // TUESDAY
            // 
            this.TUESDAY.BackColor = System.Drawing.Color.Transparent;
            this.TUESDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TUESDAY.ForeColor = System.Drawing.Color.Snow;
            this.TUESDAY.Location = new System.Drawing.Point(369, 179);
            this.TUESDAY.Name = "TUESDAY";
            this.TUESDAY.Size = new System.Drawing.Size(68, 23);
            this.TUESDAY.TabIndex = 1;
            this.TUESDAY.Text = "TUESDAY";
            this.TUESDAY.Click += new System.EventHandler(this.label1_Click);
            // 
            // wednesday
            // 
            this.wednesday.BackColor = System.Drawing.Color.Transparent;
            this.wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday.ForeColor = System.Drawing.Color.Snow;
            this.wednesday.Location = new System.Drawing.Point(378, 275);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(88, 23);
            this.wednesday.TabIndex = 2;
            this.wednesday.Text = "WEDNESDAY";
            this.wednesday.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // thursday
            // 
            this.thursday.BackColor = System.Drawing.Color.Transparent;
            this.thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday.ForeColor = System.Drawing.Color.Snow;
            this.thursday.Location = new System.Drawing.Point(346, 365);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(81, 18);
            this.thursday.TabIndex = 3;
            this.thursday.Text = "THURSDAY";
            // 
            // friday
            // 
            this.friday.BackColor = System.Drawing.Color.Transparent;
            this.friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday.ForeColor = System.Drawing.Color.Snow;
            this.friday.Location = new System.Drawing.Point(197, 365);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(53, 23);
            this.friday.TabIndex = 4;
            this.friday.Text = "FRIDAY";
            // 
            // saturday
            // 
            this.saturday.BackColor = System.Drawing.Color.Transparent;
            this.saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday.ForeColor = System.Drawing.Color.Snow;
            this.saturday.Location = new System.Drawing.Point(147, 275);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(75, 21);
            this.saturday.TabIndex = 5;
            this.saturday.Text = "SATURDAY";
            // 
            // sunday
            // 
            this.sunday.AllowDrop = true;
            this.sunday.BackColor = System.Drawing.Color.Transparent;
            this.sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday.ForeColor = System.Drawing.Color.Snow;
            this.sunday.Location = new System.Drawing.Point(178, 179);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(62, 23);
            this.sunday.TabIndex = 6;
            this.sunday.Text = "SUNDAY";
            // 
            // button_event_tuesday
            // 
            this.button_event_tuesday.BackColor = System.Drawing.Color.Transparent;
            this.button_event_tuesday.BackgroundImage = global::WClock.Properties.Resources.icons8_event_64__1_;
            this.button_event_tuesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_event_tuesday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_tuesday.Location = new System.Drawing.Point(365, 203);
            this.button_event_tuesday.Name = "button_event_tuesday";
            this.button_event_tuesday.Size = new System.Drawing.Size(25, 25);
            this.button_event_tuesday.TabIndex = 7;
            this.button_event_tuesday.UseVisualStyleBackColor = false;
            this.button_event_tuesday.Click += new System.EventHandler(this.button_event_tuesday_Click);
            // 
            // button_news
            // 
            this.button_news.BackColor = System.Drawing.Color.Transparent;
            this.button_news.BackgroundImage = global::WClock.Properties.Resources.icons8_news_64__1_;
            this.button_news.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_news.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_news.Location = new System.Drawing.Point(288, 296);
            this.button_news.Name = "button_news";
            this.button_news.Size = new System.Drawing.Size(48, 44);
            this.button_news.TabIndex = 10;
            this.button_news.UseVisualStyleBackColor = false;
            this.button_news.Click += new System.EventHandler(this.button_news_Click);
            // 
            // button_event_sunday
            // 
            this.button_event_sunday.BackColor = System.Drawing.Color.Transparent;
            this.button_event_sunday.BackgroundImage = global::WClock.Properties.Resources.icons8_event_64__1_;
            this.button_event_sunday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_event_sunday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_sunday.Location = new System.Drawing.Point(181, 203);
            this.button_event_sunday.Name = "button_event_sunday";
            this.button_event_sunday.Size = new System.Drawing.Size(25, 25);
            this.button_event_sunday.TabIndex = 11;
            this.button_event_sunday.UseVisualStyleBackColor = false;
            this.button_event_sunday.Click += new System.EventHandler(this.button_event_sunday_Click);
            // 
            // button_event_monday
            // 
            this.button_event_monday.BackColor = System.Drawing.Color.Transparent;
            this.button_event_monday.BackgroundImage = global::WClock.Properties.Resources.icons8_event_64__1_;
            this.button_event_monday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_event_monday.FlatAppearance.BorderSize = 0;
            this.button_event_monday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_monday.Location = new System.Drawing.Point(286, 126);
            this.button_event_monday.Name = "button_event_monday";
            this.button_event_monday.Size = new System.Drawing.Size(25, 25);
            this.button_event_monday.TabIndex = 17;
            this.button_event_monday.UseVisualStyleBackColor = false;
            this.button_event_monday.Click += new System.EventHandler(this.button_event_monday_Click);
            // 
            // button_event_saturday
            // 
            this.button_event_saturday.BackColor = System.Drawing.Color.Transparent;
            this.button_event_saturday.BackgroundImage = global::WClock.Properties.Resources.icons8_event_64__1_;
            this.button_event_saturday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_event_saturday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_saturday.Location = new System.Drawing.Point(169, 296);
            this.button_event_saturday.Name = "button_event_saturday";
            this.button_event_saturday.Size = new System.Drawing.Size(25, 25);
            this.button_event_saturday.TabIndex = 18;
            this.button_event_saturday.UseVisualStyleBackColor = false;
            this.button_event_saturday.Click += new System.EventHandler(this.button_event_saturday_Click);
            // 
            // button_event_friday
            // 
            this.button_event_friday.BackColor = System.Drawing.Color.Transparent;
            this.button_event_friday.BackgroundImage = global::WClock.Properties.Resources.icons8_event_64__1_;
            this.button_event_friday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_event_friday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_friday.Location = new System.Drawing.Point(216, 386);
            this.button_event_friday.Name = "button_event_friday";
            this.button_event_friday.Size = new System.Drawing.Size(25, 25);
            this.button_event_friday.TabIndex = 19;
            this.button_event_friday.UseVisualStyleBackColor = false;
            this.button_event_friday.Click += new System.EventHandler(this.button_event_friday_Click);
            // 
            // button_event_thursday
            // 
            this.button_event_thursday.BackColor = System.Drawing.Color.Transparent;
            this.button_event_thursday.BackgroundImage = global::WClock.Properties.Resources.icons8_event_64__1_;
            this.button_event_thursday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_event_thursday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_thursday.Location = new System.Drawing.Point(340, 386);
            this.button_event_thursday.Name = "button_event_thursday";
            this.button_event_thursday.Size = new System.Drawing.Size(25, 25);
            this.button_event_thursday.TabIndex = 20;
            this.button_event_thursday.UseVisualStyleBackColor = false;
            this.button_event_thursday.Click += new System.EventHandler(this.button_event_thursday_Click);
            // 
            // button_event_wednesday
            // 
            this.button_event_wednesday.BackColor = System.Drawing.Color.Transparent;
            this.button_event_wednesday.BackgroundImage = global::WClock.Properties.Resources.icons8_event_64__1_;
            this.button_event_wednesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_event_wednesday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_event_wednesday.Location = new System.Drawing.Point(381, 296);
            this.button_event_wednesday.Name = "button_event_wednesday";
            this.button_event_wednesday.Size = new System.Drawing.Size(25, 25);
            this.button_event_wednesday.TabIndex = 21;
            this.button_event_wednesday.UseVisualStyleBackColor = false;
            this.button_event_wednesday.Click += new System.EventHandler(this.button_event_wednesday_Click);
            // 
            // button_alarm_monday
            // 
            this.button_alarm_monday.BackColor = System.Drawing.Color.Transparent;
            this.button_alarm_monday.BackgroundImage = global::WClock.Properties.Resources.icons8_alarm_64;
            this.button_alarm_monday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_alarm_monday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alarm_monday.Location = new System.Drawing.Point(317, 126);
            this.button_alarm_monday.Name = "button_alarm_monday";
            this.button_alarm_monday.Size = new System.Drawing.Size(25, 25);
            this.button_alarm_monday.TabIndex = 22;
            this.button_alarm_monday.UseVisualStyleBackColor = false;
            this.button_alarm_monday.Click += new System.EventHandler(this.button_alarm_monday_Click);
            // 
            // button_alarm_sunday
            // 
            this.button_alarm_sunday.BackColor = System.Drawing.Color.Transparent;
            this.button_alarm_sunday.BackgroundImage = global::WClock.Properties.Resources.icons8_alarm_64;
            this.button_alarm_sunday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_alarm_sunday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alarm_sunday.Location = new System.Drawing.Point(212, 203);
            this.button_alarm_sunday.Name = "button_alarm_sunday";
            this.button_alarm_sunday.Size = new System.Drawing.Size(25, 25);
            this.button_alarm_sunday.TabIndex = 23;
            this.button_alarm_sunday.Text = "button15";
            this.button_alarm_sunday.UseVisualStyleBackColor = false;
            this.button_alarm_sunday.Click += new System.EventHandler(this.button_alarm_sunday_Click);
            // 
            // button_alarm_tuesday
            // 
            this.button_alarm_tuesday.BackColor = System.Drawing.Color.Transparent;
            this.button_alarm_tuesday.BackgroundImage = global::WClock.Properties.Resources.icons8_alarm_64;
            this.button_alarm_tuesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_alarm_tuesday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alarm_tuesday.Location = new System.Drawing.Point(396, 203);
            this.button_alarm_tuesday.Name = "button_alarm_tuesday";
            this.button_alarm_tuesday.Size = new System.Drawing.Size(25, 25);
            this.button_alarm_tuesday.TabIndex = 24;
            this.button_alarm_tuesday.Text = "button16";
            this.button_alarm_tuesday.UseVisualStyleBackColor = false;
            this.button_alarm_tuesday.Click += new System.EventHandler(this.button_alarm_tuesday_Click);
            // 
            // button_alarm_wednesday
            // 
            this.button_alarm_wednesday.BackgroundImage = global::WClock.Properties.Resources.icons8_alarm_64;
            this.button_alarm_wednesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_alarm_wednesday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alarm_wednesday.Location = new System.Drawing.Point(412, 296);
            this.button_alarm_wednesday.Name = "button_alarm_wednesday";
            this.button_alarm_wednesday.Size = new System.Drawing.Size(25, 25);
            this.button_alarm_wednesday.TabIndex = 25;
            this.button_alarm_wednesday.Text = "button17";
            this.button_alarm_wednesday.UseVisualStyleBackColor = true;
            this.button_alarm_wednesday.Click += new System.EventHandler(this.button_alarm_wednesday_Click);
            // 
            // button_alarm_saturday
            // 
            this.button_alarm_saturday.BackColor = System.Drawing.Color.Transparent;
            this.button_alarm_saturday.BackgroundImage = global::WClock.Properties.Resources.icons8_alarm_64;
            this.button_alarm_saturday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_alarm_saturday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alarm_saturday.Location = new System.Drawing.Point(200, 296);
            this.button_alarm_saturday.Name = "button_alarm_saturday";
            this.button_alarm_saturday.Size = new System.Drawing.Size(25, 25);
            this.button_alarm_saturday.TabIndex = 26;
            this.button_alarm_saturday.Text = "button18";
            this.button_alarm_saturday.UseVisualStyleBackColor = false;
            this.button_alarm_saturday.Click += new System.EventHandler(this.button_alarm_saturday_Click);
            // 
            // button_alarm_friday
            // 
            this.button_alarm_friday.BackgroundImage = global::WClock.Properties.Resources.icons8_alarm_64;
            this.button_alarm_friday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_alarm_friday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alarm_friday.Location = new System.Drawing.Point(246, 386);
            this.button_alarm_friday.Name = "button_alarm_friday";
            this.button_alarm_friday.Size = new System.Drawing.Size(25, 25);
            this.button_alarm_friday.TabIndex = 27;
            this.button_alarm_friday.Text = "button19";
            this.button_alarm_friday.UseVisualStyleBackColor = true;
            this.button_alarm_friday.Click += new System.EventHandler(this.button_alarm_friday_Click);
            // 
            // button_alarm_thursday
            // 
            this.button_alarm_thursday.BackgroundImage = global::WClock.Properties.Resources.icons8_alarm_64;
            this.button_alarm_thursday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_alarm_thursday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_alarm_thursday.Location = new System.Drawing.Point(371, 386);
            this.button_alarm_thursday.Name = "button_alarm_thursday";
            this.button_alarm_thursday.Size = new System.Drawing.Size(25, 25);
            this.button_alarm_thursday.TabIndex = 28;
            this.button_alarm_thursday.Text = "button20";
            this.button_alarm_thursday.UseVisualStyleBackColor = true;
            this.button_alarm_thursday.Click += new System.EventHandler(this.button_alarm_thursday_Click);
            // 
            // button_weather_monday
            // 
            this.button_weather_monday.BackColor = System.Drawing.Color.Transparent;
            this.button_weather_monday.BackgroundImage = global::WClock.Properties.Resources.icons8_partly_cloudy_day_64__1_;
            this.button_weather_monday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_weather_monday.FlatAppearance.BorderSize = 0;
            this.button_weather_monday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_weather_monday.ForeColor = System.Drawing.Color.Transparent;
            this.button_weather_monday.Location = new System.Drawing.Point(240, 118);
            this.button_weather_monday.Name = "button_weather_monday";
            this.button_weather_monday.Size = new System.Drawing.Size(40, 40);
            this.button_weather_monday.TabIndex = 29;
            this.button_weather_monday.UseVisualStyleBackColor = false;
            // 
            // button_weather_sunday
            // 
            this.button_weather_sunday.BackColor = System.Drawing.Color.Transparent;
            this.button_weather_sunday.BackgroundImage = global::WClock.Properties.Resources.icons8_partly_cloudy_day_64__1_;
            this.button_weather_sunday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_weather_sunday.FlatAppearance.BorderSize = 0;
            this.button_weather_sunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_weather_sunday.ForeColor = System.Drawing.Color.Transparent;
            this.button_weather_sunday.Location = new System.Drawing.Point(145, 195);
            this.button_weather_sunday.Name = "button_weather_sunday";
            this.button_weather_sunday.Size = new System.Drawing.Size(35, 40);
            this.button_weather_sunday.TabIndex = 30;
            this.button_weather_sunday.UseVisualStyleBackColor = false;
            // 
            // button_weather_tuesday
            // 
            this.button_weather_tuesday.BackColor = System.Drawing.Color.Transparent;
            this.button_weather_tuesday.BackgroundImage = global::WClock.Properties.Resources.icons8_partly_cloudy_day_64__1_;
            this.button_weather_tuesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_weather_tuesday.FlatAppearance.BorderSize = 0;
            this.button_weather_tuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_weather_tuesday.ForeColor = System.Drawing.Color.Transparent;
            this.button_weather_tuesday.Location = new System.Drawing.Point(427, 195);
            this.button_weather_tuesday.Name = "button_weather_tuesday";
            this.button_weather_tuesday.Size = new System.Drawing.Size(33, 40);
            this.button_weather_tuesday.TabIndex = 31;
            this.button_weather_tuesday.UseVisualStyleBackColor = false;
            // 
            // button_weather_saturday
            // 
            this.button_weather_saturday.BackColor = System.Drawing.Color.Transparent;
            this.button_weather_saturday.BackgroundImage = global::WClock.Properties.Resources.icons8_partly_cloudy_day_64__1_;
            this.button_weather_saturday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_weather_saturday.FlatAppearance.BorderSize = 0;
            this.button_weather_saturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_weather_saturday.ForeColor = System.Drawing.Color.Transparent;
            this.button_weather_saturday.Location = new System.Drawing.Point(125, 288);
            this.button_weather_saturday.Name = "button_weather_saturday";
            this.button_weather_saturday.Size = new System.Drawing.Size(38, 40);
            this.button_weather_saturday.TabIndex = 32;
            this.button_weather_saturday.UseVisualStyleBackColor = false;
            // 
            // button_weather_wednesday
            // 
            this.button_weather_wednesday.BackColor = System.Drawing.Color.Transparent;
            this.button_weather_wednesday.BackgroundImage = global::WClock.Properties.Resources.icons8_partly_cloudy_day_64__1_;
            this.button_weather_wednesday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_weather_wednesday.FlatAppearance.BorderSize = 0;
            this.button_weather_wednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_weather_wednesday.ForeColor = System.Drawing.Color.Transparent;
            this.button_weather_wednesday.Location = new System.Drawing.Point(443, 288);
            this.button_weather_wednesday.Name = "button_weather_wednesday";
            this.button_weather_wednesday.Size = new System.Drawing.Size(35, 40);
            this.button_weather_wednesday.TabIndex = 33;
            this.button_weather_wednesday.UseVisualStyleBackColor = false;
            // 
            // button_weather_friday
            // 
            this.button_weather_friday.BackColor = System.Drawing.Color.Transparent;
            this.button_weather_friday.BackgroundImage = global::WClock.Properties.Resources.icons8_partly_cloudy_day_64__1_;
            this.button_weather_friday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_weather_friday.FlatAppearance.BorderSize = 0;
            this.button_weather_friday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_weather_friday.ForeColor = System.Drawing.Color.Transparent;
            this.button_weather_friday.Location = new System.Drawing.Point(169, 378);
            this.button_weather_friday.Name = "button_weather_friday";
            this.button_weather_friday.Size = new System.Drawing.Size(43, 40);
            this.button_weather_friday.TabIndex = 34;
            this.button_weather_friday.UseVisualStyleBackColor = false;
            // 
            // button_weather_thursday
            // 
            this.button_weather_thursday.BackColor = System.Drawing.Color.Transparent;
            this.button_weather_thursday.BackgroundImage = global::WClock.Properties.Resources.icons8_partly_cloudy_day_64__1_;
            this.button_weather_thursday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_weather_thursday.FlatAppearance.BorderSize = 0;
            this.button_weather_thursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_weather_thursday.ForeColor = System.Drawing.Color.Transparent;
            this.button_weather_thursday.Location = new System.Drawing.Point(402, 378);
            this.button_weather_thursday.Name = "button_weather_thursday";
            this.button_weather_thursday.Size = new System.Drawing.Size(33, 40);
            this.button_weather_thursday.TabIndex = 36;
            this.button_weather_thursday.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(285, 257);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 13);
            this.lblTime.TabIndex = 37;
            this.lblTime.Text = "17:50:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(274, 270);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "Sunday 27";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timer_sec
            // 
            this.timer_sec.Interval = 1000;
            this.timer_sec.Tick += new System.EventHandler(this.timer_sec_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WClock.Properties.Resources.icons8_delete_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(555, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 39;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer_1
            // 
            this.timer_1.Interval = 60000;
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(60, 504);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 40;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Light Theme";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(475, 504);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 17);
            this.radioButton2.TabIndex = 41;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dark Theme";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Your favourite app!";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WClock";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(301, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 33);
            this.button2.TabIndex = 42;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WClock.Properties.Resources.correct_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.button_weather_thursday);
            this.Controls.Add(this.button_weather_friday);
            this.Controls.Add(this.button_weather_wednesday);
            this.Controls.Add(this.button_weather_saturday);
            this.Controls.Add(this.button_weather_tuesday);
            this.Controls.Add(this.button_weather_sunday);
            this.Controls.Add(this.button_weather_monday);
            this.Controls.Add(this.button_alarm_thursday);
            this.Controls.Add(this.button_alarm_friday);
            this.Controls.Add(this.button_alarm_saturday);
            this.Controls.Add(this.button_alarm_wednesday);
            this.Controls.Add(this.button_alarm_tuesday);
            this.Controls.Add(this.button_alarm_sunday);
            this.Controls.Add(this.button_alarm_monday);
            this.Controls.Add(this.button_event_wednesday);
            this.Controls.Add(this.button_event_thursday);
            this.Controls.Add(this.button_event_friday);
            this.Controls.Add(this.button_event_saturday);
            this.Controls.Add(this.button_event_monday);
            this.Controls.Add(this.button_event_sunday);
            this.Controls.Add(this.button_news);
            this.Controls.Add(this.button_event_tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.TUESDAY);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.sunday);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.friday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label TUESDAY;
        private System.Windows.Forms.Label wednesday;
        private System.Windows.Forms.Label thursday;
        private System.Windows.Forms.Label friday;
        private System.Windows.Forms.Label saturday;
        private System.Windows.Forms.Label sunday;
        private System.Windows.Forms.Button button_event_tuesday;
        private System.Windows.Forms.Button button_news;
        private System.Windows.Forms.Button button_event_sunday;
        private System.Windows.Forms.Button button_event_monday;
        private System.Windows.Forms.Button button_event_saturday;
        private System.Windows.Forms.Button button_event_friday;
        private System.Windows.Forms.Button button_event_thursday;
        private System.Windows.Forms.Button button_event_wednesday;
        private System.Windows.Forms.Button button_alarm_monday;
        private System.Windows.Forms.Button button_alarm_sunday;
        private System.Windows.Forms.Button button_alarm_tuesday;
        private System.Windows.Forms.Button button_alarm_wednesday;
        private System.Windows.Forms.Button button_alarm_saturday;
        private System.Windows.Forms.Button button_alarm_friday;
        private System.Windows.Forms.Button button_alarm_thursday;
        private System.Windows.Forms.Button button_weather_monday;
        private System.Windows.Forms.Button button_weather_sunday;
        private System.Windows.Forms.Button button_weather_tuesday;
        private System.Windows.Forms.Button button_weather_saturday;
        private System.Windows.Forms.Button button_weather_wednesday;
        private System.Windows.Forms.Button button_weather_friday;
        private System.Windows.Forms.Button button_weather_thursday;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer_sec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer_1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}

