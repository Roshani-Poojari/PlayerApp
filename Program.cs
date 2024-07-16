using System.Security.Principal;
using PlayerApp.Models;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[]{ 
                new Player(1,"Swati"),
                new Player(2,"Roshani",21),
                new Player(3,"Shweta",22),
                new Player(4,"Sampada"),
                new Player(5,"Swamini",20)};
            Player eldestPlayer = Player.WhoIsElderPlayer(players);
            Console.WriteLine(eldestPlayer);
        }

    }
}
