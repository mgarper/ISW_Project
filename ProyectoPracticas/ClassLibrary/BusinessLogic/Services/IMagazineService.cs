using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.BusinessLogic.Services;
//using Magazine.BusinessLogic.Services;
using Magazine.Entities;


namespace Magazine.Services
{
    public interface IMagazineService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddPerson(Person p);
        void AddMagazine(Magazine.Entities.Magazine m);
        void AddArea(Area a);

        // A partir de aquí cread los vuestros
        void AddUser(User u);
        void UpdateNextIssue(string area, ICollection<int> papers, ICollection<int> publicationPending);
        bool SetDate(DateTime d);
        IssueDTO GetNextNumberIssue();
        ICollection<string> GetAreas();
        bool IsChiefEditor();
        ICollection<PaperDTO> GetPublicationPending(string area);
        ICollection<PaperDTO> GetPapers(string area, int number);
        void AddPaperToPublish(int id, ICollection<PaperDTO> papers, ICollection<PaperDTO> publicationPending);
        void RemovePaperFromPublish(int id, ICollection<PaperDTO> papers, ICollection<PaperDTO> publicationPending);
        Area GetAreaByName(string area);
        bool checkCorrectDate(DateTime d);
        bool StorePaper(string area, string titulo);
        ICollection<PaperDTO> ListAllPapers();
        ICollection<PaperDTO> SortByIssue(int issue, ICollection<PaperDTO> p);
        bool AnyadirCoautores(int idArticulo, string dni);
        ICollection<PaperDTO> MostrarSinEvaluar(string area);
        void EvaluarArticulo(string area, int id, string comments, bool accepted, DateTime fechaEvaluacion);
        string SignUp(string id, string name, string surname, bool alerted, string AreaOfInterest,
                               string mail, string login, string psw);
        string SignIn(string login, string psw);
        bool IsAreaEditor();
        ICollection<int> GetIssues();
        ICollection<PaperDTO> GetPapers();
        string getAreaFromResponsible();
        string GetUserNameById(string id);
    }
}
