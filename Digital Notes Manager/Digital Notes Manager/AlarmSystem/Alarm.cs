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
            notes.Add(note);
            notes = notes.OrderBy(n => n.ReminderDate).ToList();

            noteQueue = new Queue<Note>(notes);
        }


        //public async Task CompareTimeAsync()
        //{
        //    bool hasNotificationInFiveMinutes = false;
        //    while (true)
        //    {
        //        //await Task.Delay(1000);

        //        if (noteQueue.Any())
        //        {
        //            var note = noteQueue.First();

        //            var timeDifference = note.ReminderDate - DateTimeOffset.Now;

        //            if (timeDifference <= TimeSpan.FromMinutes(5) && timeDifference > TimeSpan.Zero)
        //            {
        //                if (!hasNotificationInFiveMinutes)
        //                {
        //                    NotifySoon(note);
        //                    hasNotificationInFiveMinutes = true;
        //                }
        //            }
        //            else if (timeDifference <= TimeSpan.Zero)
        //            {
        //                Notify(note);
        //                noteQueue.Dequeue();
        //                hasNotificationInFiveMinutes = false;
        //            }
        //        }
        //    }
        //}
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

                    // لو داخل 5 دقايق ولسه ما اتحذرش
                    if (timeDifference <= TimeSpan.FromMinutes(5) && timeDifference > TimeSpan.Zero)
                    //if (true)
                    {
                        if (!soonNotified.ContainsKey(note.ID))
                        {
                            await NotifySoon(note);
                            soonNotified[note.ID] = true;
                        }
                    }

                    // لو جه الوقت أو عداه ولسه ما اتحذرش
                    else if (timeDifference == TimeSpan.Zero)
                    {
                        if (!notified.ContainsKey(note.ID))
                        {
                            await Notify(note);
                            notified[note.ID] = true;

                            // شيله من الكيو بعد ما وقت التنبيه ييجي
                            noteQueue.Dequeue();
                        }
                    }
                    else if (timeDifference < TimeSpan.Zero)
                    {
                        await NotifyEndReminderDate(note);
                        noteQueue.Dequeue();
                    }
                }
            }
        }



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
