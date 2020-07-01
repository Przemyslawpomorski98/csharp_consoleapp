using Milionerzy.Core;
using System;

namespace Milionerzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameHud();
            game.GameIntroduce();
            game.UserIntroduce();
            game.GameBegin();
            game.AskQuestion();
            game.GameCompletion();

        }
    }
}
