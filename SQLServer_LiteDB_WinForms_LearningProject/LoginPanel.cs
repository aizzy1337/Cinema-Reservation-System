using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServer_LiteDB_WinForms_LearningProject
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(UserAuthentication.checkUser(usernameText.Text, passwordText.Text))
            {
                Hide();
                var AdministratorPanel = new AdministratorPanel();
                AdministratorPanel.ShowDialog();
                AdministratorPanel = null;
            }
            else
            {
                MessageBox.Show("Błąd logowania!");
            }
        }
    }
}
