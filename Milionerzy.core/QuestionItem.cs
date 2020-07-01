using System;
using System.Collections.Generic;

namespace Milionerzy.Core
{
    public class QuestionItem : ShowQuestion
    {
        public void QuestionObjects()
        {
            var questions = new List<ShowQuestion>
            {
                new QuestionItem
                {
                    QuestionText = "1. Ile to 2x2?",
                    Answers = new List<string>
                    {
                        "4",
                        "10",
                        "2",
                        "7"
                    },
                    CorrectAnswer = "4"
                },
                new QuestionItem
                {
                    QuestionText = "2. Kto zatrzymał słońce i ruszył ziemię?",
                    Answers = new List<string>
                    {
                        "Andrzej Duda",
                        "Michał Anioł",
                        "Mikołaj Kopernik",
                        "Mieszko I"
                    },
                    CorrectAnswer = "Mikołaj Kopernik"
                },
            };

            foreach(var question in questions)
            {
                question.Show(QuestionText);
            }
        }
    }
}
