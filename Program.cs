using System;
using System.Collections.Generic;


namespace Queuse_Pelky_Annalesa
{
    internal class Program
    {
        //In Program.cs, create a Game object and set its max players to 50 and current players to 49.
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            //Create a Queue of Player objects.
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            //Create 4 Player objects, giving them 100 health and a unique gamer tag.
            Player p1 = new Player(100, "Annal3sa");
            Player p2 = new Player(100, "MMSix");
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "ZombieSlaya");

            //Call JoinGame on all 4 player objects; passing through the game and queue as arguments.
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            //Print, "Players in Queue" to console.
            Console.WriteLine("Players in da Q:");

            //Loop through the queue and print all the players on a new line
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

            //Call KickPlayer on the game.
            myGame.KickPlayer();
            //Call CheckQueue on the game.
            myGame.CheckQueue(waitingToJoinQ);

            //Then print, "\nPlayers in Queue" to console.
            Console.WriteLine("\nPlayers in da Q:");

            //Loop through the queue and print all the players on a new line.
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }




        }
    }
}