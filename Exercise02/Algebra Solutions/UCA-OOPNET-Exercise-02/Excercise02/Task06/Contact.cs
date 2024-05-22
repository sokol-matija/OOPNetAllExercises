using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    public class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string? ToString()
            => $"{Name} {Surname}, Phone: {Phone}, Email: {Email} ";     
    }
}