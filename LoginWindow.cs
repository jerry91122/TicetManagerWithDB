using ConsoleTicetManager_ver_1.Data;


namespace ConsoleTicetManager_ver_1._0
{
	public class LoginWindow
	{
		public static string LoginUser=" ";
		public static void Login()
		{
			
			using TicetManagerContext newContext = new TicetManagerContext();

			Console.WriteLine("Podaj swoje dane do logowania");
			Console.Write($"Login:");
			LoginUser = Console.ReadLine();
			Console.Write($"Hasło:");
			string Paswd = Console.ReadLine();

			var CheckUser = newContext.Users.FirstOrDefault(u=>u.Login==LoginUser);

			if(CheckUser!=null)
			{
				if(CheckUser.Password ==Paswd)
				{ 
					Program.StartApp();
				}
				else
				{
					Console.Clear();
					Console.WriteLine("wprowadz poprawne dane:");
					Login();
				}
			}
			else
			{
				Console.Clear();
				Login();
			}
		}
	}
}
