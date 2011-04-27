namespace FirstFacebookApplication
{
    partial class Form1
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
            this.lnkTutorial = new System.Windows.Forms.LinkLabel();
            this.btnFacebookLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoginAsDifferentUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnkTutorial
            // 
            this.lnkTutorial.AutoSize = true;
            this.lnkTutorial.Location = new System.Drawing.Point(21, 32);
            this.lnkTutorial.Name = "lnkTutorial";
            this.lnkTutorial.Size = new System.Drawing.Size(454, 13);
            this.lnkTutorial.TabIndex = 0;
            this.lnkTutorial.TabStop = true;
            this.lnkTutorial.Text = "http://blog.prabir.me/post/Facebook-CSharp-SDK-Writing-your-first-Facebook-Applic" +
                "ation.aspx";
            this.lnkTutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTutorial_LinkClicked);
            // 
            // btnFacebookLogin
            // 
            this.btnFacebookLogin.Location = new System.Drawing.Point(92, 70);
            this.btnFacebookLogin.Name = "btnFacebookLogin";
            this.btnFacebookLogin.Size = new System.Drawing.Size(139, 23);
            this.btnFacebookLogin.TabIndex = 1;
            this.btnFacebookLogin.Text = "Login to Facebook";
            this.btnFacebookLogin.UseVisualStyleBackColor = true;
            this.btnFacebookLogin.Click += new System.EventHandler(this.btnFacebookLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "You can read the tutorial on creating this application at ";
            // 
            // btnLoginAsDifferentUser
            // 
            this.btnLoginAsDifferentUser.Location = new System.Drawing.Point(238, 70);
            this.btnLoginAsDifferentUser.Name = "btnLoginAsDifferentUser";
            this.btnLoginAsDifferentUser.Size = new System.Drawing.Size(143, 23);
            this.btnLoginAsDifferentUser.TabIndex = 3;
            this.btnLoginAsDifferentUser.Text = "Login as different user";
            this.btnLoginAsDifferentUser.UseVisualStyleBackColor = true;
            this.btnLoginAsDifferentUser.Click += new System.EventHandler(this.btnLoginAsDifferentUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 114);
            this.Controls.Add(this.btnLoginAsDifferentUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFacebookLogin);
            this.Controls.Add(this.lnkTutorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Facebook C# SDK - Writing your first Facebook Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkTutorial;
        private System.Windows.Forms.Button btnFacebookLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoginAsDifferentUser;
    }
}

