namespace Messenger.Models
{
    public class Disableable
    {
        /// <summary>
        /// Whether or not the data source is enabled
        /// 0: Disabled (default)
        /// 1: Enabled
        /// </summary>
        public int Enabled { get; set; } = DBValue.Disabled;
        /// <summary>
        /// C# convenience function to get and set the Enabled
        /// property using real booleans
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return Enabled == DBValue.Enabled;
            }
            set
            {
                Enabled = value ? DBValue.Enabled : DBValue.Disabled;
            }
        }
    }
}
