using ArtifactManager.Data;
using ArtifactManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Forms.Signin
{
    public class SigninReq
    {
        Signin caller;
        public SigninReq(Signin caller)
        {
            this.caller = caller;
        }

        public bool UserExists(string username)
        {
            using var context = new ArtifactManagerContext();
            var users = context.Users.Where(u => u.Username.Equals(username)).ToList();
            return users.Count > 0;
        }

        public void AddUser(string firstName, string lastName, string username, string password)
        {
            using var context = new ArtifactManagerContext();
            User newUser = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password
            };
            context.Add(newUser);
            context.SaveChanges();
        }

        public bool CheckUserLoginAndPassword(string username, string password)
        {
            using var context = new ArtifactManagerContext();
            var users = context.Users.Where(u => u.Username.Equals(username) && u.Password.Equals(password)).ToList();
            return users.Count > 0;
        }

        public User SignInUser(string username, string password)
        {
            using var context = new ArtifactManagerContext();
            User currentUser = context.Users.
                Where(u => u.Username.Equals(username) && u.Password.Equals(password)).FirstOrDefault();

            if(currentUser == null)
            {
                return null;
            }
            return currentUser;
        }
    }
}
