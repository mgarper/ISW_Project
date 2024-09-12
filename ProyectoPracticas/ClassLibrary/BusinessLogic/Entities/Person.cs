using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        public Person()
        {
            CoAuthoredPapers = new List<Paper>();

        }
        public Person(string id,string name,string surname)
        {

            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            CoAuthoredPapers = new List<Paper>();
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }

         public void AddCoAutPaper(Paper articulo)
        {
            CoAuthoredPapers.Add(articulo);
        }

    }
}
