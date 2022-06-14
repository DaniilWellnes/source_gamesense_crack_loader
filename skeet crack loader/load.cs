/* created by wellnes#5190 */
using System;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace gamesense_crack
{
    public partial class load : Form
    {
        public load()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler((o, e) =>
            {
                base.Capture = false;
                Message message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref message);
            });
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.1d) == 1) timer.Stop();
            });
            timer.Interval = 20;
            timer.Start();
        }

        private void load_Load(object sender, EventArgs e)
        {
            Process[] steam = Process.GetProcessesByName("steam");
            if (steam.Length != 0)
            {
                foreach (var process in Process.GetProcessesByName("steam"))
                {
                    process.Kill();
                }
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            timeLeft = 30;
            timer1.Start();
        }
        Random randomizer = new Random();
        int addend1;
        int addend2;
        int timeLeft;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                var load = new vhod();
                load.Closed += (s, args) => this.Close();
                load.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
/* created by wellnes#5190 */