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

namespace kurs.FormsForTeamlead
{
    public partial class AddUserForm : Form
    {
        

        public AddUserForm()
        {
            InitializeComponent();
            
            
        }
        TeamLead teamlead = new TeamLead("Иван", "Иванов");
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            teamlead.addToTeam(userNameField.Text, userSurnameField.Text, userEmailField.Text, userRoleField.Text);
            userNameField.Text = "";
            userSurnameField.Text = "";
            userEmailField.Text = "";
            userRoleField.Text = "";
        }

        private void GoToBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForTeamLead mainForm = new mainMenuForTeamLead();
            mainForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userSurnameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void userRoleField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void userEmailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
