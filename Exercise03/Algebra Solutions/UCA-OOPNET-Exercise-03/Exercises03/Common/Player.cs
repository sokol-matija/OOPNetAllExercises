namespace Common
{
    public class Player
    {
        private const char SEPARATOR = ' ';

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Player(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public static Player Parse(string line)
        {
            string[] details = line.Split(SEPARATOR);
            return new(details[0], details[1]);
        }
    }
}