using ArtifactManager.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.MyProfile
{
    public class MyProfileStyles
    {
        MyProfile caller;

        public MyProfileStyles(MyProfile caller)
        {
            this.caller = caller;
        }

        public void InitImageButtonStyles()
        {
            caller.buttonImage.Image = Main.Main.currentUser.ImageUrl.Length > 0 ? null : Resources.AddUser100;
            caller.buttonImage.BackgroundImage = Main.Main.currentUser.ImageUrl.Length > 0 ? caller.MyProfileController.SetBackgroungImageUrl(Main.Main.currentUser.ImageUrl) : null;
            caller.buttonImage.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
