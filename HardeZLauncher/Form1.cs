using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laucher
{
    public partial class MainForm : Form
    {
        private MainClass main;
        private Account account;
        public MainForm()
        {
            InitializeComponent();
            main = new MainClass();

            account = new Account();
            account.Name = "olololo";
            label2.Text += account.Name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*String[] status = MojangRequests.authenticate(Profile.getClientToken(), textBox2.Text, textBox3.Text);
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\auth.txt");

            /*String[] status = MojangRequests.refresh("501f9dd6b4544c0f971dc7e78510f868", "ca5d8019489947a7cc2874cd422ddbc", "a73a7cfdc77a47b4967972b259db9b08", "Tusochiso");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\refresh.txt");*/

            /*String[] status = MojangRequests.validate("46dadf03128746e4a12bd4405f243ad6", "d7da669ae3d175bc58234d2f57c843f8");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\valid.txt");*/

            /*String[] status = MojangRequests.signout(textBox2.Text, textBox3.Text);
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\signout.txt");*/

            /*String[] status = MojangRequests.invalidate("46dadf03128746e4a12bd4405f243ad6", "d7da669ae3d175bc58234d2f57c843f8");
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\invalid.txt");*/

            /*label3.Text = label3.Text + status[0] + "\n";
            label3.Text = label3.Text + status[1] + "\n";

            // Write the string to a file.
            file.WriteLine(status[0]);
            file.WriteLine(status[1]);
            file.Close();*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SettingsForm set = new SettingsForm(account);

            
            set.ShowDialog();
            label2.Text += account.Name;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AccountsForm acntForm = new AccountsForm();

            acntForm.ShowDialog();

            /*String[] str = MojangRequests.authenticate(Account.ClientToken, "qwe", "qwe");
            StreamWriter file = new System.IO.StreamWriter(@"E:\fail.txt");

            file.WriteLine(str[0]);
            file.WriteLine(str[1]);
            file.Close();*/

            /*Settings set = new Settings();
            label3.Text += set.assetsDir;

            BinaryFormatter binFormat = new BinaryFormatter();

            Stream fStream = new FileStream("user.dat",
                 FileMode.Create, FileAccess.Write, FileShare.None);
            binFormat.Serialize(fStream, set);

            fStream.Close();

            Stream OStream = new FileStream("user.dat",
                 FileMode.Open, FileAccess.Read, FileShare.None);

            BinaryFormatter binFormat2 = new BinaryFormatter();

            Settings st2 = (Settings)binFormat2.Deserialize(OStream);

            label3.Text += st2.assetsDir;*/

        }
    }
}
