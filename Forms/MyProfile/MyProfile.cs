using ArtifactManager.Data;
using ArtifactManager.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Firebase.Storage;

namespace ArtifactManager.Forms.MyProfile
{
    public partial class MyProfile : Form
    {
        public Main.Main caller;

        public MyProfileController MyProfileController;
        public MyProfileReq MyProfileReq;
        public MyProfileStyles MyProfileStyles;

        public static string imageUrl = "";
        public MyProfile(Main.Main caller)
        {
            InitializeComponent();

            this.caller = caller;

            MyProfileController = new MyProfileController(this);
            MyProfileReq = new MyProfileReq();
            MyProfileStyles = new MyProfileStyles(this);

            MyProfileStyles.InitImageButtonStyles();
            MyProfileController.FillMyProfile();
        }

        private void ButtonImage_Click(object sender, EventArgs e)
        {
            MyProfileController.UploadImage();
        }

        public Button buttonImage;
        public Label labelFirstName;
        public Label labelRole;
        public Label labelUsername;
        public Label labelEntitiesCreated;
        public Label labelCategoriesCreated;
        public Label labelLastName;
    }
}
