namespace Project1
{
    partial class Form5
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
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.City1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(300, 39);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(258, 22);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "Enter Name";
            //this.Name1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(167, 42);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(144, 73);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Branch
            // 
            this.Branch.AutoSize = true;
            this.Branch.Location = new System.Drawing.Point(162, 103);
            this.Branch.Name = "Branch";
            this.Branch.Size = new System.Drawing.Size(49, 16);
            this.Branch.TabIndex = 3;
            this.Branch.Text = "Branch";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(159, 230);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(52, 16);
            this.Gender.TabIndex = 4;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(416, 113);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(29, 16);
            this.City.TabIndex = 5;
            this.City.Text = "City";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(300, 73);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(258, 22);
            this.Pass.TabIndex = 6;
            this.Pass.Text = "Enter Password";
            this.Pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(253, 109);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(97, 101);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(246, 242);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(58, 20);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(365, 242);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(74, 20);
            this.Female.TabIndex = 10;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // City1
            // 
            this.City1.Location = new System.Drawing.Point(465, 113);
            this.City1.Multiline = true;
            this.City1.Name = "City1";
            this.City1.Size = new System.Drawing.Size(126, 28);
            this.City1.TabIndex = 11;
            this.City1.Text = "City";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.City1);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Branch);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Name1);
           // this.Name = "Form5";
           // this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Branch;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.TextBox City1;
    }
}