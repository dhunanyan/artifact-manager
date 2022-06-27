namespace ArtifactManager.Forms.AllCollection
{
    partial class AllCollection
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelAllRecords = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelEntity = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBarCategory = new System.Windows.Forms.Label();
            this.labelBarEntity = new System.Windows.Forms.Label();
            this.labelBarInfo = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.flowLayoutPanelAllRecords.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();

            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(918, 53);
            this.panelTitle.TabIndex = 3;
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
            // flowLayoutPanelAllRecords
            // 
            this.flowLayoutPanelAllRecords.AutoScroll = true;
            this.flowLayoutPanelAllRecords.AutoScrollMinSize = new System.Drawing.Size(0, 480);
            this.flowLayoutPanelAllRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.flowLayoutPanelAllRecords.Location = new System.Drawing.Point(23, 149);
            this.flowLayoutPanelAllRecords.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelAllRecords.Name = "flowLayoutPanelAllRecords";
            this.flowLayoutPanelAllRecords.Size = new System.Drawing.Size(865, 481);
            this.flowLayoutPanelAllRecords.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 38);
            this.comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 38);
            this.comboBox2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.buttonChangePassword);
            this.panel1.Controls.Add(this.labelEntity);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.flowLayoutPanelAllRecords);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 634);
            this.panel1.TabIndex = 7;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.labelCategory.Location = new System.Drawing.Point(18, 9);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(106, 27);
            this.labelCategory.TabIndex = 7;
            this.labelCategory.Text = "Category";
            // 
            // labelEntity
            // 
            this.labelEntity.AutoSize = true;
            this.labelEntity.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.labelEntity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.labelEntity.Location = new System.Drawing.Point(279, 9);
            this.labelEntity.Name = "labelEntity";
            this.labelEntity.Size = new System.Drawing.Size(73, 27);
            this.labelEntity.TabIndex = 8;
            this.labelEntity.Text = "Entity";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.buttonChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangePassword.FlatAppearance.BorderSize = 0;
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Britannic Bold", 17F);
            this.buttonChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.buttonChangePassword.Location = new System.Drawing.Point(541, 42);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(347, 38);
            this.buttonChangePassword.TabIndex = 9;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel2.Controls.Add(this.labelBarCategory);
            this.flowLayoutPanel2.Controls.Add(this.labelBarEntity);
            this.flowLayoutPanel2.Controls.Add(this.labelBarInfo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(23, 109);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(865, 40);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // labelBarCategory
            // 
            this.labelBarCategory.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.labelBarCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBarCategory.Location = new System.Drawing.Point(0, 0);
            this.labelBarCategory.Margin = new System.Windows.Forms.Padding(0);
            this.labelBarCategory.Name = "labelBarCategory";
            this.labelBarCategory.Size = new System.Drawing.Size(175, 40);
            this.labelBarCategory.TabIndex = 0;
            this.labelBarCategory.Text = "Category";
            this.labelBarCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBarEntity
            // 
            this.labelBarEntity.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.labelBarEntity.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBarEntity.Location = new System.Drawing.Point(175, 0);
            this.labelBarEntity.Margin = new System.Windows.Forms.Padding(0);
            this.labelBarEntity.Name = "labelBarEntity";
            this.labelBarEntity.Size = new System.Drawing.Size(175, 40);
            this.labelBarEntity.TabIndex = 1;
            this.labelBarEntity.Text = "Entity";
            this.labelBarEntity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBarInfo
            // 
            this.labelBarInfo.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.labelBarInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelBarInfo.Location = new System.Drawing.Point(350, 0);
            this.labelBarInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelBarInfo.Name = "labelBarInfo";
            this.labelBarInfo.Size = new System.Drawing.Size(515, 40);
            this.labelBarInfo.TabIndex = 2;
            this.labelBarInfo.Text = "Info";
            this.labelBarInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(918, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.Name = "AllCollection";
            this.Text = "AllCollection";
            this.panelTitle.ResumeLayout(false);
            this.flowLayoutPanelAllRecords.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelEntity;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelBarCategory;
        private System.Windows.Forms.Label labelBarEntity;
        private System.Windows.Forms.Label labelBarInfo;
    }
}