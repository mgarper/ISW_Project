using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public virtual User ChiefEditor { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
    }
}
