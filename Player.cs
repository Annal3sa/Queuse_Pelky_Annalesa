using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuse_Pelky_Annalesa
{
    internal class Player
    {

        //Create an automatic property called Health of integer type.
        public int Health { get; set; }

        //Create another property called GamerTag, with an automatic getter, of string type.
        public string GamerTag { get; }

        //Create a constructor that takes one int parameter and one string parameter.
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }
        //Create a public method called JoinGame, that takes two parameters.
        public void JoinGame(Game game, Queue<Player> queue)
        {
            //If the game's current players is equal to the max players, then add 'this' player to the queue.
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                //Else, print, "Joining Game" and increase current players by 1.
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }

        public override string ToString()
        {
            return GamerTag;
        }
    }
}
