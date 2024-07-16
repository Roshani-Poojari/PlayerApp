using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Models
{
    internal class Player
    {
        private const int DEFAULT_AGE = 18;
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            Age = DEFAULT_AGE;
        }
        public Player(int id, string name, int age) : this(id, name)
        {
            Age = age;
        }
        public static Player WhoIsElderPlayer(Player[] players)
        {
            Player elderPlayer = null;
            int playerAge = DEFAULT_AGE;
            foreach (var player in players)
            {
                if (player.Age > playerAge)
                {
                    playerAge = player.Age;
                    elderPlayer = player;
                }
            }
            return elderPlayer;
        }
        public override string ToString()
        {
            return $"Eldest Player : {Name} \n" +
                $"Id: {Id} \n" +
                $"Age: {Age} ";
        }
    }
}
