using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public class User
    {
        public string name { get; set; }
        public string role { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        

        public User(string name, string surname, string email,string role)
        {
            this.name = name;
            this.surname = surname;
            this.role = role;
            this.email = email;
            

        }

        public void resignYourself()
        {

        }
    }

    public class TeamLead : User
    {
        

        public TeamLead(string name, string surname, string email,  string team) 
            : base(name,  surname,  email,  "Team Lead")
        {
            
        }

        DB dB = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        public void deleteFromTeam()
        {
            

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @uL", dB.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = "loginBox.Text;";


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                
            }
            else
            {
                MessageBox.Show("NO");
                
            }
        }

        public void addToTeam()
        {

        }

    }
        
    
    public class Tester : User
    {
        public string project { get; set; }

        public Tester(string name, string surname, string email, string login, string project)
            : base(name, surname, email, login, "Tester")
        {
            this.project = project;
        }

        public void PunchDeveloper()
        {

        }


    }

    public class Developer : User
    {
        public string language { get; set; }

        public Developer(string name, string surname, string email, string login, string language)
            : base(name, surname, email, login, "Developer")
        {
            this.language = language;
        }

        public void askingSalaryIncrease()
        {

        }


    }

}

    

