namespace Note_App
{
    partial class LogIn
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
            this.createNewAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LogInButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.TextBox();
            this.logInLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createNewAccountLinkLabel
            // 
            this.createNewAccountLinkLabel.AutoSize = true;
            this.createNewAccountLinkLabel.Location = new System.Drawing.Point(428, 587);
            this.createNewAccountLinkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.createNewAccountLinkLabel.Name = "createNewAccountLinkLabel";
            this.createNewAccountLinkLabel.Size = new System.Drawing.Size(121, 30);
            this.createNewAccountLinkLabel.TabIndex = 13;
            this.createNewAccountLinkLabel.TabStop = true;
            this.createNewAccountLinkLabel.Text = "Create New";
            this.createNewAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewAccountLinkLabel_LinkClicked);
            // 
            // LogInButton
            // 
            this.LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LogInButton.FlatAppearance.BorderSize = 2;
            this.LogInButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.LogInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Location = new System.Drawing.Point(428, 495);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(117, 46);
            this.LogInButton.TabIndex = 12;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(248, 308);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 30);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password";
            // 
            // passwordValue
            // 
            this.passwordValue.Location = new System.Drawing.Point(248, 344);
            this.passwordValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.PasswordChar = '●';
            this.passwordValue.Size = new System.Drawing.Size(477, 35);
            this.passwordValue.TabIndex = 10;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(248, 199);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(106, 30);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // usernameValue
            // 
            this.usernameValue.Location = new System.Drawing.Point(248, 235);
            this.usernameValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(477, 35);
            this.usernameValue.TabIndex = 8;
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.BackColor = System.Drawing.Color.White;
            this.logInLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logInLabel.Location = new System.Drawing.Point(425, 27);
            this.logInLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(122, 47);
            this.logInLabel.TabIndex = 7;
            this.logInLabel.Text = "Log in";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 680);
            this.Controls.Add(this.createNewAccountLinkLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordValue);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameValue);
            this.Controls.Add(this.logInLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LogIn";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel createNewAccountLinkLabel;
        private Button LogInButton;
        private Label passwordLabel;
        private TextBox passwordValue;
        private Label usernameLabel;
        private TextBox usernameValue;
        private Label logInLabel;
    }
}