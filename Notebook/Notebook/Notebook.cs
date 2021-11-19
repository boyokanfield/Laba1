using System;
using System.Collections.Generic;
using System.Linq;

namespace Notebook
{
    class Notebook
    {
        public Dictionary<int, Note> notes = new Dictionary<int, Note>();
        public int Id { get; set; }
  
        public Notebook()
        {
            Id = 1;
        }

        public void AddNote()
        {
            Note note = new Note();
            if (notes.Any(n => n.Value.PhoneNumber == note.PhoneNumber))
                Console.WriteLine("Похоже, такая запись уже существует");
            else
            {
                notes.Add(Id, note);
                Id++;
            }
        }

        public void EditNote(int id)
        {
            notes[id].EditNote();
        }

        public void DeleteNote(int id)
        {
            notes.Remove(id);
        }

        public void ShowNote(int id)
        {
            notes[id].ShowNote();
        }

        public void ShortShowNote()
        {
            foreach (KeyValuePair<int, Note> note in notes.OrderBy(key => key.Value.Surname))
            {
                string s = "ID = " + note.Key + ": " + note.Value.ShortShowNote();
                Console.WriteLine(s);
            }
        }
    }
}
