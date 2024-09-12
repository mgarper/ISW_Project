using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Services
{
    public class PaperDTO
    {
        string Area { get; set; }
        int Id { get; set; }
        string Title { get; set;}
        int BelongingIssue { get; set; }
        ICollection<string> Authors { get; set; }
        string Estado { get; set; }
        DateTime Envío { get; set; }
        

        public PaperDTO()
        {
            ICollection<string> Authors = new List<string>();
            BelongingIssue = -1;
        }

        public PaperDTO(int id, string title, ICollection<string> authors, string estado, DateTime fechaEnvío)
        {
            Id = id;
            Title = title;
            Authors = authors;
            Estado = estado;
            Envío = fechaEnvío;
            BelongingIssue = -1;
        }
        public DateTime GetEnvío()
        {
            return Envío;
        }

        public int GetBelongingIssue()
        {
            return BelongingIssue;
        }
        public void SetBelongingIssue(int number)
        { 
            BelongingIssue = number;
        }

        public void SetTitle(string title)
        {
            Title=title;
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetAuthors(ICollection<string> l)
        {
            Authors = l;
        }

        public void SetEstado(string estado)
        {
            Estado = estado;    
        }

        public string GetEstado()
        {
            return Estado;
        }

        public ICollection<string> GetAuthors()
        {
            return Authors;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetArea(string area)
        {
            Area = area;
        }

        public string GetArea()
        {
            return Area;
        }
    }
}
