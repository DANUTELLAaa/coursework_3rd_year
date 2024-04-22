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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;
        }

        

        private void closeButtom_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
                return;
            if (userSurnameField.Text == "")
                return;
            if (isUserExicts())
                return;
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", dB.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passbox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акк создан");
            }
            else { MessageBox.Show("Акк создан"); }

            dB.closeConnection();
        }

        public Boolean isUserExicts()
        {
            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL" , dB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginBox.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else 
            { 
                MessageBox.Show("NO");
                return false;
                   }
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm1 loginForm1 = new loginForm1();
            loginForm1.Show();
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
