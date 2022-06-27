using ArtifactManager.Data.Models;
using ArtifactManager.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArtifactManager.Forms.Main
{
    public class MainController
    {
        Main caller;

        MainStyles MainStyles;
        MainReq MainReq;
        public MainController(Main caller)
        {
            this.caller = caller;
            MainReq = new MainReq(caller);
            MainStyles = new MainStyles(caller);
        }
        public void CustomizedDesign(List<Panel> listOfPanels)
        {
            foreach (Panel panel in listOfPanels)
            {
                panel.Visible = false;
            }
        }

        public void HideSubMenu(List<Panel> listOfPanels)
        {
            foreach (Panel panel in listOfPanels)
            {
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
            }
        }

        public void ShowSubMenu(Panel subMenu, List<Panel> listOfPanels)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu(listOfPanels);
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void NavigateToSection(Button clickedButton, Form formToNavigateTo)
        {
            Panel panelContent = (Panel)caller.Controls.Find("panelContent", true)[0];
            panelContent.Controls.Clear();

            MainStyles.ChangeFormStyles(clickedButton, formToNavigateTo);

            panelContent.Controls.Add(formToNavigateTo);
            panelContent.Tag = formToNavigateTo;
            formToNavigateTo.Show();
            formToNavigateTo.BringToFront();
        }

        public void LogoutUser()
        {
            caller.currentUser = null;
            caller.isLoggedIn = false;
        }

        public void SwitchMenuSigninButton(Button buttonSignin, bool isLoggedIn)
        {
            if (!isLoggedIn)
            {
                buttonSignin.Text = "      Sign in";
                buttonSignin.Image = Resources.Signin;
            }
            else
            {
                buttonSignin.Text = "      Logout";
                buttonSignin.Image = Resources.Logout;
            }
        }
    }
}
