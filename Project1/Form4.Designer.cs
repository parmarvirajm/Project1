namespace Project1
{
    partial class Form4
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
            this.RED = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.BLACK = new System.Windows.Forms.RadioButton();
            this.PINK = new System.Windows.Forms.RadioButton();
            this.CYAM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RED
            // 
            this.RED.AutoSize = true;
            this.RED.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RED.Location = new System.Drawing.Point(26, 33);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(66, 24);
            this.RED.TabIndex = 0;
            this.RED.TabStop = true;
            this.RED.Text = "RED";
            this.RED.UseVisualStyleBackColor = true;
            this.RED.CheckedChanged += new System.EventHandler(this.RED_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.RED);
            this.groupBox1.Location = new System.Drawing.Point(119, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For Color";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blue.Location = new System.Drawing.Point(460, 33);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(64, 24);
            this.Blue.TabIndex = 2;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Green.Location = new System.Drawing.Point(238, 33);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(76, 24);
            this.Green.TabIndex = 1;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // BLACK
            // 
            this.BLACK.AutoSize = true;
            this.BLACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLACK.Location = new System.Drawing.Point(458, 31);
            this.BLACK.Name = "BLACK";
            this.BLACK.Size = new System.Drawing.Size(86, 24);
            this.BLACK.TabIndex = 5;
            this.BLACK.TabStop = true;
            this.BLACK.Text = "BLACK";
            this.BLACK.UseVisualStyleBackColor = true;
            this.BLACK.CheckedChanged += new System.EventHandler(this.BLACK_CheckedChanged);
            // 
            // PINK
            // 
            this.PINK.AutoSize = true;
            this.PINK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINK.Location = new System.Drawing.Point(236, 31);
            this.PINK.Name = "PINK";
            this.PINK.Size = new System.Drawing.Size(68, 24);
            this.PINK.TabIndex = 4;
            this.PINK.TabStop = true;
            this.PINK.Text = "PINK";
            this.PINK.UseVisualStyleBackColor = true;
            this.PINK.CheckedChanged += new System.EventHandler(this.PINK_CheckedChanged);
            // 
            // CYAM
            // 
            this.CYAM.AutoSize = true;
            this.CYAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CYAM.Location = new System.Drawing.Point(24, 31);
            this.CYAM.Name = "CYAM";
            this.CYAM.Size = new System.Drawing.Size(75, 24);
            this.CYAM.TabIndex = 3;
            this.CYAM.TabStop = true;
            this.CYAM.Text = "CYAN";
            this.CYAM.UseVisualStyleBackColor = true;
            this.CYAM.CheckedChanged += new System.EventHandler(this.CYAM_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BLACK);
            this.groupBox2.Controls.Add(this.PINK);
            this.groupBox2.Controls.Add(this.CYAM);
            this.groupBox2.Location = new System.Drawing.Point(113, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Back Color";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RED;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton BLACK;
        private System.Windows.Forms.RadioButton PINK;
        private System.Windows.Forms.RadioButton CYAM;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}