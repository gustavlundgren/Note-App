using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteAppLibrary.Models;

namespace NoteAppLibrary.DataAccess
{
    public interface IDataConnection
    {
        UserModel SaveNewUser(UserModel model);

        NoteModel SaveNewNote(NoteModel model);

        List<UserModel> GetUser_All();

        UserModel GetUserById(int id);

        UserModel GetUserByName(string username);

        List<NoteModel> GetNotesByUserId(int userid);

        List<NoteModel> GetNote_All();
    }
}
