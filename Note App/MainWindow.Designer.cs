namespace Note_App
{
    partial class MainWindow
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.addNewNoteButton = new System.Windows.Forms.Button();
            this.allNotesListBox = new System.Windows.Forms.ListBox();
            this.newNoteValue = new System.Windows.Forms.TextBox();
            this.newNoteLabel = new System.Windows.Forms.Label();
            this.openNoteButton = new System.Windows.Forms.Button();
            this.allNotesLabel = new System.Windows.Forms.Label();
            this.LogOutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.noteTitleValue = new System.Windows.Forms.TextBox();
            this.noteTitleLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.White;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(14, 9);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(172, 47);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Welcome";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(175, 9);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(161, 47);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "<name>";
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteSelectedButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton.Location = new System.Drawing.Point(818, 568);
            this.deleteSelectedButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(117, 77);
            this.deleteSelectedButton.TabIndex = 20;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // addNewNoteButton
            // 
            this.addNewNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addNewNoteButton.FlatAppearance.BorderSize = 2;
            this.addNewNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.addNewNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addNewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewNoteButton.Location = new System.Drawing.Point(183, 571);
            this.addNewNoteButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addNewNoteButton.Name = "addNewNoteButton";
            this.addNewNoteButton.Size = new System.Drawing.Size(117, 46);
            this.addNewNoteButton.TabIndex = 21;
            this.addNewNoteButton.Text = "Add Note";
            this.addNewNoteButton.UseVisualStyleBackColor = true;
            this.addNewNoteButton.Click += new System.EventHandler(this.addNewNoteButton_Click);
            // 
            // allNotesListBox
            // 
            this.allNotesListBox.FormattingEnabled = true;
            this.allNotesListBox.ItemHeight = 30;
            this.allNotesListBox.Location = new System.Drawing.Point(580, 75);
            this.allNotesListBox.Name = "allNotesListBox";
            this.allNotesListBox.Size = new System.Drawing.Size(418, 484);
            this.allNotesListBox.TabIndex = 22;
            // 
            // newNoteValue
            // 
            this.newNoteValue.Location = new System.Drawing.Point(41, 271);
            this.newNoteValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.newNoteValue.Name = "newNoteValue";
            this.newNoteValue.Size = new System.Drawing.Size(400, 35);
            this.newNoteValue.TabIndex = 23;
            // 
            // newNoteLabel
            // 
            this.newNoteLabel.AutoSize = true;
            this.newNoteLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newNoteLabel.Location = new System.Drawing.Point(41, 123);
            this.newNoteLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.newNoteLabel.Name = "newNoteLabel";
            this.newNoteLabel.Size = new System.Drawing.Size(107, 30);
            this.newNoteLabel.TabIndex = 24;
            this.newNoteLabel.Text = "New Note";
            // 
            // openNoteButton
            // 
            this.openNoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openNoteButton.FlatAppearance.BorderSize = 2;
            this.openNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.openNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.openNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openNoteButton.Location = new System.Drawing.Point(691, 568);
            this.openNoteButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.openNoteButton.Name = "openNoteButton";
            this.openNoteButton.Size = new System.Drawing.Size(117, 77);
            this.openNoteButton.TabIndex = 25;
            this.openNoteButton.Text = "Open Selected";
            this.openNoteButton.UseVisualStyleBackColor = true;
            this.openNoteButton.Click += new System.EventHandler(this.openNoteButton_Click);
            // 
            // allNotesLabel
            // 
            this.allNotesLabel.AutoSize = true;
            this.allNotesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allNotesLabel.Location = new System.Drawing.Point(580, 42);
            this.allNotesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.allNotesLabel.Name = "allNotesLabel";
            this.allNotesLabel.Size = new System.Drawing.Size(98, 30);
            this.allNotesLabel.TabIndex = 26;
            this.allNotesLabel.Text = "All Notes";
            // 
            // LogOutLinkLabel
            // 
            this.LogOutLinkLabel.AutoSize = true;
            this.LogOutLinkLabel.Location = new System.Drawing.Point(958, 9);
            this.LogOutLinkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LogOutLinkLabel.Name = "LogOutLinkLabel";
            this.LogOutLinkLabel.Size = new System.Drawing.Size(88, 30);
            this.LogOutLinkLabel.TabIndex = 27;
            this.LogOutLinkLabel.TabStop = true;
            this.LogOutLinkLabel.Text = "Log Out";
            this.LogOutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutLinkLabel_LinkClicked);
            // 
            // noteTitleValue
            // 
            this.noteTitleValue.Location = new System.Drawing.Point(41, 207);
            this.noteTitleValue.Name = "noteTitleValue";
            this.noteTitleValue.Size = new System.Drawing.Size(400, 35);
            this.noteTitleValue.TabIndex = 28;
            // 
            // noteTitleLable
            // 
            this.noteTitleLable.AutoSize = true;
            this.noteTitleLable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteTitleLable.Location = new System.Drawing.Point(41, 179);
            this.noteTitleLable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.noteTitleLable.Name = "noteTitleLable";
            this.noteTitleLable.Size = new System.Drawing.Size(48, 25);
            this.noteTitleLable.TabIndex = 29;
            this.noteTitleLable.Text = "Title";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 703);
            this.Controls.Add(this.noteTitleLable);
            this.Controls.Add(this.noteTitleValue);
            this.Controls.Add(this.LogOutLinkLabel);
            this.Controls.Add(this.allNotesLabel);
            this.Controls.Add(this.openNoteButton);
            this.Controls.Add(this.newNoteLabel);
            this.Controls.Add(this.newNoteValue);
            this.Controls.Add(this.allNotesListBox);
            this.Controls.Add(this.addNewNoteButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Label usernameLabel;
        private Button deleteSelectedButton;
        private Button addNewNoteButton;
        private ListBox allNotesListBox;
        private TextBox newNoteValue;
        private Label newNoteLabel;
        private Button openNoteButton;
        private Label allNotesLabel;
        private LinkLabel LogOutLinkLabel;
        private TextBox noteTitleValue;
        private Label noteTitleLable;
    }
}