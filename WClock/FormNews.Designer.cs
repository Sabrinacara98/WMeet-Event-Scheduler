namespace WClock
{
    partial class FormNews
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
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.buttonNextSource = new System.Windows.Forms.Button();
            this.buttonPrevSource = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(60, 282);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(287, 114);
            this.DescriptionBox.TabIndex = 0;
            this.DescriptionBox.Text = "";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Location = new System.Drawing.Point(60, 65);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(287, 150);
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(272, 233);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "Next News";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(60, 233);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 3;
            this.button_prev.Text = "Prev News";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.titleLabel.Location = new System.Drawing.Point(172, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(77, 24);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title";
            // 
            // buttonNextSource
            // 
            this.buttonNextSource.Location = new System.Drawing.Point(271, 27);
            this.buttonNextSource.Name = "buttonNextSource";
            this.buttonNextSource.Size = new System.Drawing.Size(75, 23);
            this.buttonNextSource.TabIndex = 5;
            this.buttonNextSource.Text = "Next Source";
            this.buttonNextSource.UseVisualStyleBackColor = true;
            this.buttonNextSource.Click += new System.EventHandler(this.buttonNextSource_Click);
            // 
            // buttonPrevSource
            // 
            this.buttonPrevSource.Location = new System.Drawing.Point(60, 27);
            this.buttonPrevSource.Name = "buttonPrevSource";
            this.buttonPrevSource.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevSource.TabIndex = 6;
            this.buttonPrevSource.Text = "Prev Source";
            this.buttonPrevSource.UseVisualStyleBackColor = true;
            this.buttonPrevSource.Click += new System.EventHandler(this.buttonPrevSource_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(159, 402);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonPrevSource);
            this.Controls.Add(this.buttonNextSource);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.DescriptionBox);
            this.Name = "FormNews";
            this.Text = "FormNews";
            this.Load += new System.EventHandler(this.FormNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_prev;
        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button buttonNextSource;
        private System.Windows.Forms.Button buttonPrevSource;
        private System.Windows.Forms.Button buttonRefresh;
    }
}