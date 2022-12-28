using NoteAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppLibrary
{
    public static class SaveNoteFile
    {
        public static void Save(string fileName, string note)
        {
            // Make a list splitted by " " instead of string
            string[] words = note.Split(' ');
            List<string> saveText = fileName.FullFilePath().LoadFile();

            foreach (string word in words)
            {
                saveText.Add(word);
            }

            // TODO - edit files

            File.WriteAllLines(fileName.FullFilePath(), saveText);
        }

        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
    }
}
