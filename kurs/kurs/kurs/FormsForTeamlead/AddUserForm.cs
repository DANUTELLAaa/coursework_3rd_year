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
            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
            userEmailField.Text = "Введите имя";
            userEmailField.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userEmailField_TextChanged(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }
    }
}
