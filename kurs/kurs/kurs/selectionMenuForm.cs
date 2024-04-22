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
    public partial class selectionMenuForm : Form
    {
        public selectionMenuForm()
        {
            InitializeComponent();
        }

        

        private void ComeToTeamLeadButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForTeamLead mainForm = new mainMenuForTeamLead();
            mainForm.Show();
        }

        private void ComeToTesterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForTester mainForm = new mainMenuForTester();
            mainForm.Show();
        }

        private void ComeToDeveloperButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForDeveloper mainForm = new mainMenuForDeveloper();
            mainForm.Show();
        }

        private void selectionMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
