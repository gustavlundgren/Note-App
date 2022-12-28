using NoteAppLibrary.DataAccess;
using NoteAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppLibrary
{
    public static class Authentication
    {
        public static bool ValidateLoginDetails(string username, string password)
        {
            bool output = false;    

            // Get all users from the database
            List<UserModel> users = GlobalConfig.Connection.GetUser_All();

            // Look up the current user by username and get the user
            foreach (UserModel user in users)
            {
                if (user.Username == username)
                {
                    // Check if the password for that user matches with the given password
                    if (user.Password == password)
                    {
                        output = true;
                    }
                }
            }
            return output;
        }

        public static bool ValidateSignUpDetails(string username)
        {
            bool output = true;

            List<UserModel> users = GlobalConfig.Connection.GetUser_All();

            foreach (UserModel user in users)
            {
                if (user.Username == username)
                {
                    output = false;
                }
            }

            return output;
        }
    }
}
