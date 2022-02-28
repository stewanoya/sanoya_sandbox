using System;

namespace sanoya_sandbox.Database
{
    public class Question
    {

        public long QuestionId { get; set; }
        public string Category { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public int TimesUsed { get; set; }

    }
}
