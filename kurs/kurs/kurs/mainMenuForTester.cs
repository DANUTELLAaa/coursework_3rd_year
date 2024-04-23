using kurs.FormsForTeamlead;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class mainMenuForTester : Form
    {
        public mainMenuForTester()
        {
            InitializeComponent();
        }

        private void GoToBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionMenuForm mainForm = new selectionMenuForm();
            mainForm.Show();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `sender`, `message` FROM `messageTable` WHERE addressee = 'Тестировщик'", dB.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);

            ArrayUsersForm mainForm = new ArrayUsersForm();
            mainForm.Table = table;
            mainForm.nameLabel = "Сообщения";
            mainForm.ShowDialog();
        }

        

        private void KickDeveloperButton_Click(object sender, EventArgs e)
        {
            sendMessageForm mainForm = new sendMessageForm();
            mainForm.roleSend = "Тестировщик";
            mainForm.ShowDialog();
        }

        private void mainMenuForTester_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
