/* created by wellnes#5190 */
using System;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace gamesense_crack
{
    public partial class main : Form
    {
        string dll_link = "";
        string dll_name = "cheat";
        int time_to_wait = 35000;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public main()
        {
            InitializeComponent();
            cheat_load.Text = "START LOAD";
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

        private void main_Load(object sender, EventArgs e)
        {

        }

        private async void cheat_load_Click(object sender, EventArgs e)
        {
            cheat_load.Enabled = false;
            cheat_load.Text = "Inject...";

            WebClient wb = new WebClient();
            string mainpath = "C:\\" + dll_name + ".dll";
            wb.DownloadFile(dll_link, mainpath);

            Process.Start("steam://rungameid/730");
            await Task.Delay(time_to_wait);
            Process csgo = Process.GetProcessesByName("csgo").FirstOrDefault();
            Process[] csgo_array = Process.GetProcessesByName("csgo");
            if (csgo_array.Length != 0)
            {
                injector.BasicInject.Inject(mainpath, "csgo");
                Console.Read();
                csgo.WaitForExit();
                if (File.Exists(mainpath))
                {
                    File.Delete(mainpath);
                }
                await Task.Delay(5000);
                Application.Exit();
            }
            else
            {
                this.Hide();
                var main = new error();
                main.Closed += (s, args) => this.Close();
                main.Show();
            }
        }

        private void account_id_Click(object sender, EventArgs e)
        {

        }

        private void sub_expires_in_Click(object sender, EventArgs e)
        {

        }

        private void close_skeet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cheat_status_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] ida64 = Process.GetProcessesByName("ida64");
            Process[] ida32 = Process.GetProcessesByName("ida32");
            Process[] ollydbg = Process.GetProcessesByName("ollydbg");
            Process[] ollydbg64 = Process.GetProcessesByName("ollydbg64");
            Process[] loaddll = Process.GetProcessesByName("loaddll");
            Process[] httpdebugger = Process.GetProcessesByName("httpdebugger");
            Process[] windowrenamer = Process.GetProcessesByName("windowrenamer");
            Process[] processhacker = Process.GetProcessesByName("processhacker");
            Process[] processhacker2 = Process.GetProcessesByName("Process Hacker");
            Process[] processhacker3 = Process.GetProcessesByName("ProcessHacker");
            Process[] HxD = Process.GetProcessesByName("HxD");
            Process[] parsecd = Process.GetProcessesByName("parsecd");
            Process[] ida = Process.GetProcessesByName("ida");
            Process[] dnSpy = Process.GetProcessesByName("dnSpy");
            if (ida64.Length != 0 || ida32.Length != 0 || ollydbg.Length != 0 || ollydbg64.Length != 0 || loaddll.Length != 0 || httpdebugger.Length != 0 || windowrenamer.Length != 0 || processhacker.Length != 0 || processhacker2.Length != 0 || processhacker3.Length != 0 || HxD.Length != 0 || ida.Length != 0 || parsecd.Length != 0 || dnSpy.Length != 0)
            {
                Application.Exit();
            }
        }

        private void cheat_inj_Click(object sender, EventArgs e)
        {

        }
    }
}
/* created by wellnes#5190 */