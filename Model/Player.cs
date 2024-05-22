using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Player(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        override public string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public static Player Parse(string text)
        {
            string[] parts = text.Split(' ');
            return new Player(parts[0], parts[1]);
        }

    }
}
