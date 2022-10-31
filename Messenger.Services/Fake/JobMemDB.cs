using Messenger.Models;

namespace Messenger.Services.Fake
{
    public static class JobMemDB
    {
        public static List<Job> Jobs = new List<Job>
        {
            new Job {
                Seq = 1,
                ID = "TEST_JOB",
                Name = "This is a test job in JobMemDB",
                Description = "This job is not used except in development. If you see this outside of testing, please contact support",
                Version = 1,
                Body = "<p>Hello, world. And hello {{name}}, too</p>",
                BodyMIME = "text/x-handlebars"
            }
        };
    }
}
