using StockoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Factory
{
    public class UserFactory
    {
        public static User create(int userid,string username, string useremail,DateTime dob, string password, string role)
        {
            User user = new User();
            user.UserID = userid;
            user.Username = username;
            user.UserPassword = password;
            user.UserEmail = useremail;
            user.UserDOB = dob;
            user.UserRole = role;
            return user;
        }
    }
}