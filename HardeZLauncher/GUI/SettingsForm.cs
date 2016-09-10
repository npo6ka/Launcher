using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace Launcher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            textBox1.Text = MainForm.launchSettings.JavaPathDir.Path;
            textBox2.Text = MainForm.launchSettings.LaucherWorkDir.Path;
            textBox3.Text = MainForm.launchSettings.AssetsDir.Path;
            textBox4.Text = MainForm.launchSettings.LibraryDir.Path;
            textBox5.Text = MainForm.launchSettings.NativeDir.Path;
            textBox6.Text = MainForm.launchSettings.MinecraftJarDir.Path;
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

        private void setPath(TextBox tb)
        {
            tb.Text = getPath(tb.Text);
            redrowPathTextbox(tb);
        }

        private bool redrowPathTextbox(TextBox tb)
        {
            if (Directory.Exists(tb.Text))
            {
                tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(247)))), ((int)(((byte)(188)))));
                return true;
            }
            else
            {
                tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(175)))));
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setPath(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setPath(textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setPath(textBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setPath(textBox4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setPath(textBox5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setPath(textBox6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setPath(textBox7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!redrowPathTextbox(textBox1) | !redrowPathTextbox(textBox2) | !redrowPathTextbox(textBox3) | !redrowPathTextbox(textBox4) | !redrowPathTextbox(textBox5) | !redrowPathTextbox(textBox6))
            {
                DialogResult result = MessageBox.Show("realy?", "error", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void button12_Click(object sender, EventArgs e)
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

        private void textbox_LostFocus(object sender, EventArgs e)
        {
            //new System.Windows.Forms.TextBox();
            redrowPathTextbox(sender as TextBox);
        }
    }
}
