using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laucher
{
    public partial class AccountsForm : Form
    {
        List<AccountPanel> listAccounts;
        static int selectedAccount = -1;

        public AccountsForm()
        {
            InitializeComponent();
            
            listAccounts = new List<AccountPanel>();

            int count = 1;

            for (int i = 0; i < count; i++)
            {
                AccountPanel acnt = new AccountPanel(i, panel1.Size.Width, "user" + i);
                panel1.Controls.Add(acnt.Panel);
                listAccounts.Add(acnt);
            }

            if (count * AccountPanel.Height <= panel1.Size.Height)
            {
                vScrollBar1.Enabled = false;
            } else
            {
                vScrollBar1.Minimum = 0;
                vScrollBar1.Maximum = count * AccountPanel.Height - panel1.Size.Height+10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            //label3.Text = "click";
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            for (int i = 0; i < listAccounts.Count; ++i)
            {
                listAccounts[i].Panel.Location = new Point(0, i * AccountPanel.Height - vScrollBar1.Value);
            }
        }
    }
}
