using NoteAppLibrary.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Note_App
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Authentication.CreateNewUser(usernameValue.Text, passwordValue.Text);
                UserModel u = new UserModel();

                u.Username = usernameValue.Text;
                u.Password = passwordValue.Text;

                // save the userModel to database
                GlobalConfig.Connection.SaveNewUser(u);

                this.Close();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            // check for existing usernames
            if (!Authentication.ValidateSignUpDetails(usernameValue.Text))
            {
                MessageBox.Show("User alredy existing");
                output = false;
            }

            if (usernameValue.Text.Length < 1)
            {
                MessageBox.Show("Enter valid username");
                output= false;
            }

            if (passwordValue.Text.Length < 5)
            {
                MessageBox.Show("Password to short");
                output = false;
            }

            return output;
        }
    }
}
