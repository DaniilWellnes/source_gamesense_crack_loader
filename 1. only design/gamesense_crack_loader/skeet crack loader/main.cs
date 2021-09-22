/* created by wellnes#5190 */
using System;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace gamesense_crack
{
    public partial class main : Form
    {
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
            await Task.Delay(5000);
            MessageBox.Show("Карочи всё пиздец... нльнули взлом.. скитнули кряк... релизнули никвар в2... закидали помидорами вт в5", "gay_sex.pw", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
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

        private void cheat_inj_Click(object sender, EventArgs e)
        {

        }

        private void last_upd_Click(object sender, EventArgs e)
        {

        }
    }
}
/* created by wellnes#5190 */