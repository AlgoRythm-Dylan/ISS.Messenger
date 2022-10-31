namespace Messenger.Models
{
    public class Job : Disableable
    {
        /// <summary>
        /// Unique numerical identifier of this job
        /// </summary>
        public long Seq { get; set; }
        /// <summary>
        /// String identifier that can be used to refer to
        /// this job (example: "SEND_7_DAY_MAIL")
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Friendly name of the job (example: "Weekly report email")
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the job
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The data source of a job. One record from a data source
        /// relates to one e-mail message sent, and can include
        /// information such as to, cc, and bcc
        /// </summary>
        public DataSource? DataSource { get; set; } = null;
        public long Version { get; set; }
        /// <summary>
        /// The body of the template
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The MIME of the body. Can be text/html, text/plain,
        /// text/x-handlebars, or any other
        /// </summary>
        public string BodyMIME { get; set; }
        /// <summary>
        /// The subject of the e-mail. Can be plain text or
        /// templated
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// The MIME type of the body. Can be text/plain
        /// or text/x-handlebars or other template types
        /// </summary>
        public string SubjectMIME { get; set; }
        /// <summary>
        /// The "From" field in the e-mail
        /// </summary>
        public string From { get; set; } = null;
        /// <summary>
        /// The "To" field in the e-mail. This should only
        /// be populated if the user wants to add fixed recipients,
        /// otherwise the "to" field should come from the data
        /// source
        /// </summary>
        public List<string>? To { get; set; } = null;
        /// <summary>
        /// The "CC" field in the e-mail. This should only
        /// be populated if the user wants to add fixed recipients,
        /// otherwise the "CC" field should come from the data
        /// source
        /// </summary>
        public List<string>? CC { get; set; } = null;
        /// <summary>
        /// The "BCC" field in the e-mail. This should only
        /// be populated if the user wants to add fixed recipients,
        /// otherwise the "BCC" field should come from the data
        /// source. Here is where you can add your service account
        /// to log emails. Do not use CC, as BCC will not show up
        /// for the end user
        /// </summary>
        public List<string>? BCC { get; set; } = null;
        /// <summary>
        /// Files can be attachments or can be content in the
        /// e-mail body itself. If you want to have an image in
        /// your e-mail (such as a logo), you'll need to add a
        /// file and choose whether or not it is referred to by
        /// content-id (cid) or embedded directly using Base64Encoding
        /// </summary>
        public List<File> Files { get; set; } = new List<File>();
    }
}
