using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.BusinessLogic.Services
{
    public class IssueDTO
    {
        public int Number;
        public DateTime? Date;

        public IssueDTO(int number, DateTime? date)
        {
            Number = number;
            Date = date;
        }

        public DateTime? GetDateTime()
        {
            return Date;
        }

        public void SetDateTime(DateTime? d)
        {
            Date = d;
        }

        public int GetNumber()
        {
            return Number;
        }

        public void SetNumber(int n)
        {
            Number = n;
        }
    }
}
