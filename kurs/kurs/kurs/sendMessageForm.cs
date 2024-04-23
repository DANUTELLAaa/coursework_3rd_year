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
    public partial class sendMessageForm : Form
    {
        public string roleSend;
        
        public sendMessageForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (roleSend == "Тестировщик")
            {
                Tester tester = new Tester("", "");
                tester.sendMessageFromTester(messageField.Text);
            }
            if (roleSend == "Разработчик")
            {
                Developer developer = new Developer("", "");
                developer.sendMessageFromDeveloper(messageField.Text);
                
            }
            
            messageField.Text = "";
        }
    }
}
