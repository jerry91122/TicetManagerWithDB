using ConsoleTicetManager_ver_1._0;
using ConsoleTicetManager_ver_1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTicetManager_ver_1.Models
{
    public class Ticet:LoginWindow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string WhoCreated { get; set; }
        public DateTime Created { get; set; }
        public string WhoMake { get; set; }
        public int Status { get; set; }
        public Ticet(string title,string description)
        {
            Title = title;
            Description = description;
            WhoCreated = LoginUser;
            Created = DateTime.Now;
            WhoMake = "Nieprzydzielone";
            Status = 0;
        }
        public static void AddTicet()
        {
			using TicetManagerContext newContextTicet = new TicetManagerContext();

            // fill properies of object
			Console.WriteLine("Dodaj nowy ticket");
			Console.Write("Temat:");
            string title = Console.ReadLine();
            Console.Write("Opis");
            string description = Console.ReadLine();
            string whoCreated = LoginUser;
            DateTime created = DateTime.Now;
            int status = 0;
            // create new object Ticet and add to database
            Ticet newTicet = new Ticet(title, description);
            newContextTicet.Add(newTicet);
            newContextTicet.SaveChanges();
           
        }
        public static void EditTicet()
        {
            Console.Clear();
			using TicetManagerContext newContextTicet = new TicetManagerContext();
            Console.Write("podaj ID ticetu kt�rego chcesz edytowa�:");
            int IDChoose = int.Parse(Console.ReadLine());
            //co� tu jest �le
            var editTicet = newContextTicet.Ticets.Where(t=>t.Id==IDChoose).FirstOrDefault();
            if (editTicet is Ticet)
            {
                editTicet.Title = Console.ReadLine();
            }
        }
        public static void ShowTicet()
        {
			using TicetManagerContext newContextTicet = new TicetManagerContext();
            // if item is not equal null show list, else inform user about empty list
            var showTicets = newContextTicet.Ticets;

            foreach (var ticet in showTicets)
            {
                Console.WriteLine(ticet.Title);
            }

        }
    }
}