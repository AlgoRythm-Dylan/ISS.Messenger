namespace Messenger.Models
{
    /// <summary>
    /// A file is a generic structure that can be attached to an
    /// e-mail, either as an attachment or as an embedded image
    /// </summary>
    public class File
    {
        /// <summary>
        /// Unique numerical sequence of this file
        /// </summary>
        public long Seq { get; set; }
        /// <summary>
        /// The filename, ex: logo.jpg
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// E-mail content id (cid) to refer to this
        /// file within the e-mail body. Used for embedding
        /// images, for example
        /// </summary>
        public string ContentID { get; set; }
        /// <summary>
        /// Byte buffer of the file contents
        /// </summary>
        public byte[] Content { get; set; }
        /// <summary>
        /// EmbedMode can be:
        /// 0: Do not embed
        /// 1: content-id (cid)
        /// 2: Base64
        /// </summary>
        public int EmbedMode { get; set; } = 0;
    }
}
