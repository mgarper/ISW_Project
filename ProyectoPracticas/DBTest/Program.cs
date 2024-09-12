using System;
using System.Data.Entity.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Magazine.Entities;
using Magazine.Persistence;


namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                new Program();
            }
            catch (Exception e)
            {
                printError(e);
            }
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }

        static void printError(Exception e)
        {
            while (e != null)
            {
                if (e is DbEntityValidationException)
                {
                    DbEntityValidationException dbe = (DbEntityValidationException)e;

                    foreach (var eve in dbe.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                e = e.InnerException;
            }
        }


        Program()
        {
            IDAL dal = new EntityFrameworkDAL(new MagazineDbContext());

            CreateSampleDB(dal);
        }

        private void CreateSampleDB(IDAL dal)
        {
            dal.RemoveAllData();
            Console.WriteLine("Creando los datos y almacenándolos en la BD");
            Console.WriteLine("===========================================");

            Console.WriteLine("\n// CREACIÓN DE UNA REVISTA Y SU EDITOR EN JEFE");
            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "pgarcia@gmail.com", "theboss", "1234");
            dal.Insert<User>(u1);
            dal.Commit();

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            u1.Magazine = m;

            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Commit();

            Console.WriteLine("Nombre de la revista: " + m.Name);
            Console.WriteLine("  Editor de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);

            Console.ReadKey();

            // Populate here the rest of the database with data
            Magazine.Entities.Issue i = new Magazine.Entities.Issue(1,m);
            m.Issues.Add(i);
            Console.WriteLine("Número de la revista: " + i.Number);
            dal.Insert<Magazine.Entities.Issue>(i);
            dal.Commit();

            User editor = new User("5487","Pedro","Bizum",false,"Futbol","pedrobizum@gmail.com","LetMePayHer","asd123");
            Magazine.Entities.Area a = new Magazine.Entities.Area("El Chiringuito",editor, m);
            m.Areas.Add(a);
            Console.WriteLine("Nombre de editor de área: " + editor.Name);
            Console.WriteLine("Nombre de área: " + a.Name);
            dal.Insert<Magazine.Entities.Area>(a);
            dal.Insert<User>(editor);
            dal.Commit();

            User resp = new User("6598", "Javier", "Sáiz", false, "Gatos", "jclementin@gmail.com", "PistoEnjoyer", "javierAckerman123");
            Paper p = new Paper("Posts tristes en Twitter", new DateTime(2011, 6, 10), a, resp);
            p.EvaluationPendingArea = a;
            Console.WriteLine("Nombre autor: " + resp.Name);
            Console.WriteLine("Nombre del artículo: " + p.Title);
            dal.Insert<Paper>(p);
            dal.Insert<User>(resp);
            dal.Commit();
            //TODO COMPROBADO
        }

    }

}