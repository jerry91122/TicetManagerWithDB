using ConsoleTables;
using ConsoleTicetManager_ver_1._0;
using ConsoleTicetManager_ver_1.Data;
using System.Net;

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
			using TicetManagerContext newContextTicet = new TicetManagerContext();
			
			Console.WriteLine("podaj nr Id Ticetu, który chcesz edytować");
            int chooseIdNumber =int.Parse(Console.ReadLine());
            var editTicets = newContextTicet.Ticets.FirstOrDefault(t => t.Id == chooseIdNumber);

			Console.WriteLine("co chcesz edytować");
            Console.WriteLine("1. Do kogo przypisany");
            Console.WriteLine("2. Status");
            Console.Write("Podaj cyfrę: ");
            int OptionNumber = int.Parse(Console.ReadLine());
			switch (OptionNumber)
			{
				case 1:
					System.Console.WriteLine("do kogo przypisać: ");
                    editTicets.WhoMake = Console.ReadLine();
                    newContextTicet.SaveChanges();
					break;
				case 2:
					System.Console.WriteLine("Wprowadz status od 1 do 3");
                    editTicets.Status=int.Parse(Console.ReadLine());
					newContextTicet.SaveChanges();
					break;
				case 3:
                    //main menu
                    Program.StartApp();
					break;
			}
		}
        public static void ShowTicet()
        {
			using TicetManagerContext newContextTicet = new TicetManagerContext();
            var showTicets = newContextTicet.Ticets;
            //create tabel
			var tableTicet = new ConsoleTable("ID", "Tytuł", "Opis", "Do kogo przypisane", "Data Utworzenia", "Status", "Kto zgłosił");
            //off ticet count
			tableTicet.Options.EnableCount = false;
			//show list in the tabel+add filter by user role if admin show all 
            if(LoginRole=="Admin")
            {
				foreach (var ticet in showTicets)
				{
					tableTicet.AddRow(ticet.Id, ticet.Title, ticet.Description, ticet.WhoMake, ticet.Created, ticet.Status, ticet.WhoCreated);
				}
				tableTicet.Write();
			}
            else
            {
                var filterUser = newContextTicet.Ticets.Where(c => c.WhoCreated == LoginUser);

                foreach (var ticet in filterUser)
                {
					tableTicet.AddRow(ticet.Id, ticet.Title, ticet.Description, ticet.WhoMake, ticet.Created, ticet.Status, ticet.WhoCreated);
				}
				tableTicet.Write();
			}
        }
    }
}