using System;
using System.Collections.Generic;
using System.Linq;

namespace Notebook
{
    class Notebook
    {
        public Dictionary<int, Note> notes = new Dictionary<int, Note>();
        private int id;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public static Notebook CreateNotebook()
        {
            Notebook notebook = new Notebook();
            notebook.Id = 1;
            return notebook;
        }

        public static void AddNote(Notebook notebook)
        {
            Note note = Note.CreateNote();
            if (notebook.notes.Any(n => n.Value.Surname == note.Surname) && notebook.notes.Any(n => n.Value.Name == note.Name) && notebook.notes.Any(n => n.Value.PhoneNumber == note.PhoneNumber))
                Console.WriteLine("Похоже, такая запись уже существует");
            else
            {
                notebook.notes.Add(notebook.Id, note);
                notebook.Id++;
            }
        }

        public static void EditNote(Notebook notebook, int id)
        {
            Note.EditNote(notebook.notes[id]);
        }

        public static void DeleteNote(Notebook notebook, int id)
        {
            notebook.notes.Remove(id);
        }

        public static void ShowNote(Notebook notebook, int id)
        {
            Note.ShowNote(notebook.notes[id]);
        }

        public static void ShortShowNote(Notebook notebook)
        {
            foreach (KeyValuePair<int, Note> note in notebook.notes.OrderBy(key => key.Value.Surname))
            {
                string s = "ID = " + note.Key + ": " + Note.ShortShowNote(note.Value);
                Console.WriteLine(s);
            }
        }
    }
}
