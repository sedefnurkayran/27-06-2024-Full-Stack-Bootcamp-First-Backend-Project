using System.Security.Cryptography.X509Certificates;

namespace Basic.Models
{
    public class Repository
    {
        private static readonly List<Bootcamp> _bootcamps = new(); //new List<Bootcamp>() ifadesinin kısaltmasi

        static Repository() //Constructor. _bootcamps listesini başlatir.
        {

            _bootcamps = new List<Bootcamp>()
            {
                new Bootcamp() {Id = 1,
                               Title = "DevOps Mastery Bootcamp",
                               Description ="Bootcamp process has been started.",
                               Image = "1.png",
                               Tags = new string[]{"html","The DevOps lifecycle"},
                               isActive = true,
                               isHome = true
                               },
                new Bootcamp() {Id = 2,
                               Title = "Java+Spring 101 Bootcamp",
                               Description ="Bootcamp process has been started.",
                               Image = "2.png",
                               Tags = new string[]{"java","Spring","web development"},
                               isActive = true,
                               isHome = true
                               },
                new Bootcamp() {Id = 3,
                                Title = "Swift UI Bootcamp",
                                Description ="Bootcamp process has been started.",
                                Image = "3.png",
                                Tags = new string[]{"swift ui","mobile development"},
                                isActive = true,
                                isHome = false
                                },
            };


        }

        public static List<Bootcamp> Bootcamps
        {
            get
            {

                return _bootcamps;

            }

        }

        public static Bootcamp? GetById(int? id)
        {
            return _bootcamps.FirstOrDefault(b => b.Id == id);
        }


    }
}