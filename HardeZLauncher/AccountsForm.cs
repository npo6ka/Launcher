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

            int count = 15;

            for (int i = 0; i < count; i++)
            {
                AccountPanel acnt = new AccountPanel(i, panel1.Size.Width, "user" + i, new System.EventHandler(this.AccountPanel_Click));
                panel1.Controls.Add(acnt.Panel);
                listAccounts.Add(acnt);
            }

            setScrollBar(panel1.Size.Height, count * AccountPanel.Height);

            reselectedAccount(selectedAccount);
        }

        private void setScrollBar(int panelHeight, int totalHeight)
        {
            if (totalHeight <= panelHeight)
            {
                vScrollBar1.Enabled = false;
            }
            else
            {
                vScrollBar1.Minimum = 0;
                vScrollBar1.Maximum = totalHeight - panelHeight + 10;
            }
        }

        private void reselectedAccount(int num)
        {
            if (listAccounts.Count > num && num > -2)
            {
                if (selectedAccount > 0 && selectedAccount < listAccounts.Count)
                {
                    listAccounts[selectedAccount].deselectAccount();
                }
                if (num != -1)
                {
                    selectedAccount = num;
                    listAccounts[num].selectAccount();
                }
            }
        }

        private void AccountPanel_Click(object sender, EventArgs e)
        {
            Control m = (Control)sender;
            int num = -1;
            for (int i = 0; i < listAccounts.Count; ++i)
            {
                if ((int)listAccounts[i].Panel.Tag == (int)m.Tag)
                {
                    num = i;
                    break;
                }
            }

            reselectedAccount(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedAccount != -1)
            {
                reselectedAccount(-1);
                panel1.Controls.Remove(listAccounts[selectedAccount].Panel);
                listAccounts.Remove(listAccounts[selectedAccount]);
                setScrollBar(panel1.Size.Height, listAccounts.Count * AccountPanel.Height);
            }
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
