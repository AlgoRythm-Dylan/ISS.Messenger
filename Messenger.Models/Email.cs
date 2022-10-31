namespace Messenger.Models
{
    public class Email
    {
        public EmailUser From { get; set; }
        public List<EmailUser> To { get; set; } = new List<EmailUser>();
        public List<EmailUser> CC { get; set; } = new List<EmailUser>();
        public List<EmailUser> BCC { get; set; } = new List<EmailUser>();
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public List<File> Files { get; set; } = new List<File>();
    }
}
