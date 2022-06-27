using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Forms.AllCollection
{
    public class AllCollectionStyles
    {
        AllCollection caller;
        public AllCollectionStyles(AllCollection caller)
        {
            this.caller = caller;
        }

        public void GenereateReccordStyles(int index, string category, string entity, string[] attrs)
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            labelRecordCategory = new System.Windows.Forms.Label();
            labelRecordEntity = new System.Windows.Forms.Label();
            panelReccord = new System.Windows.Forms.Panel();
            panelReccord.SuspendLayout();
            caller.flowLayoutPanelAllRecords.Controls.Add(panelReccord);
            panelRecordInfo = new System.Windows.Forms.Panel();
            panelRecordInfo.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3" + "_"+ index.ToString();
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = attrs[0];
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(165, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4" + "_" + index.ToString();
            this.label4.Size = new System.Drawing.Size(166, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = attrs[1];
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(331, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5" + "_" + index.ToString();
            this.label5.Size = new System.Drawing.Size(166, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = attrs[2];
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(2, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6" + "_" + index.ToString();
            this.label6.Size = new System.Drawing.Size(166, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = attrs[3];
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(166, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7" + "_" + index.ToString();
            this.label7.Size = new System.Drawing.Size(166, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = attrs[4];
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(331, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8" + "_" + index.ToString();
            this.label8.Size = new System.Drawing.Size(166, 37);
            this.label8.TabIndex = 7;
            this.label8.Text = attrs[5];
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRecordInfo
            // 
            panelRecordInfo.Controls.Add(label8);
            panelRecordInfo.Controls.Add(label6);
            panelRecordInfo.Controls.Add(label7);
            panelRecordInfo.Controls.Add(label5);
            panelRecordInfo.Controls.Add(label4);
            panelRecordInfo.Controls.Add(label3);
            panelRecordInfo.Location = new System.Drawing.Point(350, 3);
            panelRecordInfo.Margin = new System.Windows.Forms.Padding(0);
            panelRecordInfo.Name = "panelRecordInfo";
            panelRecordInfo.Size = new System.Drawing.Size(498, 71);
            panelRecordInfo.TabIndex = 3;
            panelRecordInfo.ResumeLayout(false);
            // 
            // labelRecordCategory
            // 
            labelRecordCategory.Font = new System.Drawing.Font("Britannic Bold", 18F);
            labelRecordCategory.ForeColor = System.Drawing.Color.Gainsboro;
            labelRecordCategory.Location = new System.Drawing.Point(0, 0);
            labelRecordCategory.Margin = new System.Windows.Forms.Padding(0);
            labelRecordCategory.Name = "labelRecordCategory" + "_" + index.ToString();
            labelRecordCategory.Size = new System.Drawing.Size(175, 74);
            labelRecordCategory.TabIndex = 1;
            labelRecordCategory.Text = category;
            labelRecordCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecordEntity
            // 
            labelRecordEntity.Font = new System.Drawing.Font("Britannic Bold", 18F);
            labelRecordEntity.ForeColor = System.Drawing.Color.Gainsboro;
            labelRecordEntity.Location = new System.Drawing.Point(175, 0);
            labelRecordEntity.Margin = new System.Windows.Forms.Padding(0);
            labelRecordEntity.Name = "labelRecordEntity" + "_" + index.ToString();
            labelRecordEntity.Size = new System.Drawing.Size(175, 74);
            labelRecordEntity.TabIndex = 2;
            labelRecordEntity.Text = entity;
            labelRecordEntity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReccord
            // 
            panelReccord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            panelReccord.Controls.Add(panelRecordInfo);
            panelReccord.Controls.Add(labelRecordEntity);
            panelReccord.Controls.Add(labelRecordCategory);
            panelReccord.Location = new System.Drawing.Point(0, 0);
            panelReccord.Margin = new System.Windows.Forms.Padding(0);
            panelReccord.Name = "panelReccord" + "_" + index.ToString();
            panelReccord.Size = new System.Drawing.Size(848, 78);
            panelReccord.TabIndex = 0;
            panelReccord.ResumeLayout(false);
        }

        public System.Windows.Forms.Panel panelReccord;
        public System.Windows.Forms.Label labelRecordEntity;
        public System.Windows.Forms.Label labelRecordCategory;
        public System.Windows.Forms.Panel panelRecordInfo;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
    }
}
