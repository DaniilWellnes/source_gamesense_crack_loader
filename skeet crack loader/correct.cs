/* created by wellnes#5190 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamesense_crack
{
    public partial class correct : Form
    {
        public correct()
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

        private void other_Load(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await Task.Delay(4000);
            Application.Exit();
        }

        private void inject_correct_Click(object sender, EventArgs e)
        {

        }

    }
}
/* created by wellnes#5190 */