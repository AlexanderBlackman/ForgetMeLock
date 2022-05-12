using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeLock.Backend.Model;
using Microsoft.EntityFrameworkCore;

namespace ForgetMeLock.Backend.Data
{
    public class NoteContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("forgetmelock.db");
        }

        public NoteContext(DbContextOptions<NoteContext>options): base(options) { }

        internal DbSet<Note> Notes { get; set; }
    }
}
