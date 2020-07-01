using Milionerzy.Core;
using System;


namespace Milionerzy
{
    public class GameHud
    {
        public ShowQuestion Question { get; set; }
        
        public void GameIntroduce()
        {
            Console.WriteLine("Witaj w grze o nazwie Milionerzy!");
            Console.WriteLine("Już za chwilę przedstawimy Ci 10 pytań, na które będziesz musiał udzielić poprawnej odpowiedzi, żeby wygrać fortunę!");
            Console.WriteLine("Każde pytanie posiada 4 możliwe odpowiedzi, ale zawsze tylko jedna jest poprawna.");
            Console.WriteLine("Do wykorzystania posiadasz 2 koła ratunkowe - 50:50, oraz telefon do przyjaciela (UWAGA! twój przyjaciel nie zawsze musi wskazać poprawną odpowiedź!)");
            Console.WriteLine("POWODZENIA!");
        }

        public void UserIntroduce()
        {
            Console.WriteLine("Proszę podaj mi swoje imię:");
            var userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(userName + " Twój ostatni zarobek to 2 000 PLN");
            
        }

        public void GameBegin()
        {
            Console.WriteLine("Przemek, witam Cię w grze Milionerzy! Oto twoje pytanie:");
           
        }

        public void AskQuestion()
        {
            Console.WriteLine("Tu pojawi się pytanie!");
            var question = Question.Show(questionDescription);
        }

        public void GameCompletion()
        {
            Console.WriteLine("Dziękuję Ci bardzo za grę! Mam nadzieję, że niedługo znów sie spotakmy!");
            Console.WriteLine("Twoje zarobione pieniądze to: 6 000 PLN!");
        }

    }
}
