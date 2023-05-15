using MimeKit;

namespace EmailService
{
    public class Message : MimeMessage
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public Message(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress("",x)));//""=email sender name
            Subject = subject;
            Content = content;
        }
        public Message(IEnumerable<MailboxAddress> to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress(x.Name, x.Address)));//key=name, value=email
            Subject = subject;
            Content = content;
        }
        public Message(string name, string address, string subject, string content)
        {
            //List<MailboxAddress> mbato = new List<MailboxAddress>();
            //mbato.Add(new MailboxAddress(name, address));
            To = new List<MailboxAddress>();
            To.Add(new MailboxAddress(name, address));
            //To.AddRange(mbato.Select(x => new MailboxAddress(x.Name, x.Address)));//key=name, value=email
            Subject = subject;
            Content = content;
        }
    }
}
