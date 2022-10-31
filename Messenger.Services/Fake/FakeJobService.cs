using Messenger.Models;

namespace Messenger.Services.Fake
{
    /// <summary>
    /// Test template service used during development and
    /// unit tests
    /// </summary>
    public class FakeJobService : IJobService
    {
        public Job? Get(long seq, long? version = null)
        {
            var results =  JobMemDB.Jobs.Where(t => t.Seq == seq);
            if(version != null)
                results = results.Where(t => t.Version == version);
            return results.FirstOrDefault();
        }
    }
}
