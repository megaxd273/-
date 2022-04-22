namespace CourseWorkAirlineDB
{
    partial class ProfileForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.systemID = new System.Windows.Forms.Label();
            this.systemName = new System.Windows.Forms.Label();
            this.systemSurname = new System.Windows.Forms.Label();
            this.systemUsername = new System.Windows.Forms.Label();
            this.systemPassword = new System.Windows.Forms.Label();
            this.systemAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWorkAirlineDB.Properties.Resources.George_Floyd;
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(342, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile";
            // 
            // systemID
            // 
            this.systemID.AutoSize = true;
            this.systemID.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemID.Location = new System.Drawing.Point(306, 119);
            this.systemID.Name = "systemID";
            this.systemID.Size = new System.Drawing.Size(35, 21);
            this.systemID.TabIndex = 2;
            this.systemID.Text = "ID:";
            // 
            // systemName
            // 
            this.systemName.AutoSize = true;
            this.systemName.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemName.Location = new System.Drawing.Point(306, 163);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(64, 21);
            this.systemName.TabIndex = 3;
            this.systemName.Text = "Name:";
            // 
            // systemSurname
            // 
            this.systemSurname.AutoSize = true;
            this.systemSurname.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemSurname.Location = new System.Drawing.Point(306, 208);
            this.systemSurname.Name = "systemSurname";
            this.systemSurname.Size = new System.Drawing.Size(99, 21);
            this.systemSurname.TabIndex = 4;
            this.systemSurname.Text = "Surname:";
            // 
            // systemUsername
            // 
            this.systemUsername.AutoSize = true;
            this.systemUsername.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUsername.Location = new System.Drawing.Point(306, 296);
            this.systemUsername.Name = "systemUsername";
            this.systemUsername.Size = new System.Drawing.Size(110, 21);
            this.systemUsername.TabIndex = 5;
            this.systemUsername.Text = "Username:";
            // 
            // systemPassword
            // 
            this.systemPassword.AutoSize = true;
            this.systemPassword.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemPassword.Location = new System.Drawing.Point(306, 341);
            this.systemPassword.Name = "systemPassword";
            this.systemPassword.Size = new System.Drawing.Size(109, 21);
            this.systemPassword.TabIndex = 6;
            this.systemPassword.Text = "Password:";
            // 
            // systemAge
            // 
            this.systemAge.AutoSize = true;
            this.systemAge.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemAge.Location = new System.Drawing.Point(306, 253);
            this.systemAge.Name = "systemAge";
            this.systemAge.Size = new System.Drawing.Size(49, 21);
            this.systemAge.TabIndex = 7;
            this.systemAge.Text = "Age:";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.systemAge);
            this.Controls.Add(this.systemPassword);
            this.Controls.Add(this.systemUsername);
            this.Controls.Add(this.systemSurname);
            this.Controls.Add(this.systemName);
            this.Controls.Add(this.systemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label systemID;
        private System.Windows.Forms.Label systemName;
        private System.Windows.Forms.Label systemSurname;
        private System.Windows.Forms.Label systemUsername;
        private System.Windows.Forms.Label systemPassword;
        private System.Windows.Forms.Label systemAge;
    }
}