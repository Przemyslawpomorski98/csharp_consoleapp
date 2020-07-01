using System;
using System.Collections.Generic;

namespace Milionerzy.Core
{
    public class ShowQuestion
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }

        public string Show(string questionDescription)
        {
            questionDescription = Console.WriteLine(QuestionText);
            return questionDescription;
        }
    }
}
