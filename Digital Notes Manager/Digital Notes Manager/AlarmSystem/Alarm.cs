using Digital_Notes_Manager.Models;
using System.Media;

namespace Digital_Notes_Manager.AlarmSystem
{
    public class Alarm
    {
        public static List<Note> notes;
        private static Queue<Note> noteQueue;
        private Main_Form mainFormInstance;
        public static List<Note> EndReminerNotes;


        public Alarm(Main_Form form, List<Note> notesFromForm)
        {
            mainFormInstance = form;
            notes = notesFromForm;

            noteQueue = new Queue<Note>(notes);

            EndReminerNotes = new List<Note>();

        }
        public static void AddNewNoteToAlarmSystemNotesList(Note note)
        {
            if (note != null && !note.IsCompleted)
            {
                notes.Add(note);
            notes = notes.Where(x=>!x.IsCompleted && x.ReminderDate != DateTime.MinValue)
                    .OrderByDescending(n => n.ReminderDate).ToList();
            noteQueue = new Queue<Note>(notes);

            }

        }


        private Dictionary<int, bool> soonNotified = new();
        private Dictionary<int, bool> notified = new();

        public async Task CompareTimeAsync()
        {

            while (true)
            {
                await Task.Delay(1500);

                if (noteQueue.Any())
                {
                    var note = noteQueue.First();
                    var timeDifference = note.ReminderDate - DateTime.Now;

                    if (timeDifference <= TimeSpan.FromMinutes(5) && timeDifference > TimeSpan.FromMinutes(4))
                    {
                        if (!soonNotified.ContainsKey(note.ID))
                        {
                            await NotifySoon(note);
                            await NotifyEndReminderDate(note);
                            soonNotified[note.ID] = true;
                        }
                    }
                    //
                    if (timeDifference <= TimeSpan.Zero && timeDifference >= TimeSpan.FromMinutes(-1) && !notified.ContainsKey(note.ID))
                    {
                        await Notify(note);
                        await NotifyEndReminderDate(note);
                        notified[note.ID] = true;
                        noteQueue.Dequeue();
                    }

                    if (timeDifference < TimeSpan.FromMinutes(-2) && !notified.ContainsKey(note.ID))
                    {
                        await NotifyEndReminderDate(note);
                        notified[note.ID] = true;
                        noteQueue.Dequeue();

                    }



                }
            }
        }

        //

        public async Task NotifySoon(Note note)
        {
            SoundPlayer player = new SoundPlayer(typeof(Program).Assembly.GetManifestResourceStream("Digital_Notes_Manager.AlarmSounds.Alarm1.wav"));
            player.Play();
            mainFormInstance.ShowSoonMessage(note);
            mainFormInstance.LateNotifyReminderDates(note);
        }

        public async Task Notify(Note note)
        {
            SystemSounds.Asterisk.Play();
            mainFormInstance.IsMached(note);
            mainFormInstance.LateNotifyReminderDates(note);
        }
        public async Task NotifyEndReminderDate(Note note)
        {
            SystemSounds.Asterisk.Play();
            mainFormInstance.LateNotifyReminderDates(note);
        }


    }
}
