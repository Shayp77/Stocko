using StockoApp.Handler;
using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Controller
{
    public class UserController
    {
        public static User findbyid(int id)
        {
            UserHandler userHandler = new UserHandler();
            return userHandler.GetById(id);
        }
        public static List<User> GetUsers()
        {
            UserHandler userHandler = new UserHandler();

            return userHandler.GetUsers();
        }
        public string ValidateLogin(string username, string password)
        {
            UserHandler uhan = new UserHandler();
            User user = uhan.GetByUsername(username);
            string errmess = "";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errmess = "All fields must be filled!";
            }
            else if (user == null)
            {
                errmess = "User does not exist!";
            }
            else if (user.UserPassword != password)
            {
                errmess = "Invalid credentials!";
            }

            return errmess;
        }
        public User getbyusername(string username)
        {
            UserHandler uhan = new UserHandler();
            return uhan.GetByUsername(username);
        }
        public void doregister(string username, string useremail, DateTime userdob, string userpassword, string userrole)
        {
            UserHandler uhan = new UserHandler();
            uhan.InsertUser(username, useremail, userdob, userpassword, userrole);
        }

        public string ValidateRegistration(string username, string password, string confpass, string email, DateTime dateOfBirth)
        {
            UserHandler uhan = new UserHandler();
            User user = uhan.GetByUsername(username);
            string errmess = "";

            if (string.IsNullOrEmpty(username))
            {
                errmess = "The username must be filled";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                errmess = "Please fill the username between 5 to 15 characters";
            }
            else if (user != null)
            {
                errmess = "The Username is already taken";
            }
            else if (string.IsNullOrEmpty(email))
            {
                errmess = "The email must be filled";
            }
            else if (!email.EndsWith(".com"))
            {
                errmess = "Email must end with .com";
            }
            else if (string.IsNullOrEmpty(password))
            {
                errmess = "The password must be filled";
            }
            else if (string.IsNullOrEmpty(confpass))
            {
                errmess = "Confirmation password must be filled";
            }
            else if (!password.Equals(confpass))
            {
                errmess = "Password and Confirm Password must be the same";
            }
            else if (dateOfBirth == DateTime.MinValue)
            {
                errmess = "Date of birth must be filled";
            }


            return errmess;
        }
        public User getbyid(int id)
        {
            UserHandler uhan = new UserHandler();
            return uhan.GetById(id);
        }
        public string validateprofile(string username, string email, DateTime dateOfBirth)
        {
            UserHandler uhan = new UserHandler();
            User user = uhan.GetByUsername(username);
            string errmess = "";

            if (string.IsNullOrEmpty(username))
            {
                errmess = "The username must be filled";
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                errmess = "Please fill the username between 5 to 15 characters";
            }
            else if (string.IsNullOrEmpty(email))
            {
                errmess = "The email must be filled";
            }
            else if (!email.EndsWith(".com"))
            {
                errmess = "Email must end with .com";
            }
            else if (dateOfBirth == DateTime.MinValue)
            {
                errmess = "Date of birth must be filled";
            }


            return errmess;
        }

        public void updatebyid(User currentUser, string username, string email, DateTime dob)
        {
            int id = currentUser.UserID;
            UserHandler uhan = new UserHandler();
            uhan.UpdateUserById(id, username, email, dob);
        }

        public string validatepassword(User user, string password, string newpass)
        {
            string errmess = "";
            string oldpass = user.UserPassword;
            if (string.IsNullOrEmpty(password))
            {
                errmess = "The password must be filled";
            }
            else if (string.IsNullOrEmpty(newpass))
            {
                errmess = "New password must be filled";
            }
            else if (!password.Equals(oldpass))
            {
                errmess = "Your password don't match";
            }
            return errmess;
        }
        public void updatepass(int id, string password)
        {
            UserHandler uhan = new UserHandler();
            uhan.UpdatePassword(id, password);
        }

    }
}