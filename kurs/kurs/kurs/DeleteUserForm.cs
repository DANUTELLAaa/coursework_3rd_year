using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs.FormsForTeamlead
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void GoToBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForTeamLead mainForm = new mainMenuForTeamLead();
            mainForm.Show();
        }
        TeamLead teamlead = new TeamLead("Иван", "Иванов");
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            teamlead.deleteFromTeam(userNameField.Text, userSurnameField.Text);
            userNameField.Text = "";
            userSurnameField.Text = "";
            
        }
    }
}
