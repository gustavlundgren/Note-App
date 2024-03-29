﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppLibrary.Models
{
    public class NoteModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string FileName { get; set; }
        
        public string Content { get; set; }
    }
}