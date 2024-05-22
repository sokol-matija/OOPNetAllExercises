using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlayerService
    {
        private const string PATH = "players.txt";

        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            string[] lines = System.IO.File.ReadAllLines(PATH);
            foreach (string line in lines)
            {
                players.Add(Player.Parse(line));
            }

            return players;
        }
    }
}
