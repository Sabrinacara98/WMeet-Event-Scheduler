using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WClock
{
    public partial class StopAlarm : Form
    {
        public StopAlarm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.ringtone_alarm;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Stop();
        }
    }
}
