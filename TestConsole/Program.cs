using ForgetMeLock.Backend.Data;
using ForgetMeLock.Backend.Services;
using ForgetMeLock.Backend.Contracts;
using ForgetMeLock.Backend.Model;

using var db = new NoteContext();
Console.WriteLine($"Database path:{db.DbPath}");
db.Add(new Note { Content = "bleuaeu", Title = "moo" });
db.SaveChanges();