using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonRepo
    {
        private static readonly string filePath = "data.txt";
        public static IEnumerable<Person> GetPersonFromFile()
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                while (!r.EndOfStream)
                {
                    yield return GetPersonFromString(r.ReadLine());
                }
            }
        }

        private static Person GetPersonFromString(string personData)
        {
            string[] person = personData.Split(' ');
            return new Person
            {
                FirstName = person[0],
                LastName = person[1],
                Email = person[2],
                Id = new Guid(person[3])
            };
        }

        public static void SaveToFile(List<Person> personList)
        {
            using (StreamWriter w = new StreamWriter(filePath))
            {
                foreach (Person person in personList)
                {
                    w.WriteLine(person.ToString());
                }
            }
        }
    }
}
