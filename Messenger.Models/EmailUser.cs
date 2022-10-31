namespace Messenger.Models
{
    /// <summary>
    /// A simple class which allows an object oriented approach to
    /// allowing users to either identify themselves with a name or
    /// not. For example, you can either be just dperunko@pbcgov.org
    /// or you can be "Dylan Perunko" dperunko@pbcgov.org. In the
    /// latter, you are identified more personally. This class
    /// overrides the object.ToString method, so it can be used
    /// directly in string operations like $"{EmailUser1}";
    /// </summary>
    public class EmailUser
    {
        /// <summary>
        /// The actual e-mail address of the user
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// The optional name of the user
        /// </summary>
        public string? Name { get; set; }
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Name))
                return $"\"{Name}\" {Address}";
            else
                return Address;
        }
    }
}
