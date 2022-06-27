using ArtifactManager.Data;
using ArtifactManager.Properties;
using Firebase.Storage;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.MyProfile
{
    public class MyProfileController
    {
        MyProfile caller;
        MyProfileReq MyProfileReq;

        public MyProfileController(MyProfile caller)
        {
            MyProfileReq = new MyProfileReq();
            this.caller = caller;
        }

        public Image SetBackgroungImageUrl(string imageUrl)
        {
            var request = WebRequest.Create(imageUrl);
            using (var webSresponse = request.GetResponse())
            using (var webStream = webSresponse.GetResponseStream())
            {
                return Bitmap.FromStream(webStream);
            }
        }

        public async void UploadImage()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ArtifactManagerContext context = new ArtifactManagerContext())
                    {
                        Console.WriteLine(Main.Main.currentUser.Username);
                        var stream = File.Open(dlg.FileName, FileMode.Open);
                        var task = new FirebaseStorage("rpcartifactmanager.appspot.com")
                            .Child("Images")
                            .Child(Main.Main.currentUser.Username)
                            .PutAsync(stream);

                        MyProfile.imageUrl = await task;

                        caller.buttonImage.BackgroundImage = SetBackgroungImageUrl(MyProfile.imageUrl);
                        caller.buttonImage.BackgroundImageLayout = ImageLayout.Zoom;
                        caller.buttonImage.Text = "";
                        Console.WriteLine(MyProfile.imageUrl);
                    }

                    if(MyProfile.imageUrl.Length > 0)
                    {
                        caller.buttonImage.Image = null;
                        MyProfileReq.AddImageToUser(MyProfile.imageUrl);
                    }
                    else
                    {
                        caller.buttonImage.Image = Resources.AddUser100;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void FillMyProfile()
        {
            caller.labelFirstName.Text = Main.Main.currentUser.FirstName;
            caller.labelLastName.Text = Main.Main.currentUser.LastName;
            caller.labelUsername.Text = Main.Main.currentUser.Username;
        }
    }
}
