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
            pigPlayer1( ref player1Score, ref player2Score );
        }
        static int random1()
        {
            Random randomNumber= new Random();
            int number;
            number = randomNumber.Next( 1, 10 );
            return number;
        }
        static void pigPlayer1( ref int player1Score, ref int  player2Score )
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
                     player2Method( ref player2Score, ref player1Score );
                     break;
                 }
                 
            }
        }
        static void player2Method( ref int player2Score, ref int player1Score )
        {
            Console.WriteLine( "It is player 2's turn" );
            pigPlayer2( ref player2Score, ref player1Score);
        }
        static void pigPlayer2( ref int player2Score, ref int player1Score)
        {
            Console.WriteLine( "Player 2 is rolling" );
            while ( player2Score < 100 )
            {
                 int addScore = random1();
                 if ( addScore != 1 )
                 {
                     player2Score = addScore + player2Score;
                     Console.WriteLine( player2Score );
                 }
                 else
                 {
                     Console.WriteLine( "Your turn has ended" );
                     Console.WriteLine( "It is back to player 1" );
                     pigPlayer1( ref player1Score, ref player2Score );
                     break;
                 }
                 
            }
        }
            
    }
}
