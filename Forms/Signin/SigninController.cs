using ArtifactManager.Data.Models;
using CustomControls.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager.Forms.Signin
{
    public class SigninController
    {
        Signin caller;
        SigninReq SigninReq;
        SigninStyles SigninStyles;
        public SigninController(Signin caller)
        {
            this.caller = caller;
            SigninReq = new SigninReq(caller);
            SigninStyles = new SigninStyles(caller);
        }

        public void AddUser(CustomTextBoxLogin customTextBoxLogin, CustomTextBoxPassword customTextBoxPassword, CustomTextBoxPassword customTextBoxPasswordRepeat, CustomTextBoxLogin customTextBoxFirstName, CustomTextBoxLogin customTextBoxLastName)
        {
            if(customTextBoxFirstName.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your First Name", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxFirstName.Focus();
            }
            if (customTextBoxLastName.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Last Name", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLastName.Focus();
            }
            if (customTextBoxLogin.CustomText.Length == 0 && customTextBoxPassword.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Login and Password", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin.Focus();
            }
            else if (customTextBoxLogin.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Login", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin.Focus();
            }
            else if (customTextBoxPassword.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Password", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxPassword.Focus();
            }
            else if (Boolean.Parse(customTextBoxPassword.IsCharCapitalPassed.ToString()) &&
               Boolean.Parse(customTextBoxPassword.IsCharDigitPassed.ToString()) &&
               Boolean.Parse(customTextBoxPassword.IsCharSpecialPassed.ToString()) &&
               Boolean.Parse(customTextBoxPassword.IsCharCountPassed.ToString()) &&
               Boolean.Parse(customTextBoxLogin.IsCharSpecialPassed.ToString()) &&
               Boolean.Parse(customTextBoxLogin.IsCharCountPassed.ToString()))
            {
                if(customTextBoxPasswordRepeat.CustomText == customTextBoxPassword.CustomText)
                {
                    if (SigninReq.UserExists(customTextBoxLogin.CustomText))
                    {
                        MessageBox.Show("Error. User with current Username already exists", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        customTextBoxLogin.CustomText = null;
                        customTextBoxPassword.Focus();
                    }
                    else
                    {
                        SigninReq.AddUser(customTextBoxFirstName.CustomText, customTextBoxLastName.CustomText, customTextBoxLogin.CustomText, customTextBoxPassword.CustomText);
                        SigninReq.MakeNewUserGuest(customTextBoxLogin.CustomText);
                        MessageBox.Show("Congratulations you have succesfully created a new account!", "Signup Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        customTextBoxLogin.CustomText = null;
                        customTextBoxPassword.CustomText = null;
                        customTextBoxPasswordRepeat.CustomText = null;
                        customTextBoxFirstName.CustomText = null;
                        customTextBoxLastName.CustomText = null;
                    }
                }
                else
                {
                    MessageBox.Show("Error. Passwords don't match", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customTextBoxPassword.CustomText = null;
                    customTextBoxPasswordRepeat.CustomText = null;
                    customTextBoxPassword.Focus();
                }
            }
            else if ((!Boolean.Parse(customTextBoxLogin.IsCharSpecialPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxLogin.IsCharCountPassed.ToString())) &&
                    (Boolean.Parse(customTextBoxPassword.IsCharCapitalPassed.ToString()) &&
                    Boolean.Parse(customTextBoxPassword.IsCharDigitPassed.ToString()) &&
                    Boolean.Parse(customTextBoxPassword.IsCharSpecialPassed.ToString()) &&
                    Boolean.Parse(customTextBoxPassword.IsCharCountPassed.ToString())))
            {
                MessageBox.Show("Error. Please enter valid Login.", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin.CustomText = null;
                customTextBoxLogin.Focus();
            }
            else if ((!Boolean.Parse(customTextBoxPassword.IsCharCapitalPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxPassword.IsCharDigitPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxPassword.IsCharSpecialPassed.ToString()) ||
                    !Boolean.Parse(customTextBoxPassword.IsCharCountPassed.ToString())) &&
                    (Boolean.Parse(customTextBoxLogin.IsCharSpecialPassed.ToString()) &&
                    Boolean.Parse(customTextBoxLogin.IsCharCountPassed.ToString())))
            {
                MessageBox.Show("Error. Please enter valid Password.", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxPassword.CustomText = null;
                customTextBoxPassword.Focus();

            }
            else
            {
                MessageBox.Show("Error. Please enter valid Credentials.", "Signup Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin.CustomText = null;
                customTextBoxPassword.CustomText = null;
                customTextBoxLogin.Focus();
            }
        }
    
        public void SignInUser(CustomTextBoxLogin customTextBoxLogin, CustomTextBoxPassword customTextBoxPassword)
        {
            if (customTextBoxLogin.CustomText.Length == 0 && customTextBoxPassword.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Login and Password", "Signin Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin.Focus();
            }
            else if (customTextBoxLogin.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Login", "Signin Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin.Focus();
            }
            else if (customTextBoxPassword.CustomText.Length == 0)
            {
                MessageBox.Show("Error. Please enter your Password", "Signin Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxPassword.Focus();
            }
            else if (!SigninReq.UserExists(customTextBoxLogin.CustomText))
            {
                MessageBox.Show("Error. User with current Username doesn't exists", "Signin Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxLogin.CustomText = null;
                customTextBoxLogin.Focus();
            }
            else if (!SigninReq.CheckUserLoginAndPassword(customTextBoxLogin.CustomText, customTextBoxPassword.CustomText))
            {
                MessageBox.Show("Error. Wrong Password", "Signin Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customTextBoxPassword.CustomText = null;
                customTextBoxPassword.Focus();
            }
            else
            {
                MessageBox.Show("Successfully logged in", "Signin Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main.Main.isLoggedIn = true;
                caller.caller.MainController.SwitchMenuSigninButton(caller.caller.buttonSignin, Main.Main.isLoggedIn);
                caller.caller.MainController.NavigateToSection(caller.caller.buttonHome, caller.caller.home);
                Main.Main.currentUser = SigninReq.SignInUser(customTextBoxLogin.CustomText, customTextBoxPassword.CustomText);


                caller.caller.MainStyles.EnableMenuButtons();

                customTextBoxPassword.CustomText = null;
                customTextBoxLogin.CustomText = null;
            }
        }
    }
}
