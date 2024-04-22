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

        }

        private void resignYourselfButton_Click(object sender, EventArgs e)
        {

        }
    }
}
