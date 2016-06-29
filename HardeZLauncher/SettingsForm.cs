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
    public partial class SettingsForm : Form
    {
        Account ac;
        public SettingsForm(Account acc)
        {
            InitializeComponent();
            ac = acc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                ac.Name = textBox1.Text;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");


            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Center);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            this.Controls.Add(listView1);

        }

    }
}
