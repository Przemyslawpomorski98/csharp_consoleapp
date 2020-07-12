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
        private static int LifebuoyUsed { get; set; }

        private static int[] Prize = new int[] {0, 500, 1000, 2000, 5000, 10000, 20000, 40000, 75000, 125000, 250000, 500000, 1000000};

        public void GameInterface()
        {
            Console.WriteLine("Witaj! Zanim zaczniemy, proszę podaj mi swoję imię!:");
            UserName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(UserName + ", proszę, wybierz co chcesz zrobić z listy ponieżej:");
            Console.WriteLine();
            Console.WriteLine("1. Zacznij grę Milionerzy!");
            Console.WriteLine("2. Wyjdź");
            var userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                GameIntroduce();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void GameIntroduce()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Witaj w grze o nazwie Milionerzy!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Już za chwilę przedstawimy Ci 12 pytań, na które będziesz musiał udzielić poprawnej odpowiedzi, żeby wygrać fortunę!");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Każde pytanie posiada 4 możliwe odpowiedzi, ale zawsze tylko jedna jest poprawna.");
            Console.WriteLine();
            Console.WriteLine("Możesz 2 razy zadzwonić do przyjaciela [przycisk K] (UWAGA! twój przyjaciel nie zawsze musi wskazać poprawną odpowiedź!)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("POWODZENIA!");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }

        public void UserIntroduce()
        {

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

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Na ile maksymalnie sposobów możesz się ubrać, mając dwie pary butów, trzy pary spodni i pięć koszulek?";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Na 10");
            questionItem.AddAnswer("Na 16");
            questionItem.AddAnswer("Na 25");
            questionItem.AddAnswer("Na 30");
            questionItem.CorrectAnswer = "d";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Wnuk Syzyfa usiłował dostać się na Olimp, wzlatując:";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Na skrzydłach Ikara");
            questionItem.AddAnswer("W sandałach Hermesa");
            questionItem.AddAnswer("Na skrzydłach Nike");
            questionItem.AddAnswer("Na grzbiecie Pegaza");
            questionItem.CorrectAnswer = "d";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Góralskie zabocyć to:";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Zapomnieć");
            questionItem.AddAnswer("Zobaczyć");
            questionItem.AddAnswer("Obrazić się");
            questionItem.AddAnswer("Zejść z drogi");
            questionItem.CorrectAnswer = "a";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Wyrwać się jak filip z konopi, czyli:";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Oczyścić organizm z THC");
            questionItem.AddAnswer("Dać drapaka");
            questionItem.AddAnswer("Wywinąć się od śmierci");
            questionItem.AddAnswer("Powiedzieć coś niestosownego");
            questionItem.CorrectAnswer = "d";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "W której z tych zwycięskich bitew wojskami polskimi nie dowodził król?";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Pod Grunwaldem w 1410");
            questionItem.AddAnswer("Pod Kircholmem w 1605");
            questionItem.AddAnswer("Pod Beresteczkiem w 1651");
            questionItem.AddAnswer("Pod Wiedniem w 1683");
            questionItem.CorrectAnswer = "b";
            QuestionList.Add(questionItem);

            questionItem = new QuestionItem();
            questionItem.QuestionText = "Ksiądz zawsze odmawia modlitwę z egzorcyzmem:";
            questionItem.Answers = new List<string>();
            questionItem.AddAnswer("Chrzcząc dziecko");
            questionItem.AddAnswer("Przed pasterką");
            questionItem.AddAnswer("Przed pogrzebem");
            questionItem.AddAnswer("Gdy święci jajka");
            questionItem.CorrectAnswer = "a";
            QuestionList.Add(questionItem);

            var random = new Random();
            var randomList = QuestionList.OrderBy(item => random.Next());

            LifebuoyUsed = 0;
            GetQuestionNumber = 0;
            var i = 0;

            foreach (var question in randomList)
            {
                Console.Clear();
                question.QuestionGeneration(GetQuestionNumber);
                GetQuestionNumber++;
                Console.WriteLine("Poprawna odpowiedź to odpowiedź A, B, C, czy D?, a może chcesz zadzwonić do przyjaciela? [K]:");
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
                else if(userAnswer.ToLower() == "k" )
                {
                    if (LifebuoyUsed < 2)
                    {
                        LifebuoyUsed++;
                        Lifebuoy lifebuoy = new Lifebuoy();
                        lifebuoy.Phone(question.CorrectAnswer, UserName);
                        var secondAnswer = Console.ReadLine();
                        if (secondAnswer == question.CorrectAnswer)
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
                    else
                    {
                        Console.WriteLine("Niestety, wykorzystałeś już wszystkie koła ratunkowe, proszę odpowiedz na pytanie.");
                        Console.WriteLine();
                        Console.WriteLine("Poprawna odpowiedź to odpowiedź A, B, C, czy D?:");
                        var thirdAnswer = Console.ReadLine();
                        if (thirdAnswer == question.CorrectAnswer)
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
            Console.Clear();
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
