using ArtifactManager.Properties;
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
        SigninController SigninController;
        SigninStyles SigninStyles;

        public Signin()
        {
            InitializeComponent();
            SigninController = new SigninController(this);
            SigninStyles = new SigninStyles(this);
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
    }
}
