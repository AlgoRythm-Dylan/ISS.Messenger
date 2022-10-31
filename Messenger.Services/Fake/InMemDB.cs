using Messenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Messenger.Services.Fake
{
    public static class InMemDB
    {
        public static List<Template> Templates = new List<Template>
        {
            new Template {
                Seq = 1,
                ID = "TEST_TEMPLATE",
                Name = "This is a test template returned by the FakeTemplateService",
                Description = "This template is not used except in development. If you see this outside of testing, please contact support",
                IsEnabled = true,
                Version = 1,
                Source = "<p>Hello, world. And hello {{name}}, too</p>"
            }
        };
    }
}
