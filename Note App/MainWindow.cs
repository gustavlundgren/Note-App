using NoteAppLibrary;
using NoteAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_App
{
    public partial class MainWindow : Form
    {
        public List<NoteModel> CurrNotes = new List<NoteModel>();
        public UserModel CurrUser = null;

        public MainWindow(string username)
        {
            InitializeComponent();

            usernameLabel.Text = null;
            usernameLabel.Text = username;

            CurrUser = GlobalConfig.Connection.GetUserByName(username);
            CurrNotes = GlobalConfig.Connection.GetNotesByUserId(CurrUser.Id);

            WireUpLists();
        }

        private void WireUpLists() 
        { 
            allNotesListBox.DataSource = null;
            allNotesListBox.DataSource = CurrNotes;
            allNotesListBox.DisplayMember = "Title";
        }

        private void LogOutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void addNewNoteButton_Click(object sender, EventArgs e)
        {
            NoteModel n = new NoteModel();

            n.UserId = CurrUser.Id;
            n.Title = noteTitleValue.Text;
            n.Content = newNoteValue.Text;
            n.FileName = $"{n.Title}_{n.Id}.txt";

            GlobalConfig.Connection.SaveNewNote(n);
            
            CurrNotes.Add(n);

            noteTitleValue.Text = "";
            newNoteValue.Text = "";

            WireUpLists();
        }

        private void openNoteButton_Click(object sender, EventArgs e)
        {
            NoteModel note = (NoteModel)allNotesListBox.SelectedItem;

            MessageBox.Show(note.Content, note.Title, MessageBoxButtons.OK);
        }
    }
}
