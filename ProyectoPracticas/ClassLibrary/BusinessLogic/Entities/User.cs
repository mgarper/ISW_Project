using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    { 
        public User() : base()
        {
            MainAuthoredPapers = new List<Paper>();
        }
        public User(String id, String name, String surname, bool alerted, string areasOfInterest, string email, string login, string password) : base(id, name, surname)
        {
            this.Alerted = alerted;
            this.AreasOfInterest = areasOfInterest;
            this.Email = email;
            this.Login = login;
            this.Password = password;

            this.MainAuthoredPapers = new List<Paper>();

        }

        public string GetId()
        {
            return Id;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void AddMAutPaper(Paper articulo)
        {
            MainAuthoredPapers.Add(articulo);
        }

        public ICollection<Paper> GetPapers()
        {
            return MainAuthoredPapers;
        }
    }
}
