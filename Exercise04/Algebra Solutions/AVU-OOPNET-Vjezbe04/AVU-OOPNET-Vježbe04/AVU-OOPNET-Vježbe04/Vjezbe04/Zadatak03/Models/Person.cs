using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
        public Person()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Email} {Id.ToString()}";
        }
    }
}
