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
    public partial class ArrayUsersForm : Form
    {
        public DataTable Table
        {
            get { return (DataTable)dataGridView1.DataSource; }
            set { dataGridView1.DataSource = value; }
        }

        public string nameLabel
        {
            get { return label1.Text; }
            set {  label1.Text = value; }
        }
        public ArrayUsersForm()
        {
            InitializeComponent();
            
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        
    }
}
