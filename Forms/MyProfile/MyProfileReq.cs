using ArtifactManager.Data;
using ArtifactManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Forms.MyProfile
{
    public class MyProfileReq
    {

        public MyProfileReq()
        {

        }

        public void AddImageToUser(string imageUrl)
        {
            using var context = new ArtifactManagerContext();
            User currentUser = context.Users.Where(u => u.Username == Main.Main.currentUser.Username && u.Password == Main.Main.currentUser.Password).First();
            currentUser.ImageUrl = imageUrl;
            context.SaveChanges();
        }
    }
}
