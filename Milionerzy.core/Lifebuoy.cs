using System;
using System.Collections.Generic;

namespace Milionerzy.Core
{
    public class Lifebuoy
    {
        public void Phone(string correctAnswer, string userName)
        {
            var answer1 = "Cześć " + userName + ", nie jest to moja dziedzina, ale myślę, że poprawna odpowiedź to odpowiedź: " + correctAnswer.ToUpper();
            var answer2 = "No cześć " + userName + ", jestem pewien, że poprawa odpowiedź to: " + correctAnswer.ToUpper();
            var answer3 = "Hej! " + userName + ", na 99% jest to odpowiedź: " + correctAnswer.ToUpper();
            var answer4 = "Wiesz co " + userName + ", nie znam odpowiedzi na to pytanie, a nie chce Cię zmylić, musisz wybrać to co sądzisz";
            var answer5 = "Cześć, cześć " + userName + ", moim zdaniem jest to odpowiedź: A";

            List<string> FriendAnswers = new List<string> { answer1, answer2, answer3, answer4, answer5 };
            
            var random = new Random();

            Console.WriteLine(FriendAnswers[random.Next(FriendAnswers.Count)]);
        }
    }
}
