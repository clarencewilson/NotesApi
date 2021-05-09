using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesAPI.DTO
{
    public class CreateNoteDTO
    {
        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
