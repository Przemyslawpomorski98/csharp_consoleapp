using Milionerzy.Core;
using System;

namespace Milionerzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameManager();
            game.GameInterface();
            game.UserIntroduce();
            game.GameBegin();
            game.GetAskQuestions();
        }
    }
}
