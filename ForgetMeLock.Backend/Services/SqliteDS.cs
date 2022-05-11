using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeLock.Backend.Model;
using ForgetMeLock.Backend.Data;

namespace ForgetMeLock.Backend.Services
{
    public class SqliteDS
    {
        private readonly NoteContext context;

        public SqliteDS (NoteContext dbContext)
        {
            this.context = dbContext;
            this.context.Database.EnsureCreated();
        }

        public IEnumerable<Note> GetAll()
        {
            return this.context.Notes.AsEnumerable();
        }

        public async Task<Note> GetByIdAsync(int id)
        {
            return await this.context.Notes.Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpsertAsync(Note note)
        {
            //obviously this forbids last name changes
            await this.context.Notes.Upsert(note).On(e => new { e.FirstName, e.LastName }).RunAsync();

        }

        public async Task DeleteAsync(int id)
        {
            var note = await GetByIdAsync(id);
            if (note != null)
            {
                this.context.Notes.Remove(note);
                await this.context.SaveChangesAsync();
            }
            else
            {
                Debug.WriteLine($"Failed to delete id {id}");
            }
        }
    }
}
