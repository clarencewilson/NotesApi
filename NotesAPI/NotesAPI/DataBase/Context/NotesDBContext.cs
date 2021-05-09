using Microsoft.EntityFrameworkCore;
using NotesAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesAPI.DataBase.Context
{
    public class NotesDBContext : DbContext        
    {
        public NotesDBContext(DbContextOptions<NotesDBContext> options) : base(options)
        {

        } 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlite("Data Source=DBNotes.db");

        public DbSet<Note> Notes { get; set; }
    }
}
