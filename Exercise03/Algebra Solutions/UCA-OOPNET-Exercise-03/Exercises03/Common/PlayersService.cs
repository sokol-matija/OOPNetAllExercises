using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PlayersService
    {
        private const string PATH = "players.txt";

        public List<Player> GetPlayers()
        {
            List<Player> players = new();

            string[] lines = File.ReadAllLines(PATH);
            foreach (string line in lines)
            {
                players.Add(Player.Parse(line));
            }

            return players;
        }
    }
}
