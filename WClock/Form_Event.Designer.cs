namespace WClock
{
    partial class Form_Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Event));
            this.button_add_event = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listViewEvent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add_event
            // 
            this.button_add_event.BackColor = System.Drawing.Color.GhostWhite;
            this.button_add_event.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add_event.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_event.Location = new System.Drawing.Point(12, 374);
            this.button_add_event.Name = "button_add_event";
            this.button_add_event.Size = new System.Drawing.Size(60, 23);
            this.button_add_event.TabIndex = 1;
            this.button_add_event.Text = "ADD";
            this.button_add_event.UseVisualStyleBackColor = false;
            this.button_add_event.Click += new System.EventHandler(this.button_add_event_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(426, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listViewEvent
            // 
            this.listViewEvent.BackColor = System.Drawing.SystemColors.Menu;
            this.listViewEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEvent.CheckBoxes = true;
            this.listViewEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewEvent.HideSelection = false;
            this.listViewEvent.Location = new System.Drawing.Point(1, 42);
            this.listViewEvent.Name = "listViewEvent";
            this.listViewEvent.Size = new System.Drawing.Size(486, 306);
            this.listViewEvent.TabIndex = 3;
            this.listViewEvent.UseCompatibleStateImageBehavior = false;
            this.listViewEvent.View = System.Windows.Forms.View.Details;
            this.listViewEvent.SelectedIndexChanged += new System.EventHandler(this.listViewEvent_SelectedIndexChanged);
            this.listViewEvent.DoubleClick += new System.EventHandler(this.listViewEvent_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 23;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 189;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Start";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "End";
            this.columnHeader4.Width = 88;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(451, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 35);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(81, 374);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "SHOW PLANNED";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(351, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "CHECK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Place";
            this.columnHeader5.Width = 117;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(208, 374);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "SHOW SCHEDULED";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form_Event
            // 
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::WClock.Properties.Resources.smoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 409);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listViewEvent);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_add_event);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Event";
            this.Load += new System.EventHandler(this.Form_Event_Load);
            this.Shown += new System.EventHandler(this.Form_Event_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_event;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listViewEvent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button7;
    }
}