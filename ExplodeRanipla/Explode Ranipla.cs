using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExplodeRanipla
{
    public partial class ExplodeRaniplaForm : Form
    {
        public ExplodeRaniplaForm()
        {
            InitializeComponent();
        }

        private void exitApplicationButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkItOutButton(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://youtu.be/CZj4vaqodBU") { UseShellExecute = true });
        }
    }
}
