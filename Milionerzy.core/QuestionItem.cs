using System;
using System.Collections;
using System.Collections.Generic;

namespace Milionerzy.Core
{
    public class QuestionItem
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }
       
        public void QuestionGeneration()
        {
            Console.WriteLine(QuestionText);
            Console.WriteLine("A: " + Answers[0]);
            Console.WriteLine("B: " + Answers[1]);
            Console.WriteLine("C: " + Answers[2]);
            Console.WriteLine("D: " + Answers[3]);
        }

        public Boolean IsGood(string UserAnswer)
        {
            Boolean isGood = false;
            if(UserAnswer.ToLower().Equals(CorrectAnswer))
            {
                isGood = true;
            }
            return isGood;
        }

        public void AddAnswer(string newAnswer)
        {
            Answers.Add(newAnswer);
        }
    }
}
