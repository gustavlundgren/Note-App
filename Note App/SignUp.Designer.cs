namespace Note_App
{
    partial class SignUp
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
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameValue = new System.Windows.Forms.TextBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.signUpButton.FlatAppearance.BorderSize = 2;
            this.signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Location = new System.Drawing.Point(412, 513);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(117, 46);
            this.signUpButton.TabIndex = 19;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(232, 326);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 30);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";
            // 
            // passwordValue
            // 
            this.passwordValue.Location = new System.Drawing.Point(232, 362);
            this.passwordValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.PasswordChar = '●';
            this.passwordValue.Size = new System.Drawing.Size(477, 35);
            this.passwordValue.TabIndex = 17;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(232, 217);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(106, 30);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Username";
            // 
            // usernameValue
            // 
            this.usernameValue.Location = new System.Drawing.Point(232, 253);
            this.usernameValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.usernameValue.Name = "usernameValue";
            this.usernameValue.Size = new System.Drawing.Size(477, 35);
            this.usernameValue.TabIndex = 15;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.White;
            this.signUpLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpLabel.Location = new System.Drawing.Point(409, 45);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(150, 47);
            this.signUpLabel.TabIndex = 14;
            this.signUpLabel.Text = "Sign Up";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 680);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordValue);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameValue);
            this.Controls.Add(this.signUpLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SignUp";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button signUpButton;
        private Label passwordLabel;
        private TextBox passwordValue;
        private Label usernameLabel;
        private TextBox usernameValue;
        private Label signUpLabel;
    }
}