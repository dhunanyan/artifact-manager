using ArtifactManager.Data.Models;
using ArtifactManager.Properties;
using CustomControls.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.Signin
{
    public partial class Signin : Form
    {
        public Main.Main caller;
        public User currentUser;

        SigninController SigninController;
        public SigninStyles SigninStyles;
        public bool isSignIn = false;

        public Signin(Main.Main caller, User currentUser)
        {
            InitializeComponent();
            SigninController = new SigninController(this);
            SigninStyles = new SigninStyles(this);
            this.caller = caller;
            this.currentUser = currentUser;
        }

        private void CustomTextBoxLogin__TextChanged(object sender, EventArgs e)
        {
            SigninStyles.LoginChecker(
                panelLoginCharSpecial,
                panelLoginCharCount,
                customTextBoxLogin.IsCharSpecialPassed.ToString(),
                customTextBoxLogin.IsCharCountPassed.ToString());
        }

        private void CustomTextBoxPassword__TextChanged(object sender, EventArgs e)
        {
            SigninStyles.PasswordChecker(
                panelPasswordCharCapital,
                panelPasswordCharDigit,
                panelPasswordCharSpecial,
                panelPasswordCharCount,
                customTextBoxPassword.IsCharCapitalPassed.ToString(),
                customTextBoxPassword.IsCharDigitPassed.ToString(),
                customTextBoxPassword.IsCharSpecialPassed.ToString(),
                customTextBoxPassword.IsCharCountPassed.ToString());
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            SigninController.AddUser(customTextBoxLogin, customTextBoxPassword, customTextBoxPasswordRepeat, customTextBoxFirstName, customTextBoxLastName);
        }

        private void ButtonSubmitSignin_Click(object sender, EventArgs e)
        {
            caller.currentUser = SigninController.SignInUser(customTextBoxLoginSignin, customTextBoxPasswordSignin);

            caller.MainController.HideSubMenu(new List<Panel> { caller.panelCollectionSubmenu, caller.panelUsersSubmenu });

            Home.Home home = new Home.Home();

        }

        private void ButtonSwitchToSignin_Click(object sender, EventArgs e)
        {
            SigninStyles.SwitchToSignin();
        }

        private void ButtonSwitchToSignup_Click(object sender, EventArgs e)
        {
            SigninStyles.SwitchToSignup();
        }

        public CustomTextBoxLogin customTextBoxLoginSignin;
        public CustomTextBoxPassword customTextBoxPasswordSignin;
        public CustomTextBoxPassword customTextBoxPasswordRepeat;
        public CustomTextBoxLogin customTextBoxLastName;
        public CustomTextBoxLogin customTextBoxFirstName;
        public CustomTextBoxLogin customTextBoxLogin;
        public CustomTextBoxPassword customTextBoxPassword;
        public Panel panelForm;
        public Panel panelFormSignin;
    }
}
