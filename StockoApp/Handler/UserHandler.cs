using StockoApp.Models;
using StockoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockoApp.Handler
{
    public class UserHandler
    {
        private readonly UserRepo _userRepo;

        public UserHandler()
        {
            _userRepo = new UserRepo();
        }
        public int GenerateID()
        {
            UserHandler uhan = new UserHandler();
            User user = uhan.GetLastUser();
            if (user == null)
            {
                return 1;
            }
            int id = user.UserID;
            id++;
            return id;
        }
        public User Login(string username, string password)
        {
            return _userRepo.login(username, password);
        }

        public void InsertUser(string username, string useremail, DateTime userdob, string userpassword, string userrole)
        {
            int userid = GenerateID();
            _userRepo.insert(userid, username, useremail, userdob, userpassword, userrole);
        }

        public User GetLastUser()
        {
            return _userRepo.getlastuser();
        }

        public User GetByUsername(string username)
        {
            return _userRepo.samename(username);
        }

        public List<User> GetUsers()
        {
            return _userRepo.getusers();
        }

        public User GetById(int id)
        {
            return _userRepo.byid(id);
        }

        public void UpdateUserById(int id, string username, string email, DateTime dob)
        {
            _userRepo.updatebyid(id, username, email, dob);
        }

        public void UpdatePassword(int id, string password)
        {
            _userRepo.updatepassword(id, password);
        }
    }
}