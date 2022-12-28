using NoteAppLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_App
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MainWindow frm = new MainWindow(usernameValue.Text);
                frm.Show();
            }
            else
            {
                MessageBox.Show("The provided login details doesn't match any user.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            return Authentication.ValidateLoginDetails(usernameValue.Text, passwordValue.Text);
        }

        private void createNewAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp frm = new SignUp();

            frm.Show();
        }
    }
}
