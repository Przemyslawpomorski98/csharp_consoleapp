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

        public void QuestionGeneration(QuestionNumber questionNumber)
        {
            Console.WriteLine(questionNumber.ToNumber() + QuestionText);
            Console.WriteLine("A: " + Answers[0]);
            Console.WriteLine("B: " + Answers[1]);
            Console.WriteLine("C: " + Answers[2]);
            Console.WriteLine("D: " + Answers[3]);
        }

        public void AddAnswer(string newAnswer)
        {
            Answers.Add(newAnswer);
        }
    }
}
