using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private String getPath(String str)
        {
            if (folderBrowserDialog1.SelectedPath == "" && Directory.Exists(str))
            {
                folderBrowserDialog1.SelectedPath = str;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                str = folderBrowserDialog1.SelectedPath;
            }
            return str;
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
            textBox1.Text = getPath(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*ListViewItem item1 = new ListViewItem("item1", 0);
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

            this.Controls.Add(listView1);*/

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = getPath(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = getPath(textBox3.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = getPath(textBox4.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = getPath(textBox5.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = getPath(textBox6.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox7.Text = getPath(textBox7.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox8.Text = getPath(textBox8.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox9.Text = getPath(textBox9.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox10.Text = getPath(textBox10.Text);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
