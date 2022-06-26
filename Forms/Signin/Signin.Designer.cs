namespace ArtifactManager.Forms.Signin
{
    partial class Signin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.customTextBoxLogin = new CustomControls.Controls.CustomTextBoxLogin();
            this.customTextBoxPassword = new CustomControls.Controls.CustomTextBoxPassword();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelPasswordCharCount = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.panelLoginCharSpecial = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordCharDigit = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelPasswordCharSpecial = new System.Windows.Forms.Panel();
            this.panelFormTitle = new System.Windows.Forms.Panel();
            this.labelFormTItle = new System.Windows.Forms.Label();
            this.labelLoginCharCount = new System.Windows.Forms.Label();
            this.panelPasswordCharCapital = new System.Windows.Forms.Panel();
            this.labelPasswordCharCapital = new System.Windows.Forms.Label();
            this.panelPasswordCharDigit = new System.Windows.Forms.Panel();
            this.labelLoginCharSpecial = new System.Windows.Forms.Label();
            this.labelPasswordCharSpecial = new System.Windows.Forms.Label();
            this.panelPasswordCharCount = new System.Windows.Forms.Panel();
            this.panelLoginCharCount = new System.Windows.Forms.Panel();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.customTextBoxPasswordRepeat = new CustomControls.Controls.CustomTextBoxPassword();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.customTextBoxFirstName = new CustomControls.Controls.CustomTextBoxLogin();
            this.labelLastName = new System.Windows.Forms.Label();
            this.customTextBoxLastName = new CustomControls.Controls.CustomTextBoxLogin();
            this.panelTitle.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelFormTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // customTextBoxLogin
            // 
            this.customTextBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.customTextBoxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.customTextBoxLogin.BorderSize = 2;
            this.customTextBoxLogin.CustomText = "";
            this.customTextBoxLogin.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.customTextBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.customTextBoxLogin.IsCharCountPassed = false;
            this.customTextBoxLogin.IsCharSpecialPassed = false;
            this.customTextBoxLogin.Location = new System.Drawing.Point(18, 224);
            this.customTextBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBoxLogin.Multiline = false;
            this.customTextBoxLogin.Name = "customTextBoxLogin";
            this.customTextBoxLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.customTextBoxLogin.Size = new System.Drawing.Size(515, 30);
            this.customTextBoxLogin.TabIndex = 0;
            this.customTextBoxLogin.UnderlinedStyle = true;
            this.customTextBoxLogin._TextChanged += new System.EventHandler(this.CustomTextBoxLogin__TextChanged);
            // 
            // customTextBoxPassword
            // 
            this.customTextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.customTextBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.customTextBoxPassword.BorderSize = 2;
            this.customTextBoxPassword.CustomText = "";
            this.customTextBoxPassword.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.customTextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.customTextBoxPassword.IsCharCapitalPassed = false;
            this.customTextBoxPassword.IsCharCountPassed = false;
            this.customTextBoxPassword.IsCharDigitPassed = false;
            this.customTextBoxPassword.IsCharSpecialPassed = false;
            this.customTextBoxPassword.Location = new System.Drawing.Point(18, 344);
            this.customTextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBoxPassword.Multiline = false;
            this.customTextBoxPassword.Name = "customTextBoxPassword";
            this.customTextBoxPassword.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.customTextBoxPassword.PasswordChar = true;
            this.customTextBoxPassword.Size = new System.Drawing.Size(515, 30);
            this.customTextBoxPassword.TabIndex = 1;
            this.customTextBoxPassword.UnderlinedStyle = true;
            this.customTextBoxPassword._TextChanged += new System.EventHandler(this.CustomTextBoxPassword__TextChanged);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(918, 53);
            this.panelTitle.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(918, 53);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForm
            // 
            this.panelForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.panelForm.Controls.Add(this.labelLastName);
            this.panelForm.Controls.Add(this.customTextBoxLastName);
            this.panelForm.Controls.Add(this.labelFirstName);
            this.panelForm.Controls.Add(this.customTextBoxFirstName);
            this.panelForm.Controls.Add(this.labelRepeatPassword);
            this.panelForm.Controls.Add(this.customTextBoxPasswordRepeat);
            this.panelForm.Controls.Add(this.labelPasswordCharCount);
            this.panelForm.Controls.Add(this.buttonSubmit);
            this.panelForm.Controls.Add(this.panelLoginCharSpecial);
            this.panelForm.Controls.Add(this.labelPassword);
            this.panelForm.Controls.Add(this.panelLoginCharCount);
            this.panelForm.Controls.Add(this.labelPasswordCharDigit);
            this.panelForm.Controls.Add(this.labelLoginCharSpecial);
            this.panelForm.Controls.Add(this.labelLoginCharCount);
            this.panelForm.Controls.Add(this.labelUsername);
            this.panelForm.Controls.Add(this.panelPasswordCharSpecial);
            this.panelForm.Controls.Add(this.panelFormTitle);
            this.panelForm.Controls.Add(this.customTextBoxLogin);
            this.panelForm.Controls.Add(this.panelPasswordCharCapital);
            this.panelForm.Controls.Add(this.customTextBoxPassword);
            this.panelForm.Controls.Add(this.labelPasswordCharCapital);
            this.panelForm.Controls.Add(this.panelPasswordCharDigit);
            this.panelForm.Controls.Add(this.labelPasswordCharSpecial);
            this.panelForm.Controls.Add(this.panelPasswordCharCount);
            this.panelForm.Location = new System.Drawing.Point(177, 59);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(555, 621);
            this.panelForm.TabIndex = 5;
            // 
            // labelPasswordCharCount
            // 
            this.labelPasswordCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharCount.Location = new System.Drawing.Point(72, 394);
            this.labelPasswordCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharCount.Name = "labelPasswordCharCount";
            this.labelPasswordCharCount.Size = new System.Drawing.Size(144, 20);
            this.labelPasswordCharCount.TabIndex = 20;
            this.labelPasswordCharCount.Text = "at least 8 characters";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.buttonSubmit.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSubmit.Location = new System.Drawing.Point(18, 553);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(515, 46);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // panelLoginCharSpecial
            // 
            this.panelLoginCharSpecial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLoginCharSpecial.BackgroundImage")));
            this.panelLoginCharSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLoginCharSpecial.Location = new System.Drawing.Point(270, 264);
            this.panelLoginCharSpecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLoginCharSpecial.Name = "panelLoginCharSpecial";
            this.panelLoginCharSpecial.Size = new System.Drawing.Size(38, 38);
            this.panelLoginCharSpecial.TabIndex = 31;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelPassword.Location = new System.Drawing.Point(14, 314);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(519, 26);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPasswordCharDigit
            // 
            this.labelPasswordCharDigit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharDigit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharDigit.Location = new System.Drawing.Point(76, 440);
            this.labelPasswordCharDigit.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharDigit.Name = "labelPasswordCharDigit";
            this.labelPasswordCharDigit.Size = new System.Drawing.Size(140, 20);
            this.labelPasswordCharDigit.TabIndex = 21;
            this.labelPasswordCharDigit.Text = "at least one digit";
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelUsername.Location = new System.Drawing.Point(14, 194);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(519, 26);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelPasswordCharSpecial
            // 
            this.panelPasswordCharSpecial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordCharSpecial.BackgroundImage")));
            this.panelPasswordCharSpecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharSpecial.Location = new System.Drawing.Point(270, 429);
            this.panelPasswordCharSpecial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPasswordCharSpecial.Name = "panelPasswordCharSpecial";
            this.panelPasswordCharSpecial.Size = new System.Drawing.Size(38, 38);
            this.panelPasswordCharSpecial.TabIndex = 25;
            // 
            // panelFormTitle
            // 
            this.panelFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.panelFormTitle.Controls.Add(this.labelFormTItle);
            this.panelFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormTitle.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.panelFormTitle.Location = new System.Drawing.Point(0, 0);
            this.panelFormTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormTitle.Name = "panelFormTitle";
            this.panelFormTitle.Size = new System.Drawing.Size(555, 34);
            this.panelFormTitle.TabIndex = 2;
            // 
            // labelFormTItle
            // 
            this.labelFormTItle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFormTItle.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.labelFormTItle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.labelFormTItle.Location = new System.Drawing.Point(0, 0);
            this.labelFormTItle.Margin = new System.Windows.Forms.Padding(0);
            this.labelFormTItle.Name = "labelFormTItle";
            this.labelFormTItle.Size = new System.Drawing.Size(555, 34);
            this.labelFormTItle.TabIndex = 0;
            this.labelFormTItle.Text = "SIGN UP";
            this.labelFormTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoginCharCount
            // 
            this.labelLoginCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginCharCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelLoginCharCount.Location = new System.Drawing.Point(76, 273);
            this.labelLoginCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoginCharCount.Name = "labelLoginCharCount";
            this.labelLoginCharCount.Size = new System.Drawing.Size(140, 20);
            this.labelLoginCharCount.TabIndex = 28;
            this.labelLoginCharCount.Text = "8 - 16 characters";
            // 
            // panelPasswordCharCapital
            // 
            this.panelPasswordCharCapital.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordCharCapital.BackgroundImage")));
            this.panelPasswordCharCapital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharCapital.Location = new System.Drawing.Point(270, 383);
            this.panelPasswordCharCapital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPasswordCharCapital.Name = "panelPasswordCharCapital";
            this.panelPasswordCharCapital.Size = new System.Drawing.Size(38, 38);
            this.panelPasswordCharCapital.TabIndex = 26;
            // 
            // labelPasswordCharCapital
            // 
            this.labelPasswordCharCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharCapital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharCapital.Location = new System.Drawing.Point(309, 394);
            this.labelPasswordCharCapital.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharCapital.Name = "labelPasswordCharCapital";
            this.labelPasswordCharCapital.Size = new System.Drawing.Size(185, 20);
            this.labelPasswordCharCapital.TabIndex = 22;
            this.labelPasswordCharCapital.Text = "at least one capital letter";
            // 
            // panelPasswordCharDigit
            // 
            this.panelPasswordCharDigit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordCharDigit.BackgroundImage")));
            this.panelPasswordCharDigit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharDigit.Location = new System.Drawing.Point(30, 429);
            this.panelPasswordCharDigit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPasswordCharDigit.Name = "panelPasswordCharDigit";
            this.panelPasswordCharDigit.Size = new System.Drawing.Size(38, 38);
            this.panelPasswordCharDigit.TabIndex = 27;
            // 
            // labelLoginCharSpecial
            // 
            this.labelLoginCharSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginCharSpecial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelLoginCharSpecial.Location = new System.Drawing.Point(309, 275);
            this.labelLoginCharSpecial.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoginCharSpecial.Name = "labelLoginCharSpecial";
            this.labelLoginCharSpecial.Size = new System.Drawing.Size(185, 20);
            this.labelLoginCharSpecial.TabIndex = 29;
            this.labelLoginCharSpecial.Text = "don\'t use ?),+!#@$%^&/(";
            // 
            // labelPasswordCharSpecial
            // 
            this.labelPasswordCharSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPasswordCharSpecial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132)))));
            this.labelPasswordCharSpecial.Location = new System.Drawing.Point(309, 440);
            this.labelPasswordCharSpecial.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordCharSpecial.Name = "labelPasswordCharSpecial";
            this.labelPasswordCharSpecial.Size = new System.Drawing.Size(185, 20);
            this.labelPasswordCharSpecial.TabIndex = 23;
            this.labelPasswordCharSpecial.Text = "at least one special character";
            // 
            // panelPasswordCharCount
            // 
            this.panelPasswordCharCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPasswordCharCount.BackgroundImage")));
            this.panelPasswordCharCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPasswordCharCount.Location = new System.Drawing.Point(30, 383);
            this.panelPasswordCharCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPasswordCharCount.Name = "panelPasswordCharCount";
            this.panelPasswordCharCount.Size = new System.Drawing.Size(38, 38);
            this.panelPasswordCharCount.TabIndex = 24;
            // 
            // panelLoginCharCount
            // 
            this.panelLoginCharCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLoginCharCount.BackgroundImage")));
            this.panelLoginCharCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLoginCharCount.Location = new System.Drawing.Point(30, 263);
            this.panelLoginCharCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLoginCharCount.Name = "panelLoginCharCount";
            this.panelLoginCharCount.Size = new System.Drawing.Size(38, 38);
            this.panelLoginCharCount.TabIndex = 30;
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.labelRepeatPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelRepeatPassword.Location = new System.Drawing.Point(14, 476);
            this.labelRepeatPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(519, 26);
            this.labelRepeatPassword.TabIndex = 33;
            this.labelRepeatPassword.Text = "Repeat Password";
            this.labelRepeatPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customTextBoxPasswordRepeat
            // 
            this.customTextBoxPasswordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.customTextBoxPasswordRepeat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.customTextBoxPasswordRepeat.BorderSize = 2;
            this.customTextBoxPasswordRepeat.CustomText = "";
            this.customTextBoxPasswordRepeat.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.customTextBoxPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.customTextBoxPasswordRepeat.IsCharCapitalPassed = false;
            this.customTextBoxPasswordRepeat.IsCharCountPassed = false;
            this.customTextBoxPasswordRepeat.IsCharDigitPassed = false;
            this.customTextBoxPasswordRepeat.IsCharSpecialPassed = false;
            this.customTextBoxPasswordRepeat.Location = new System.Drawing.Point(18, 506);
            this.customTextBoxPasswordRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBoxPasswordRepeat.Multiline = false;
            this.customTextBoxPasswordRepeat.Name = "customTextBoxPasswordRepeat";
            this.customTextBoxPasswordRepeat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.customTextBoxPasswordRepeat.PasswordChar = true;
            this.customTextBoxPasswordRepeat.Size = new System.Drawing.Size(515, 30);
            this.customTextBoxPasswordRepeat.TabIndex = 32;
            this.customTextBoxPasswordRepeat.UnderlinedStyle = true;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelFirstName.Location = new System.Drawing.Point(14, 46);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(519, 26);
            this.labelFirstName.TabIndex = 35;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customTextBoxFirstName
            // 
            this.customTextBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.customTextBoxFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.customTextBoxFirstName.BorderSize = 2;
            this.customTextBoxFirstName.CustomText = "";
            this.customTextBoxFirstName.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.customTextBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.customTextBoxFirstName.IsCharCountPassed = false;
            this.customTextBoxFirstName.IsCharSpecialPassed = false;
            this.customTextBoxFirstName.Location = new System.Drawing.Point(18, 76);
            this.customTextBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBoxFirstName.Multiline = false;
            this.customTextBoxFirstName.Name = "customTextBoxFirstName";
            this.customTextBoxFirstName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.customTextBoxFirstName.Size = new System.Drawing.Size(515, 30);
            this.customTextBoxFirstName.TabIndex = 34;
            this.customTextBoxFirstName.UnderlinedStyle = true;
            // 
            // labelLastName
            // 
            this.labelLastName.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.labelLastName.Location = new System.Drawing.Point(14, 121);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(519, 26);
            this.labelLastName.TabIndex = 37;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customTextBoxLastName
            // 
            this.customTextBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.customTextBoxLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.customTextBoxLastName.BorderSize = 2;
            this.customTextBoxLastName.CustomText = "";
            this.customTextBoxLastName.Font = new System.Drawing.Font("Britannic Bold", 14.25F);
            this.customTextBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.customTextBoxLastName.IsCharCountPassed = false;
            this.customTextBoxLastName.IsCharSpecialPassed = false;
            this.customTextBoxLastName.Location = new System.Drawing.Point(18, 151);
            this.customTextBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBoxLastName.Multiline = false;
            this.customTextBoxLastName.Name = "customTextBoxLastName";
            this.customTextBoxLastName.Padding = new System.Windows.Forms.Padding(2, 2, 2, 6);
            this.customTextBoxLastName.Size = new System.Drawing.Size(515, 30);
            this.customTextBoxLastName.TabIndex = 36;
            this.customTextBoxLastName.UnderlinedStyle = true;
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(918, 692);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTitle);
            this.Name = "Signin";
            this.Text = "Signin";
            this.panelTitle.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelFormTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private CustomControls.Controls.CustomTextBoxLogin customTextBoxLogin;
        private CustomControls.Controls.CustomTextBoxPassword customTextBoxPassword;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelFormTitle;
        private System.Windows.Forms.Label labelFormTItle;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPasswordCharCount;
        private System.Windows.Forms.Panel panelLoginCharSpecial;
        private System.Windows.Forms.Label labelPasswordCharDigit;
        private System.Windows.Forms.Panel panelPasswordCharSpecial;
        private System.Windows.Forms.Label labelLoginCharCount;
        private System.Windows.Forms.Panel panelPasswordCharCapital;
        private System.Windows.Forms.Label labelPasswordCharCapital;
        private System.Windows.Forms.Panel panelPasswordCharDigit;
        private System.Windows.Forms.Label labelPasswordCharSpecial;
        private System.Windows.Forms.Panel panelLoginCharCount;
        private System.Windows.Forms.Panel panelPasswordCharCount;
        private System.Windows.Forms.Label labelLoginCharSpecial;
        private System.Windows.Forms.Label labelRepeatPassword;
        private CustomControls.Controls.CustomTextBoxPassword customTextBoxPasswordRepeat;
        private System.Windows.Forms.Label labelLastName;
        private CustomControls.Controls.CustomTextBoxLogin customTextBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private CustomControls.Controls.CustomTextBoxLogin customTextBoxFirstName;
    }
}