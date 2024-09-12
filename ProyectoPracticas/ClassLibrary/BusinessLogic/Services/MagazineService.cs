//using Magazine.BusinessLogic.Services;
using Magazine.BusinessLogic.Services;
using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Schema;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace Magazine.Services
{
    public class MagazineService : IMagazineService
    {
        private readonly IDAL dal;
        public User ActiveUser { get; set; }


        public MagazineService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "ptheboss@gmail.com", "theboss", "1234");
            AddUser(u1);

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            AddMagazine(m);

            User u2 = new User("2345", "Javier", "Garcia", false, "la mia", "jgarcia@gmail.com", "jgarcia", "1234");
            AddUser(u2);
            Area a1 = new Area("Area 1", u2, m);
            a1.SetEvaluationPending(new List<Paper>());
            AddArea(a1);

            User u3 = new User("3456", "Mª Carmen", "Jimenez", false, "la mia por supuesto", "mcjimenez@gmail.com", "mcjimenez", "1234");
            AddUser(u3);
            Area a2 = new Area("Area 2", u3, m);
            AddArea(a2);

            // De regalo
            User u4 = new User("4567", "Juan", "Campeador", false, "la mejor", "jcampeador@gmail.com", "jcampeador", "1234");
            AddUser(u4);

            User u5 = new User("6789", "Paco", "Gonzalez", false, "el pibe", "pmerm@gmail.com", "pmermela", "asd123");
            AddUser(u5);
        }

        public void AddPerson(Person person)
        {
            // Restricción: No puede haber dos personas con el mismo DNI
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddMagazine(Magazine.Entities.Magazine magazine)

        {
            // Restricción: No puede haber dos revistas con el mismo nombre
            if (!dal.GetWhere<Magazine.Entities.Magazine>(x => x.Name == magazine.Name).Any())
            {
                dal.Insert<Magazine.Entities.Magazine>(magazine);
                dal.Commit();
            }
            else throw new ServiceException("Magazine with name " + magazine.Name + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos areas con el mismo nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with name " + area.Name + " already exists.");
        }

        // A partid de aquí escribid vuestras implementaciones

        public void AddUser(User user)
        {
            // Restricción: no pueden existir dos usuarios con el mismo DNI
            if (dal.GetById<User>(user.Id) == null)
            {
                dal.Insert<User>(user);
                dal.Commit();
            }
            else throw new ServiceException("User with Id " + user.Id + " already exists.");
        }

         //CASO DE USO: CONFECCIONAR EJEMPLAR 
         // Actualiza las listas en BBDD
        public void UpdateNextIssue(string area, ICollection<int> papers, ICollection<int> publicationPending)
        {
            //NOTA: Los elementos que aparecen en Papers son artículos
            //aprobados por el editor jefe que no han sido publicados en el
            //ejemplar pero si en el area
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            
            Area a = GetAreaByName(area);

            Console.WriteLine(papers.Count + "-" + publicationPending.Count);
            ICollection<Paper> pPending = new List<Paper>();

            Issue i = dal.GetWhere<Issue>(x => x.PublicationDate > DateTime.Now || x.PublicationDate == null).FirstOrDefault();

            for (int j=0; j<papers.Count; j++)
            {
                Paper p = dal.GetById<Paper>(papers.ElementAt<int>(j));
                p.SetIssue(i);
                p.SetPublicationPendingArea(null);
                i.addPaper(p);

            }

            for (int j=0; j<publicationPending.Count; j++)
            {
                Paper p = dal.GetById<Paper>(publicationPending.ElementAt<int>(j));
                pPending.Add(p);
                p.SetIssue(null);
                p.SetPublicationPendingArea(p.GetArea());

            }

            a.SetPublicationPending(pPending);

            dal.Commit();
        }

        // Establece una fecha al ejemplar
        public bool SetDate(DateTime d)
        {
            if(checkCorrectDate(d))
            {
                Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
                Issue i = dal.GetWhere<Issue>(x => x.PublicationDate > DateTime.Now || x.PublicationDate == null).FirstOrDefault();

                i.setDate(d);

                dal.Commit();
                return true;
            }
            else
            {
                return false;
            }
        }

        // Añade un articulo a la lista de publicación 
        public void AddPaperToPublish(int id, ICollection<PaperDTO> papers, ICollection<PaperDTO> publicationPending)
        {
            PaperDTO aux = null;
            bool seguir = true;

            for (int j=0; j<publicationPending.Count() && seguir; j++)
            {
                if(publicationPending.ElementAt<PaperDTO>(j).GetId() == id)
                {
                    aux = publicationPending.ElementAt<PaperDTO>(j);
                    publicationPending.Remove(aux);
                    seguir = false;

                    Paper p = dal.GetById<Paper>(id);
                    
                }
            }
            papers.Add(aux);

        }

        //Elimina un articulo de la lista de publicación 
        public void RemovePaperFromPublish(int id, ICollection<PaperDTO> papers, ICollection<PaperDTO> publicationPending)
        {
            PaperDTO aux = null;
            bool seguir = true;

            for (int j = 0; j < papers.Count() && seguir; j++)
            {
                if (papers.ElementAt<PaperDTO>(j).GetId() == id)
                {
                    aux = papers.ElementAt<PaperDTO>(j);
                    papers.Remove(aux);
                    seguir = false;

                    Paper p = dal.GetById<Paper>(id);

                }
            }
            publicationPending.Add(aux);
        }

        //Devuelve el siguiente número a publicar 
        public IssueDTO GetNextNumberIssue()
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            IEnumerable<Issue> l = dal.GetAll<Issue>();
            Issue aux = null;

            IssueDTO res = null;
            int num = 0;

            if (l.Count() == 0)
            {
                aux = new Issue(1, m);

                dal.Insert<Issue>(aux);
                dal.Commit();

                res = new IssueDTO(1, DateTime.Now);

                return res;
            }
            else
            {
                Issue i = dal.GetWhere<Issue>(x => x.PublicationDate > DateTime.Now || x.PublicationDate == null).FirstOrDefault();

                DateTime? d = DateTime.Now;
                
                if(i == null)
                {
                    i = new Issue(dal.GetAll<Issue>().Last<Issue>().GetNumber() + 1, m);

                    dal.Insert<Issue>(i);
                    dal.Commit();

                    num = i.GetNumber();
                } 
                else
                {
                    num = i.GetNumber();

                    if(i.GetPublicationDate() != null)
                    {
                        d = i.GetPublicationDate();
                    }
                }

                res = new IssueDTO(num, d);

                return res;
            }

            
        }

        //Devuelve una lista con los nombres de las areas existentes 
        public ICollection<string> GetAreas()
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            return m.GetAreas();
        }

        //Devuelve la lista de artículos que están pendientes de publicación 
        public ICollection<PaperDTO> GetPublicationPending(string area)
        {
            ICollection<PaperDTO> res = new List<PaperDTO>();

            Area a = GetAreaByName(area);
            ICollection<int> aux = a.GetPublicationPending();

            foreach (int i in aux)
            {
                PaperDTO pd = new PaperDTO();

                string p = GetPaperById(i);

                pd.SetTitle(p);
                pd.SetId(i);

                res.Add(pd);
            }

            return res;
        }

        // Devuelve la lista de artículos seleccionados para publicar
        public ICollection<PaperDTO> GetPapers(string area, int number)
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            ICollection<Paper> pp = dal.GetWhere<Issue>(x => x.Number == number).FirstOrDefault().getPublishedPapers();

            ICollection<PaperDTO> res = new List<PaperDTO>();

            

            foreach (Paper pa in pp)
            {
                if(pa.GetArea().GetName() == area)
                {
                    PaperDTO pd = new PaperDTO();

                    pd.SetTitle(pa.GetTitle());
                    pd.SetId(pa.GetId());

                    res.Add(pd);
                }
            }

            return res;
        }

        //Obtiene el título del artículo mediante su ID 
        public string GetPaperById(int id)
        {
            return dal.GetById<Paper>(id).GetTitle();
        }

        //Comprueba que la fecha introducida sea posterior a la fecha actual
        public bool checkCorrectDate(DateTime d)
        {
            return DateTime.Now <= d;
        }

        //CASO DE USO: LISTADO DE TODOS LOS ARTÍCULOS 

        public  ICollection<PaperDTO> ListAllPapers() 
        {
            ICollection<Area> areas = dal.GetAll<Area>().ToList();
            ICollection<Paper> papers = dal.GetAll<Paper>().ToList();
            ICollection<PaperDTO> result = new List<PaperDTO>();

            for(int i = 0; i<areas.Count(); i++)
            {
                Area a = areas.ElementAt<Area>(i);
                for(int j = 0; j < papers.Count(); j++)
                {
                    Paper p = papers.ElementAt<Paper>(j);

                    if (p.GetArea().GetName() == a.GetName())
                    {
                        PaperDTO aux = new PaperDTO();

                        aux.SetTitle(p.GetTitle());
                        aux.SetAuthors(p.GetAuthorNames());
                        aux.SetArea(a.GetName());

                        if (p.GetIssue() != null)
                        {
                            aux.SetBelongingIssue(p.GetIssue().GetNumber());
                            aux.SetEstado("Publicado en ejemplar.");
                        }
                        else
                        {
                            aux.SetEstado(p.GetEstado());
                        }

                        
                        
                        result.Add(aux); 
                    }

                    
                    
                }
            }
            
            return result;
        }

        public ICollection<PaperDTO> SortByIssue(int issue, ICollection<PaperDTO> p) 
        {
            ICollection<PaperDTO> result = new List<PaperDTO>();
            
            foreach(PaperDTO pp in p)
            {
                if(pp.GetBelongingIssue() == issue)
                {
                    result.Add(pp);
                }
            }

            if(result.Count() > 0)
            {
                return result;
            }
            else throw new ServiceException("There are no papers for this issue.");
        }

        //CASO DE USO: ENVÍO DE ARTÍCULO

        // Almacena el nuevo artículo en BBDD
        public bool StorePaper(string area, string titulo)
        {
            Area a = GetAreaByName(area);
            if(a != null)
            {
                Paper articulo = new Paper();
                DateTime t = DateTime.Now;
                User responsible = ActiveUser;

                articulo.SetResponsible(responsible);
                articulo.AddCoauthor(responsible);
                articulo.SetEvaluationPendingArea(a);
                articulo.SetBelongingArea(a);
                articulo.SetUploadDate(t);
                articulo.SetTitle(titulo);

                a.AddNewPaper(articulo);
                responsible.AddCoAutPaper(articulo);
                responsible.AddMAutPaper(articulo);

                dal.Insert<Paper>(articulo);
                dal.Commit();
                return true;
            }
            return false;
        }

        // Permite añadir coautores a un artículo
        public bool AnyadirCoautores(int idArticulo,string dni)
        {
            Paper p = dal.GetById<Paper>(idArticulo);
            if(p.GetAuthorNames().Count() < 4)
            {
                Person pp = dal.GetById<Person>(dni);
                p.AddCoauthor(pp);
                return true;

            }

            return false;
        }


        //CASO DE USO: EVALUAR ARTÍCULO
        //1.Mostrar EvaluationPendingArea
        //2.Crear un Evaluation y almacenar dicho Evaluation en su paper
        //3.Si ACCEPTED, entonces se elimina de EvaluationPending y pasa
        //a PublicationPending.Si REJECTED, sólo se elimina de EvaluationPending

        public ICollection<PaperDTO> MostrarSinEvaluar(string area)
        {
            Area a = GetAreaByName(area); //FALLA AQUÍ
            Console.WriteLine(a.GetName());
            Console.WriteLine(a.GetEvaluationPending().Count());
            ICollection<PaperDTO> res = new List<PaperDTO>();   
            ICollection<Paper> sinEvaluar = a.GetEvaluationPending(); 
            for(int i = 0; i < sinEvaluar.Count(); i++)
            {
                Paper p = sinEvaluar.ElementAt(i);
                PaperDTO pd = new PaperDTO(p.GetId(), p.GetTitle(), p.GetAuthorNames(), "pendienteEvaluar" ,p.GetUploadDate());
                res.Add(pd);
            }
             return res;

        }
        
        public void EvaluarArticulo(string area, int id, string comments, bool accepted, DateTime fechaEvaluacion)
        {
            Paper p = dal.GetById<Paper>(id);
            Evaluation evaluacion = new Evaluation(accepted, comments, fechaEvaluacion);
            p.SetEvaluation(evaluacion);
            Area a = GetAreaByName(area);
            if(accepted == true)
            {
                a.AddToPubPend(p);
                a.RemoveFromEval(p);
                
            } else
            {
                a.RemoveFromEval(p);
            }
            dal.Commit();

        }


        //CASO DE USO: REGISTRO
        public string SignUp(string id, string name, string surname, bool alerted, string AreaOfInterest, 
                                 string mail, string login, string psw)
        {
            // Restricción: no pueden existir dos usuarios con el mismo DNI
            ActiveUser = null;
            if (dal.GetById<User>(id) == null)
            {
                bool b = dal.GetWhere<User>(x => x.Login == login).Any();
                if (!b) 
                {
                    User user = new User(id, name, surname, alerted, AreaOfInterest, mail, login, psw);
                    ActiveUser = user;

                    dal.Insert<User>(user);
                    dal.Commit();
                    return "User";
                }
                return "Login";


            }
            return "ExistsId";
        }


        //CASO DE USO: INICIO DE SESION 
        public string SignIn(string login, string psw)
        {
            ActiveUser = null;
            if (dal.GetWhere<User>(x => x.Login == login).Any())
            {
                User u = dal.GetWhere<User>(x => x.Login == login).ElementAt(0);
                if(u.GetPassword() == psw)
                {
                    ActiveUser = u;
                    return "User";

                }
                return "Password";
            }
            return "Login";
        }

        //SERVICIOS AUXILIARES PARA LA CAPA DE PRESENTACIÓN

        //Comprueba si el usuario loggeado es el editor jefe 
        public bool IsChiefEditor()
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            return m.GetChiefEditor().GetId() == ActiveUser.GetId();
        }
        public bool IsAreaEditor()
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            bool res = false;
            ICollection<String> a = m.GetAreas();
            for (int i = 0; i<a.Count() && res==false; i++)
            {
                Area aux = GetAreaByName(a.ElementAt<String>(i));
                if(aux.GetResponsible().GetId() == ActiveUser.GetId())
                {
                    res=true;
                    Console.WriteLine("Encontrado");
                }
            }
            return res;
        }

        //Devuelve un objeto de tipo area en cuyo nombre es igual al pasado por argumentos
        public Area GetAreaByName(string area)
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            return m.GetAreaByName(area);
        }

        public ICollection<int> GetIssues()
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            return m.GetIssues();
        }

        public ICollection<PaperDTO> GetPapers()
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            ICollection<PaperDTO> documentos = new List<PaperDTO>();
            ICollection<Paper> paper = ActiveUser.GetPapers();
            foreach(Paper p in paper)
            {
                PaperDTO aux = new PaperDTO(p.GetId(),p.GetTitle(), p.GetAuthorNames(), p.GetEstado(), p.GetUploadDate());
                documentos.Add(aux);
            }
            return documentos;
        }
        
        public string getAreaFromResponsible()
        {
            Magazine.Entities.Magazine m = dal.GetAll<Magazine.Entities.Magazine>().First();
            string res = "";
            ICollection<String> a = m.GetAreas();
            for (int i = 0; i < a.Count() && res == ""; i++)
            {
                Area aux = GetAreaByName(a.ElementAt<String>(i));
                if (aux.GetResponsible().GetId() == ActiveUser.GetId())
                {
                    res = aux.GetName();
                    Console.WriteLine("Encontrado");
                }
            }
            return res;
        }

        public string GetUserNameById(string id)
        {
            string res = "";
            User u = dal.GetById<User>(id);
            if(u != null)
            {
                res += u.GetFullName();
            }
            return res;
        }
    }
}

