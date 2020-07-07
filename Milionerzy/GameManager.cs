using Milionerzy.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Milionerzy
{
    public class GameManager
    {
        public List<QuestionItem> QuestionList { get; set; }
        public QuestionNumber GetQuestionNumber { get; set; }
        private static string UserName { get; set; }
        private static string FilePath { get; set; }

        private static int[] Prize = new int[] {0, 500, 1000, 2000, 5000, 10000, 20000, 40000, 75000, 125000, 250000, 500000, 1000000};

        public void GameIntroduce()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Witaj w grze o nazwie Milionerzy!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Już za chwilę przedstawimy Ci 12 pytań, na które będziesz musiał udzielić poprawnej odpowiedzi, żeby wygrać fortunę!");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Każde pytanie posiada 4 możliwe odpowiedzi, ale zawsze tylko jedna jest poprawna.");
            Console.WriteLine();
            Console.WriteLine("Do wykorzystania posiadasz 2 koła ratunkowe - 50:50, oraz telefon do przyjaciela (UWAGA! twój przyjaciel nie zawsze musi wskazać poprawną odpowiedź!)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("POWODZENIA!");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }

        public void UserIntroduce()
        {
            Console.WriteLine("Proszę podaj mi swoje imię:");
            UserName = Console.ReadLine();
            Console.Clear();

            FilePath = UserName.ToLower() + ".txt";

            if (File.Exists(FilePath))
            {
                var fileContent = File.ReadAllText(FilePath);
                if (fileContent.Length > 0)
                {
                    Console.WriteLine(UserName + " Twój ostatni zarobek to: " + fileContent + " PLN!");
                    Console.ReadLine();
                }
            }
            
            Console.Clear();   
        }

        public void GameBegin()
        {
            Console.WriteLine(UserName + " nie ma co przedłużać, ZACZYNAJMY!");
            Console.ReadLine();
        }

        public void GetAskQuestions()
        {
            QuestionItem questionItem = new QuestionItem();
            questionItem.QuestionText = "Ile to 6x6?";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("34");
            questionItem.AddAnswer("49");
            questionItem.AddAnswer("To jest najgorsze");
            questionItem.AddAnswer("36");
            questionItem.CorrectAnswer = "c";
            QuestionList = new List<QuestionItem>();
            QuestionList.Add(questionItem);
            
            questionItem = new QuestionItem();
            questionItem.QuestionText = "Kto zatrzymał słonce i ruszył Ziemię?";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Andrzej Duda");
            questionItem.AddAnswer("Michał Kopernik");
            questionItem.AddAnswer("Michał Anioł");
            questionItem.AddAnswer("Mikołaj Kopernik");
            questionItem.CorrectAnswer = "d";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Ile oscarów zdobył Leonardo DiCaprio";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("3");
            questionItem.AddAnswer("1");
            questionItem.AddAnswer("7");
            questionItem.AddAnswer("9");
            questionItem.CorrectAnswer = "b";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Kto zastał Polskę drewnianą, a zostawił murowaną?";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Mieszko II");
            questionItem.AddAnswer("Władysław II Jagiełło");
            questionItem.AddAnswer("Kazimierz Wielki");
            questionItem.AddAnswer("Aleksander Jagiellończyk");
            questionItem.CorrectAnswer = "c";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Jak nazywa się właściciel portalu Facebook?";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Mark Zuckerberg");
            questionItem.AddAnswer("Bill Gates");
            questionItem.AddAnswer("Steve Jobs");
            questionItem.AddAnswer("David Rockefeller");
            questionItem.CorrectAnswer = "a";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Oficjalnie najbogatszy człowiek na świecie to?";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Pablo Escobar");
            questionItem.AddAnswer("Vladimir Putin");
            questionItem.AddAnswer("Henry Ford");
            questionItem.AddAnswer("Mansa Musa");
            questionItem.CorrectAnswer = "d";
            QuestionList.Add(questionItem);

            var random = new Random();
            var randomList = QuestionList.OrderBy(item => random.Next());

            GetQuestionNumber = 0;
            var i = 0;

            foreach (var question in randomList)
            {
                Console.Clear();
                question.QuestionGeneration(GetQuestionNumber);
                GetQuestionNumber++;
                Console.WriteLine("Poprawna odpowiedź to odpowiedź A, B, C, czy D?:");
                var userAnswer = Console.ReadLine();
                if(userAnswer.ToLower() == question.CorrectAnswer)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DOBRZE!");
                    i++;
                    Console.WriteLine("Posiadasz już " + Prize[i] + " PLN!");
                    Console.ReadLine();
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niestety, jest to błędna odpowiedź.");
                    Console.WriteLine();
                    Console.WriteLine("Poprawna odpowiedź to odpowiedź: " + question.CorrectAnswer.ToUpper());
                    Console.ReadLine();
                    Console.ResetColor();
                    break;
                }
            }

            GameCompletion(i);
        }


        public void GameCompletion(int prize)
        {
            var userPrize = Prize[prize];
            Console.WriteLine("Dziękuję Ci bardzo za grę! Mam nadzieję, że niedługo znów sie spotakmy!");
            Console.WriteLine("Twoje zarobione pieniądze to: " + userPrize + " PLN!");
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            File.WriteAllText(FilePath, userPrize.ToString());
        }

    }
}
