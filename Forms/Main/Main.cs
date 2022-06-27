using ArtifactManager.Data.Models;
using ArtifactManager.Forms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArtifactManager.Forms.Main
{
    public partial class Main : Form
    {
        public MainController MainController;

        public AddPrivilege.AddPrivilege addPrivilege;
        public AddRole.AddRole addRole;
        public AllPrivileges.AllPrivileges allPrivileges;
        public AllRoles.AllRoles allRoles;
        public AllCollection.AllCollection allCollection;
        public AllUsers.AllUsers allUsers;
        public AddEntity.AddEntity addEntity;
        public AddCategory.AddCategory addCategory;
        public Home.Home home;
        public Help.Help help;
        public News.News news;
        public MyCollection.MyCollection myCollection;
        public MyProfile.MyProfile myProfile;
        public Signin.Signin signin;

        public User currentUser;
        public bool isLoggedIn = false;
        public Main()
        {
            InitializeComponent();
            MainController = new MainController(this);
            MainController.CustomizedDesign(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu});

            currentUser = new User();
            home = new Home.Home();
            MainController.NavigateToSection(buttonHome, home);
        }

        //DROPDOWNS
        private void ButtonCollection_Click(object sender, EventArgs e)
        {
            MainController.ShowSubMenu(panelCollectionSubmenu, new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            MainController.ShowSubMenu(panelUsersSubmenu, new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });
        }


        //BUTTONS
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu});

            home = new Home.Home();
            MainController.NavigateToSection(buttonHome, home);
        }

        private void ButtonMyProfile_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            myProfile = new MyProfile.MyProfile();
            MainController.NavigateToSection(buttonMyProfile, myProfile);
        }

        private void ButtonNews_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });
            
            news = new News.News();
            MainController.NavigateToSection(buttonNews, news);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            help = new Help.Help();
            MainController.NavigateToSection(buttonHelp, help);
        }


        //SUBMENU
        private void ButtonAllCollection_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            allCollection = new AllCollection.AllCollection();
            MainController.NavigateToSection(buttonAllCollection, allCollection);
        }

        private void ButtonMyCollection_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            myCollection = new MyCollection.MyCollection();
            MainController.NavigateToSection(buttonMyCollection, myCollection);
        }

        private void ButtonAddCategory_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            addCategory = new AddCategory.AddCategory();
            MainController.NavigateToSection(buttonAddCategory, addCategory);
        }

        private void ButtonAddEntity_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            addEntity = new AddEntity.AddEntity();
            MainController.NavigateToSection(buttonAddEntity, addEntity);
        }

        private void ButtonAllUsers_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            allUsers = new AllUsers.AllUsers();
            MainController.NavigateToSection(buttonAllUsers, allUsers);
        }

        private void ButtonAddRole_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            addRole = new AddRole.AddRole();
            MainController.NavigateToSection(buttonAddRole, addRole);
        }

        private void ButtonAddPrivelege_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            addPrivilege = new AddPrivilege.AddPrivilege();
            MainController.NavigateToSection(buttonAddPrivelege, addPrivilege);
        }

        private void ButtonAllPrivileges_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            allPrivileges = new AllPrivileges.AllPrivileges();
            MainController.NavigateToSection(buttonAllPrivileges, allPrivileges);
        }

        private void ButtonAllRoles_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });

            allRoles = new AllRoles.AllRoles();
            MainController.NavigateToSection(buttonAllRoles, allRoles);
        }

        private void ButtonSignin_Click(object sender, EventArgs e)
        {
            MainController.HideSubMenu(new List<Panel> { panelCollectionSubmenu, panelUsersSubmenu });
            signin = new Signin.Signin(this, currentUser);

            MainController.LogoutUser();

            if (!isLoggedIn)
            {
                MainController.NavigateToSection(buttonSignin, signin);
            }
            else
            {
                MainController.NavigateToSection(buttonSignin, signin);
            }

            MainController.SwitchMenuSigninButton(buttonSignin, false);
        }

        public Button buttonSignin;
        public Panel panelCollectionSubmenu;
        public Button buttonHome;
        public Panel panelUsersSubmenu;
    }
}
