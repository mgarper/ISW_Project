using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
        public bool Alerted { get; set; }
        public string AreasOfInterest { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual Area Area { get; set; }
        public virtual Magazine Magazine { get; set; }
        public virtual ICollection<Paper> MainAuthoredPapers { get; set; }
    }
}
