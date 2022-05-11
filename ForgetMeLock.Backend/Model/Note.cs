using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeLock.Backend.Model
{
    public class Note
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime DueTime { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public string? Content { get; set; } = string.Empty;
        public Mood? StateOfMind { get; set; }


    }
}
