using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteAppLibrary.DataAccess;

namespace NoteAppLibrary
{
    public static class GlobalConfig
    {
        // public const string PrizesFile = "PrizeModels.csv";

        public static IDataConnection Connection { get; set; } 

        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
