using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Native.Sql;
using Digital_Notes_Manager.Models;
using System.Media;
using System.Timers;

namespace Digital_Notes_Manager.AlarmSystem
{
    public class Alarm
    {
        private List<Note> notes;
        private Queue<Note> noteQueue;
        private Main_Form mainFormInstance;



        public Alarm(Main_Form form, List<Note> notesFromForm)
        {
            mainFormInstance = form;
            notes = notesFromForm.OrderBy(n => n.ReminderDate).ToList();

            noteQueue = new Queue<Note>(notes);
   
        }
        public void UpdateNotes(Note note)
        {
            notes.Add(note);
            notes = notes.OrderBy(n => n.ReminderDate).ToList();

            noteQueue = new Queue<Note>(notes);
        }


        public async Task CompareTimeAsync()
        {

            while (true)
            {
                await Task.Delay(10000);

                if (noteQueue.Any())
                {
                    var note = noteQueue.First();
               
                   var timeDifference = note.ReminderDate - DateTimeOffset.Now;

                    if (timeDifference <= TimeSpan.FromMinutes(5) && timeDifference > TimeSpan.Zero)
                    {
                        NotifySoon(note);  
                   }
                    else if (timeDifference <= TimeSpan.Zero)
                    {
                        Notify(note);      
                       noteQueue.Dequeue();
                    }
                }

            }

        }


        public void NotifySoon(Note note)
        {
            SoundPlayer player = new SoundPlayer(typeof(Program).Assembly.GetManifestResourceStream("Digital_Notes_Manager.AlarmSounds.Alarm1.wav"));
            player.Play();
            mainFormInstance.ShowSoonMessage(note);
        }

        public void Notify(Note note) {
            SystemSounds.Asterisk.Play();
            mainFormInstance.IsMached(note);

                }


    }
}
