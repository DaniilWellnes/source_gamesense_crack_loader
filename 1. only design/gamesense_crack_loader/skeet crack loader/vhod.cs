/* created by wellnes#5190 */
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace gamesense_crack
{
    public partial class vhod : Form
    {
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

        private void vhod_error_Click(object sender, EventArgs e)
        {

        }
    }
}
/* created by wellnes#5190 */