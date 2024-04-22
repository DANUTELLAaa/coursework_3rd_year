using kurs.FormsForTeamlead;
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
            this.Hide();
            DeleteUserForm mainForm = new DeleteUserForm();
            mainForm.Show();
        }
        private void outputListUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ArrayUsersForm mainForm = new ArrayUsersForm();
            mainForm.Show();
        }

        private void resignYourselfButton_Click(object sender, EventArgs e)
        {
            User user = new User("Bdfy", "dfd","Teamled");
            user.resignYourself();
            this.Hide();
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
    }
}
