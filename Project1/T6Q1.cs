using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CustomerFeedbackApp
{
    public partial class T6Q1 : Form
    {
        public T6Q1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = base.Name.Text.Trim();
            string title = Male.Checked ? "Mr." : Female.Checked ? "Miss" : "";

            // Collect selected sources
            List<string> sources = new List<string>();
            if (chkNewspaper.Checked) sources.Add("Newspaper");
            if (chkFriends.Checked) sources.Add("Friends");
            if (chkWebsite.Checked) sources.Add("Website");
            if (chkOthers.Checked && !string.IsNullOrWhiteSpace(txtOther.Text))
                sources.Add(txtOther.Text);

            // Join all selected sources
            string sourceInfo = string.Join(", ", sources);

            // Final message
            lblResult.Text = $"Hello {title} {name}. You know about us from {sourceInfo}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewsPaper = new System.Windows.Forms.CheckBox();
            this.Friends = new System.Windows.Forms.CheckBox();
            this.Website = new System.Windows.Forms.CheckBox();
            this.Other = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(197, 77);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(189, 140);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 16);
            this.Gender.TabIndex = 2;
            this.Gender.Text = "Gender";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(269, 140);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(58, 20);
            this.Male.TabIndex = 3;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(362, 140);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(74, 20);
            this.Female.TabIndex = 4;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Other);
            this.groupBox1.Controls.Add(this.Website);
            this.groupBox1.Controls.Add(this.Friends);
            this.groupBox1.Controls.Add(this.NewsPaper);
            this.groupBox1.Location = new System.Drawing.Point(270, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Of Information";
            // 
            // NewsPaper
            // 
            this.NewsPaper.AutoSize = true;
            this.NewsPaper.Location = new System.Drawing.Point(17, 21);
            this.NewsPaper.Name = "NewsPaper";
            this.NewsPaper.Size = new System.Drawing.Size(100, 20);
            this.NewsPaper.TabIndex = 1;
            this.NewsPaper.Text = "NewsPaper";
            this.NewsPaper.UseVisualStyleBackColor = true;
            // 
            // Friends
            // 
            this.Friends.AutoSize = true;
            this.Friends.Location = new System.Drawing.Point(140, 21);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(74, 20);
            this.Friends.TabIndex = 2;
            this.Friends.Text = "Friends";
            this.Friends.UseVisualStyleBackColor = true;
            // 
            // Website
            // 
            this.Website.AutoSize = true;
            this.Website.Location = new System.Drawing.Point(17, 57);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(79, 20);
            this.Website.TabIndex = 3;
            this.Website.Text = "Website";
            this.Website.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(140, 57);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(61, 20);
            this.Other.TabIndex = 4;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 309);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "If other Specify";
            // 
            // T6Q1
            // 
            this.ClientSize = new System.Drawing.Size(843, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox1);
            this.Name = "T6Q1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 
    }
}
