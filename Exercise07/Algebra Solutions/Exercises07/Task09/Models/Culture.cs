using System.Globalization;

namespace Task09.Models
{
    public class Culture
    {
        public string Name { get; set; }
        public CultureInfo Value { get; set; }

        public Culture(string name, CultureInfo value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Name} | {Value.Name}";
        }
    }
}
