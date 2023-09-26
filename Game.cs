using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queuse_Pelky_Annalesa
{
    internal class Game
    {

        //Create a property called, MaxPlayers with an automatic getter.
        public int MaxPlayers { get; }
        //Create a property called, CurrentPlayers with an automatic getter and setter.
        public int CurrentPlayers { get; set; }
        //Create a constructor that takes two int parameters, maxPlayers and currentPlayers.
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }
        //Create a method called, KickPlayer. In the body decrement CurrentPlayers by 1.
        public void KickPlayer()
        {
            CurrentPlayers--;
        }
        //Create a method called, CheckQueue, that takes a Queue<Player> parameter.
        public void CheckQueue(Queue<Player> playerQueue)
        {
            //In the body, if CurrentPlayers is less than MaxPlayers, then check if the queue has elements in it.
            if (CurrentPlayers < MaxPlayers)
            { 
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    //If the queue has players in it, call Dequeue on the queue and increment current players by 1. Else, print, "No Players in the Queue!".
                    Console.WriteLine("No players in the queue!");
                }
        }


    }
}
