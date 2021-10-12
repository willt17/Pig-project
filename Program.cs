using System;

namespace pig_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Score = 0;
            int player2Score = 0;
            Console.WriteLine("Welcome to Pig");
            Console.WriteLine( "test1" );
            pigPlayer1( ref player1Score );
        }
        static int random1()
        {
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next( 1, 10 );
            return number;
        }
        static void pigPlayer1( ref int player1Score )
        {
            Console.WriteLine( "Player 1 is rolling" );
            while ( player1Score < 100 )
            {
                 int addScore = random1();
                 if ( addScore != 1 )
                 {
                     player1Score = addScore + player1Score;
                     Console.WriteLine( player1Score );
                 }
                 else
                 {
                     Console.WriteLine( "Your turn has ended" );
                     player2Method();
                     break;
                 }
                 
            }
        }
        static void player2Method()
        {
            Console.WriteLine( "It is player 2's turn" );
        }
            
    }
}
