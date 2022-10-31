namespace Messenger.Models
{
    public class Email
    {
        public string From { get; set; }
        public List<string> To { get; set; } = new List<string>();
        public List<string> CC { get; set; } = new List<string>();
        public List<string> BCC { get; set; } = new List<string>();
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public List<File> Files { get; set; } = new List<File>();
    }
}
