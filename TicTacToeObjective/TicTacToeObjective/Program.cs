using System;

namespace TicTacToeObjective
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] field;

            Console.WriteLine("TicTacToe");
            Console.WriteLine("");
            Console.WriteLine("Naciśnij dowolny klawisz, aby rozpocząć!");
            Console.ReadKey();

            ttt newGame = new ttt();

            

        }
    }
    class ttt
    {
        public
        void wrongField()
        {
            Console.WriteLine("Nierozpoznany znak, za karę tracisz ruch!");
        }
    }
}
