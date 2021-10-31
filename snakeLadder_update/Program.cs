using System;

namespace snakeLadder_update
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                loopClass obj = new loopClass();
                Random ran = new Random();
                int dai = ran.Next(1, 7);

                int positionPlayer1 = 0, positionPlayer2 = 0, daiNumberOfTime = 0, nextMove2 = 0, nextMove1 = 0;

                while ((positionPlayer1 != 100 && positionPlayer1 < 101) && (positionPlayer2 != 100 && positionPlayer2 < 101))
                {
                    if (nextMove2 != 6)
                    {
                        nextMove1 = ran.Next(3);
                        positionPlayer1 = positionPlayer1 + obj.loopMethod(nextMove1,dai);
                    }
                    if (nextMove1 != 6)
                    {
                        nextMove2 = ran.Next(3);
                        positionPlayer2 = positionPlayer2 + obj.loopMethod(nextMove2, dai);
                    }
                    
                    daiNumberOfTime++;
                    Console.WriteLine(daiNumberOfTime);
                    Console.WriteLine("player 1 at step :" + positionPlayer1);
                    Console.WriteLine("player 2 at step :" + positionPlayer2);
                }

                if (positionPlayer1 == 100)
                {
                    Console.WriteLine("player1 won the game " + positionPlayer1);
                    Console.WriteLine("dai need to played " + daiNumberOfTime + " times");
                }
                else
                {
                    Console.WriteLine("player2 won the game " + positionPlayer2);
                    Console.WriteLine("dai need to played " + daiNumberOfTime + " times");
                }
            }
        }
    }
}
