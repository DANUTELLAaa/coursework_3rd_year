﻿using MySql.Data.MySqlClient;
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
    }
}
