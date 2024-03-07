using BuisnessLayer.Interface;
using BuisnessLayer.Services;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Speaker.leison.Forms
{
    public partial class Index : Form
    {
        private readonly Ichanell chanells;
        public Index()
        {
            chanells = new ChanellServices();
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int x = screenWidth - formWidth;
            int y = screenHeight - formHeight;
            this.Location = new Point(x, y);
            this.Text = "შეტყობინება";
            this.Visible = true;
            SoundPlayer player = new SoundPlayer("C:\\Users\\aapkh\\source\\repos\\Speaker.leison\\AlarmsAndSounds\\alarm.wav");
            player.Play();
            player.PlaySync();
        }

        private  void GilakiYes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Thread.Sleep(500);
            Index_Load(sender, e);
        }

        private void GilakiNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Thread.Sleep(500);
            Index_Load(sender, e);

        }
    }
}
