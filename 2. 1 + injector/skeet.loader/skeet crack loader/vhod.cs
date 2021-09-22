/* created by wellnes#5190 */
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace gamesense_crack
{
    public partial class vhod : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public vhod()
        {
            InitializeComponent();
            vhod_error.Visible = false;
            vhod_error.Enabled = false;
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

        private void login_Load(object sender, EventArgs e)
        {
            close_pass.Visible = false;
            close_pass.Enabled = false;
            password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void log_in_Click(object sender, EventArgs e)
        {
            if (login.Text == "crack" && password.Text == "crack")
            {
                this.Hide();
                var vhod = new main();
                vhod.Closed += (s, args) => this.Close();
                vhod.Show();
            }
            else
            {
                vhod_error.Visible = true;
                vhod_error.Enabled = true;
                await Task.Delay(4000);
                vhod_error.Visible = false;
                vhod_error.Enabled = false;
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void open_pass_Click(object sender, EventArgs e)
        {
            open_pass.Visible = false;
            open_pass.Enabled = false;
            password.UseSystemPasswordChar = false;
            close_pass.Visible = true;
            close_pass.Enabled = true;
        }

        private void close_pass_Click(object sender, EventArgs e)
        {
            open_pass.Visible = true;
            open_pass.Enabled = true;
            password.UseSystemPasswordChar = true;
            close_pass.Visible = false;
            close_pass.Enabled = false;
        }

        private void close_skeet_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void vhod_error_Click(object sender, EventArgs e)
        {

        }
    }
}
/* created by wellnes#5190 */