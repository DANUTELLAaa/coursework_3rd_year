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
    public partial class mainMenuForTeamLead : Form
    {
        

        public mainMenuForTeamLead()
        {
            InitializeComponent();
        }

        

        private void ComeToAddUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm mainForm = new AddUserForm();
            mainForm.Show();
        }

        private void ComeToRemoveUserButton_Click_1(object sender, EventArgs e)
        {
            
            DeleteUserForm mainForm = new DeleteUserForm();
            mainForm.ShowDialog();
        }
        private void outputListUsers_Click(object sender, EventArgs e)
        {
            
            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", dB.getConnection());



            adapter.SelectCommand = command;
            adapter.Fill(table);

            
            ArrayUsersForm mainForm = new ArrayUsersForm();
            mainForm.Table = table;
            mainForm.nameLabel = "Список сотрудников";
            mainForm.ShowDialog();
        }


        private void mainMenuForTeamLead_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

            MySqlCommand command = new MySqlCommand("SELECT `sender`, `message` FROM `messageTable` WHERE addressee = 'Тимлид'", dB.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);

            ArrayUsersForm mainForm = new ArrayUsersForm();
            mainForm.Table = table;
            mainForm.nameLabel = "Сообщения";
            mainForm.ShowDialog();
        }
    }
}
