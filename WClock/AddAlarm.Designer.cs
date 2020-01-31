namespace WClock
{
    partial class AddAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlarm));
            this.database1DataSet = new WClock.Database1DataSet();
            this.alarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmTableAdapter = new WClock.Database1DataSetTableAdapters.AlarmTableAdapter();
            this.tableAdapterManager = new WClock.Database1DataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.Monday = new System.Windows.Forms.CheckBox();
            this.Tuesday = new System.Windows.Forms.CheckBox();
            this.Wednesday = new System.Windows.Forms.CheckBox();
            this.Thursday = new System.Windows.Forms.CheckBox();
            this.Friday = new System.Windows.Forms.CheckBox();
            this.Saturday = new System.Windows.Forms.CheckBox();
            this.Sunday = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarmBindingSource
            // 
            this.alarmBindingSource.DataMember = "Alarm";
            this.alarmBindingSource.DataSource = this.database1DataSet;
            // 
            // alarmTableAdapter
            // 
            this.alarmTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlarmTableAdapter = this.alarmTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WClock.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(271, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(48, 63);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(31, 15);
            this.Title.TabIndex = 12;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Location = new System.Drawing.Point(47, 101);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(33, 15);
            this.Start.TabIndex = 13;
            this.Start.Text = "Time";
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.BackColor = System.Drawing.Color.Transparent;
            this.Monday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Monday.Location = new System.Drawing.Point(19, 186);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(38, 19);
            this.Monday.TabIndex = 14;
            this.Monday.Text = "M";
            this.Monday.UseVisualStyleBackColor = false;
            this.Monday.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.BackColor = System.Drawing.Color.Transparent;
            this.Tuesday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tuesday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tuesday.Location = new System.Drawing.Point(60, 186);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(34, 19);
            this.Tuesday.TabIndex = 15;
            this.Tuesday.Text = "T";
            this.Tuesday.UseVisualStyleBackColor = false;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Wednesday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wednesday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Wednesday.Location = new System.Drawing.Point(100, 186);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(39, 19);
            this.Wednesday.TabIndex = 16;
            this.Wednesday.Text = "W";
            this.Wednesday.UseVisualStyleBackColor = false;
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.BackColor = System.Drawing.Color.Transparent;
            this.Thursday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thursday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Thursday.Location = new System.Drawing.Point(143, 186);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(43, 19);
            this.Thursday.TabIndex = 17;
            this.Thursday.Text = "TH";
            this.Thursday.UseVisualStyleBackColor = false;
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.BackColor = System.Drawing.Color.Transparent;
            this.Friday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Friday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Friday.Location = new System.Drawing.Point(187, 186);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(33, 19);
            this.Friday.TabIndex = 18;
            this.Friday.Text = "F";
            this.Friday.UseVisualStyleBackColor = false;
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.BackColor = System.Drawing.Color.Transparent;
            this.Saturday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saturday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Saturday.Location = new System.Drawing.Point(225, 186);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(33, 19);
            this.Saturday.TabIndex = 19;
            this.Saturday.Text = "S";
            this.Saturday.UseVisualStyleBackColor = false;
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.BackColor = System.Drawing.Color.Transparent;
            this.Sunday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sunday.Location = new System.Drawing.Point(264, 186);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(33, 19);
            this.Sunday.TabIndex = 20;
            this.Sunday.Text = "S";
            this.Sunday.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(50, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(174, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "New Alarm";
            // 
            // AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WClock.Properties.Resources.smoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAlarm";
            this.Text = "AddAlarm";
            this.Load += new System.EventHandler(this.AddAlarm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource alarmBindingSource;
        private Database1DataSetTableAdapters.AlarmTableAdapter alarmTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.CheckBox Monday;
        private System.Windows.Forms.CheckBox Tuesday;
        private System.Windows.Forms.CheckBox Wednesday;
        private System.Windows.Forms.CheckBox Thursday;
        private System.Windows.Forms.CheckBox Friday;
        private System.Windows.Forms.CheckBox Saturday;
        private System.Windows.Forms.CheckBox Sunday;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}