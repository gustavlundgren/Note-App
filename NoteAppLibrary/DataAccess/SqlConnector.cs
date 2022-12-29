using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NoteAppLibrary.Models;

namespace NoteAppLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "NoteApp";

        public UserModel SaveNewUser(UserModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Username", model.Username);
                p.Add("@Password", model.Password);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public NoteModel SaveNewNote(NoteModel model) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@UserId", model.UserId);
                p.Add("@Title", model.Title);
                p.Add("@Content", model.Content);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spNotes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public UserModel GetUserById(int id) 
        {
            UserModel output = new UserModel();

            List<UserModel> users = GetUser_All();

            foreach (UserModel user in users)
            {
                if (user.Id == id)
                {
                    output = user;
                }
            }

            return output;
        }

        public UserModel GetUserByName(string username)
        {
            UserModel output = new UserModel();

            List<UserModel> users = GetUser_All();

            foreach (UserModel user in users)
            {
                if (user.Username == username)
                {
                    output = user;
                }
            }

            return output;
        }

        public List<NoteModel> GetNotesByUserId(int userId)
        {
            List<NoteModel> output = new List<NoteModel>();

            List<NoteModel> notes = GetNote_All();

            foreach (NoteModel note in notes) 
            {
                if (note.UserId == userId)
                {
                    output.Add(note);
                }
            }

            return output;
        }

        public List<UserModel> GetUser_All()
        {
            List<UserModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<UserModel>("dbo.spUsers_GetAll").ToList();
            }

            return output;
        }

        public List<NoteModel> GetNote_All()
        {
            List<NoteModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<NoteModel>("dbo.spNotes_GetAll").ToList();
            }

            return output;
        }

        public void DeleteNoteById(int noteid)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@noteId", noteid);

                connection.Execute("dbo.spNotes_Del_By_Id", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
