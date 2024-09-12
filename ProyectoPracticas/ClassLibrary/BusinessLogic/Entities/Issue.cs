using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue()
        {
            PublishedPapers = new List<Paper>();
        }

        public Issue(int number, Magazine magazine)
        {
            Number = number;
            PublicationDate = null;

            Magazine = magazine;
            PublishedPapers = new List<Paper>();
        }

        public int GetNumber()
        {
            return Number;
        }

        public void setDate(DateTime d)
        {
            PublicationDate=d;
        }

        public void addPaper(Paper p)
        {
            if(!PublishedPapers.Contains(p))
            {
                PublishedPapers.Add(p);
            }
        }

        public ICollection<Paper> getPublishedPapers()
        {
            return PublishedPapers;
        }

        public DateTime? GetPublicationDate()
        {
            return PublicationDate;
        }
    }
}
