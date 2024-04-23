using kurs.FormsForTeamlead;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace kurs
{
    public class User
    {
        public string name { get; set; }
        public string role { get; set; }
        public string surname { get; set; }

        public string email {  get; set; }
        

        public User(string name, string surname, string role)
        {
            this.name = name;
            this.surname = surname;
            this.role = role;   
        }

        
        
        
    }

    public class TeamLead : User
    {
        

        public TeamLead(string name, string surname) 
            : base(name,  surname,   "Team Lead")
        {
            
        }

        DB dB = new DB();
        
        public void deleteFromTeam(string name, string surname)
        {


            if (name == "" || surname == "" )
                return;

            
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE name = @name AND surname = @surname", dB.getConnection());
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
           
            

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь уволен");
            }
            else { MessageBox.Show("Пользователь не уволен"); }

            dB.closeConnection();
        }

        public void addToTeam(string name, string surname, string email, string role)
        {
            if (name == "" || role == "" || surname == "" || email == "")
                return;

            
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `email`, `role`) VALUES (@name, @surname, @email, @role)", dB.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь зарегистрирован");
            }
            else { MessageBox.Show("Пользователь не зарегистрирован"); }

            dB.closeConnection();
        }

    }
        
    
    public class Tester : User
    {
 
        public Tester(string name, string surname )
            : base(name, surname,   "Tester")
        {
            
        }
        public void sendMessageFromTester(string message)
        {
            DB dB = new DB();
            if ( message == "")
                return;


            MySqlCommand command = new MySqlCommand("INSERT INTO `messageTable` (`sender`, `addressee`, `message`) VALUES (@sender, @addressee, @message)", dB.getConnection());
            command.Parameters.Add("@sender", MySqlDbType.VarChar).Value = "Тестировщик";
            command.Parameters.Add("@addressee", MySqlDbType.VarChar).Value = "Разработчик";
            command.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;


            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Сообщение отправлено");
            }
            else { MessageBox.Show("Сообщение не отправлено"); }

            dB.closeConnection();
        }
    }

    public class Developer : User
    {
        public Developer(string name, string surname)
            : base(name, surname,  "Developer")
        {
            
        }
        public void sendMessageFromDeveloper(string message)
        {
            DB dB = new DB();
            if (message == "")
                return;


            MySqlCommand command = new MySqlCommand("INSERT INTO `messageTable` (`sender`, `addressee`, `message`) VALUES (@sender, @addressee, @message)", dB.getConnection());
            command.Parameters.Add("@sender", MySqlDbType.VarChar).Value = "Разработчик";
            command.Parameters.Add("@addressee", MySqlDbType.VarChar).Value = "Тимлид";
            command.Parameters.Add("@message", MySqlDbType.VarChar).Value = message;


            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Сообщение отправлено");
            }
            else { MessageBox.Show("Сообщение не отправлено"); }

            dB.closeConnection();
        }




    }

}

    

