using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string folder = "folder/";
            string uri = "http://hardez.ru/files/";
            string fileName = textBox1.Text;
            WebClient webServer = new WebClient();
            try
            {
                webServer.DownloadFile(uri + fileName, folder + fileName);
                label2.Text = "comleted!";
            }
            catch (ArgumentNullException ex)
            {
                label2.Text = "NULL address";
            }
            catch (WebException ex)
            {
                label2.Text = "file not found";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //void 

        private void button3_Click(object sender, EventArgs e)
        {
            String[] status = MojangRequests.authenticate(Profile.getClientToken(), textBox2.Text, textBox3.Text);
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\auth.txt");

            /*String[] status = MojangRequests.refresh("501f9dd6b4544c0f971dc7e78510f868", "ca5d8019489947a7cc2874cd422ddbc", "a73a7cfdc77a47b4967972b259db9b08", "Tusochiso");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\refresh.txt");*/

            /*String[] status = MojangRequests.validate("501f9dd6b4544c0f971dc7e78510f868", "ca5d8019489947a7cc2874cd422ddbc");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\valid.txt");*/

            /*String[] status = MojangRequests.signout(textBox2.Text, textBox3.Text);
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\signout.txt");*/

            /*String[] status = MojangRequests.validate("501f9dd6b4544c0f971dc7e78510f868", "ca5d8019489947a7cc2874cd422ddbc");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\invalid.txt");*/

            label3.Text = label3.Text + status[0] + "\n";
            label3.Text = label3.Text + status[1] + "\n";

            // Write the string to a file.
            file.WriteLine(status[0]);
            file.WriteLine(status[1]);
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MojangRequests.setTimeConnections();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //label3.Text = MojangRequests.checkTimeConnections().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
