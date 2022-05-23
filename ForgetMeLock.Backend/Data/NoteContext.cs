using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeLock.Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace ForgetMeLock.Backend.Data
{
    public class NoteContext : DbContext
    {

        public string DbPath { get; set; }

        public NoteContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "forgetmelock.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source ={DbPath}");
        }

        // public NoteContext(DbContextOptions<NoteContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
