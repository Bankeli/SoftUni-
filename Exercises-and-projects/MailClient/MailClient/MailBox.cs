using System.Runtime.CompilerServices;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public MailBox(int capacity)
        {
           this.Capacity = capacity;
            this.Inbox = new List<Mail>();
            this.Archive = new List<Mail>();
        }

        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (this.Capacity > this.Inbox.Count )
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender)
        => Inbox.Remove(Inbox.FirstOrDefault(m => m.Sender == sender));
        

        public int ArchiveInboxMessages()
        {
            int count = Inbox.Count;

            Archive.AddRange(this.Inbox);
            Inbox.Clear();

            return count;
        }

        public string GetLongestMessage()
         => Inbox.OrderByDescending(m => m.Body.Length).FirstOrDefault().ToString();

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (var mail in Inbox) 
                sb.AppendLine(mail.ToString());

            return sb.ToString().TrimEnd();
        }
    }
}
