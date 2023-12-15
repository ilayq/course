using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_archive
{
    public class Author
    {
        static int Id = 0;

        public string Name, Surname;
        public DateTime BirthDate;
        public int id;

        public Author(string Name, string Surname, DateTime BirthDate)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.BirthDate = BirthDate;
            id = ++Id;
        }

        public override string ToString()
        {
            return $"<Author {Name} {Surname}: id: {id}, birthdate: {BirthDate}>";
        }
    }
}
