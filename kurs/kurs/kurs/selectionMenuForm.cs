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

        }

        private void ComeToDeveloperButton_Click(object sender, EventArgs e)
        {

        }
    }
}
