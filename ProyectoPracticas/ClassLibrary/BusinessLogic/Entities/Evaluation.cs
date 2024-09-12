using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Evaluation {

        public Evaluation(){

        }

        public Evaluation(bool accepted, string comments, DateTime date)
        {
            Accepted = accepted;
            Comments = comments;
            Date = date;
            
        }
    }
}
