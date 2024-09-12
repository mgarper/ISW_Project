using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
        public Area()
        {
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();
        }

        public Area(string name, User editor, Magazine magazine)
        {
            Name = name;
            Magazine = magazine;

            Editor = editor;
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();
        }

        public string GetName()
        {
            return Name;
        }

        public ICollection<int> GetPublicationPending()
        {
            ICollection<int> result = new List<int>();
            for(int i = 0; i<PublicationPending.Count; i++)
            {
                result.Add(PublicationPending.ElementAt<Paper>(i).GetId());
            }
            return result;
        }

        public void SetPublicationPending(ICollection<Paper> p)
        {
            PublicationPending = p;
        }

        public void AddNewPaper(Paper articulo)
        {
            if(EvaluationPending == null)
            {
                EvaluationPending = new List<Paper>();
            }
            EvaluationPending.Add(articulo);
        }

        public ICollection<Paper> GetEvaluationPending()
        {

            return EvaluationPending;
        }
        public void SetEvaluationPending(ICollection<Paper> p)
        {
            EvaluationPending = p;
        }

        public User GetResponsible()
        {
            return Editor;
        }
        public void RemoveFromEval(Paper p)
        {
            EvaluationPending.Remove(p);
        }

        public void AddToPubPend(Paper p)
        {
            PublicationPending.Add(p);
        }
    }
}
