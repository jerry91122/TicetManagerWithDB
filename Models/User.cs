using ConsoleTables;
using ConsoleTicetManager_ver_1.Data;
using System.ComponentModel.DataAnnotations;

namespace ConsoleTicetManager_ver_1.Models
{
	public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
		public User( string login, string password)
		{
			Login = login;
			Password = password;
		}
		public static void AddUser()
		{
			using TicetManagerContext newContextTicet = new TicetManagerContext();
			Console.WriteLine("dodaj nowego u�ytkowika");
            Console.WriteLine();
            Console.Write("login: ");
			string log=Console.ReadLine();
            Console.Write("Has�o: ");
			string passwd=Console.ReadLine();
            Console.WriteLine("podaj rol� u�ytkownika");
            Console.WriteLine("1. Admin");
			Console.WriteLine("2. Standard");
			//in future add checked of number
			string rol =Console.ReadLine();

			User NewUser= new User(log, passwd);
			NewUser.Role = rol;
			newContextTicet.Users.Add(NewUser);
			newContextTicet.SaveChanges();

        }
		public static void EditUser()
		{
			ShowUsers();
			using TicetManagerContext newContextTicet = new TicetManagerContext();
			Console.Write("Podaj Id u�ykownika kt�rego chcesz edytowa�: ");
			int UserIdToEdit = int.Parse(Console.ReadLine());
			var editUser = newContextTicet.Users.FirstOrDefault(t => t.IdUser == UserIdToEdit);

			Console.WriteLine("co chcesz edytowa�");
			Console.WriteLine("1. login");
			Console.WriteLine("2. has�o");
            Console.WriteLine("3. rol� u�ytkownika");
            Console.Write("Podaj cyfr�: ");
			int OptionNumber = int.Parse(Console.ReadLine());
			switch (OptionNumber)
			{
				case 1:
					System.Console.WriteLine("do kogo przypisa�: ");
					editUser.Login = Console.ReadLine();
					newContextTicet.SaveChanges();
					break;
				case 2:
					System.Console.WriteLine("Wprowadz status od 1 do 3");
					editUser.Password = Console.ReadLine();
					newContextTicet.SaveChanges();
					break;
				case 3:
					System.Console.WriteLine("Wprowad� now� role: Admin lub Standard");
					editUser.Role = Console.ReadLine();
					newContextTicet.SaveChanges();
					break;
				case 4:
					//main menu
					Program.StartApp();
					break;
			}
		}
		public static void ShowUsers()
		{
			using TicetManagerContext newContextTicet = new TicetManagerContext();
			var showUsers = newContextTicet.Users;
			//create tabel
			var tableUsers = new ConsoleTable("ID", "Login", "Has�o", "Rola");
			//off ticet count
			tableUsers.Options.EnableCount = false;
			foreach (var user in showUsers)
			{
				tableUsers.AddRow(user.IdUser,user.Login,user.Password,user.Role);
			}
			tableUsers.Write();
		}
	}
}