using Messenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Services.Fake
{
    /// <summary>
    /// Test template service used during development and
    /// unit tests
    /// </summary>
    public class FakeTemplateService : ITemplateService
    {

        public Template? Get(long seq, long? version = null)
        {
            return InMemDB.Templates.Where(t => t.Seq == seq).FirstOrDefault();
        }
    }
}
