using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeLock.Backend.Model;

namespace ForgetMeLock.Backend.Contracts
{
    public interface IDataService
    {
        IEnumerable<Note> GetAll();
        Task<Note> GetByIdAsync(int id);
        Task UpsertAsync(Note note);
        Task DeleteAsync(int id);
    }
}
