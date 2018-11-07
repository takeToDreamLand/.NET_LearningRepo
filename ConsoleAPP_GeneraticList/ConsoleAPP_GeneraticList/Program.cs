using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPP_GeneraticList
{
    class Program
    {
        class Person
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public Char Grade { get; set; }

        }
        //public List<Person> PersonList = new List<Person>();
        List<Person> persons = new List<Person>()
        {
            new Person() {Id = 1, Name = "Shaw", Grade = 'A'},
            new Person() {Id = 2, Name = "Bruce", Grade = 'B'},
            new Person() {Id = 3, Name = "Tina", Grade = 'B'},
            new Person() {Id = 4, Name = "Sunny", Grade = 'C'}

        };
        static void Main(string[] args)
        {
            int Test_Id = 1;
            Person person = new Person();
            Program app = new Program();
            var person_name = from son in person
                          where son.Id = Test_Id
                          select son.Name;

        }


    }
}
