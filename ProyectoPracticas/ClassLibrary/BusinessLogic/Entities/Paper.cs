using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper()
        {
            CoAuthors= new List<Person>();

        }

        public Paper(string title, DateTime uploadDate, Area belongingArea, User responsible)
        {
            Title = title;
            UploadDate = uploadDate;
            BelongingArea = belongingArea;
            CoAuthors = new List<Person>();
            Responsible = responsible;

            CoAuthors.Add(responsible);

        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public int GetId()
        {
            return Id;
        }

         public ICollection<string> GetAuthorNames()
        {
            ICollection<string> authorNames = new List<string>();
            foreach (Person p in CoAuthors)
            { 
                authorNames.Add(p.GetFullName());
            }
            return authorNames;
        }

        public Issue GetIssue()
        {
            return Issue;
        }

        public void SetIssue(Issue i)
        {
            Issue = i;
        }


        public string GetEstado() // primer if --> BelongingArea != null && EvaluationPendingArea == null && PublicationPendingArea
        {
            string res;
            if (EvaluationPendingArea != null)
            {
                res = "Pendiente de evaluación.";
            }
            else if(PublicationPendingArea != null)
            {
                res = "Pendiente de publicación.";
            } 
            else
            {
                res = "Artículo rechazado.";
            }
            return res;
        }

        //CAMBIAR COSAS A PARTIR DE AQUÍ
        public Area GetArea() // AQUÍ DEBE DEVOLVER BELONGING AREA
        {
            return BelongingArea;
        }

        public void SetBelongingArea(Area a)
        {
            BelongingArea = a;
        }

        public void SetPublicationPendingArea(Area a)
        {
            EvaluationPendingArea = null;
            PublicationPendingArea = a;
        }

        public void SetUploadDate(DateTime upload)
        {
            UploadDate = upload;
        }

        public void SetEvaluationPendingArea(Area evaluationPend)
        {
            EvaluationPendingArea = evaluationPend;
        }

        public void SetResponsible(User responsible)
        {
            Responsible = responsible;

        }

        public void AddCoauthor(Person coauthor)
        {
            CoAuthors.Add(coauthor);
        }

        public DateTime GetUploadDate()
        {
            return UploadDate;
        }

        public void SetEvaluation(Evaluation e)
        {
            Evaluation = e; 
        }
    }
}
