using ArtifactManager.Data;
using ArtifactManager.Data.Models;
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
    }
}
