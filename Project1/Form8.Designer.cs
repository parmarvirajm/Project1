namespace Project1
{
    partial class Form8
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
            this.Enroll_No = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.Label();
            this.Enroll_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Age_TextBox = new System.Windows.Forms.TextBox();
            this.CIty_TextBox = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enroll_No
            // 
            this.Enroll_No.AutoSize = true;
            this.Enroll_No.Location = new System.Drawing.Point(143, 51);
            this.Enroll_No.Name = "Enroll_No";
            this.Enroll_No.Size = new System.Drawing.Size(66, 16);
            this.Enroll_No.TabIndex = 0;
            this.Enroll_No.Text = "Enroll_No";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(143, 92);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(143, 135);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(32, 16);
            this.Age.TabIndex = 2;
            this.Age.Text = "Age";
            this.Age.Click += new System.EventHandler(this.label3_Click);
            // 
            // City
            // 
            this.City.AutoSize = true;
            this.City.Location = new System.Drawing.Point(143, 181);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(29, 16);
            this.City.TabIndex = 3;
            this.City.Text = "City";
            // 
            // Enroll_TextBox
            // 
            this.Enroll_TextBox.Location = new System.Drawing.Point(238, 51);
            this.Enroll_TextBox.Name = "Enroll_TextBox";
            this.Enroll_TextBox.Size = new System.Drawing.Size(292, 22);
            this.Enroll_TextBox.TabIndex = 4;
            this.Enroll_TextBox.Text = "Enroll_TextBox";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(238, 92);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(292, 22);
            this.Name_TextBox.TabIndex = 5;
            this.Name_TextBox.Text = "Name_TextBox";
            // 
            // Age_TextBox
            // 
            this.Age_TextBox.Location = new System.Drawing.Point(238, 135);
            this.Age_TextBox.Name = "Age_TextBox";
            this.Age_TextBox.Size = new System.Drawing.Size(292, 22);
            this.Age_TextBox.TabIndex = 6;
            this.Age_TextBox.Text = "Age_TextBox";
            // 
            // CIty_TextBox
            // 
            this.CIty_TextBox.Location = new System.Drawing.Point(238, 181);
            this.CIty_TextBox.Name = "CIty_TextBox";
            this.CIty_TextBox.Size = new System.Drawing.Size(292, 22);
            this.CIty_TextBox.TabIndex = 7;
            this.CIty_TextBox.Text = "CIty_TextBox";
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(173, 254);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(270, 254);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(363, 254);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(487, 254);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.CIty_TextBox);
            this.Controls.Add(this.Age_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Enroll_TextBox);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Enroll_No);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enroll_No;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label City;
        private System.Windows.Forms.TextBox Enroll_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Age_TextBox;
        private System.Windows.Forms.TextBox CIty_TextBox;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Reset;
    }
}