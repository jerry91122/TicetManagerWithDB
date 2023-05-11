using ConsoleTicetManager_ver_1._0;
using ConsoleTicetManager_ver_1.Models;
using System;
using System.ComponentModel.Design;

namespace ConsoleTicetManager_ver_1
{
	public class DrawTabel:LoginWindow
	{
		public static void UpTabel()
		{
			Console.Clear();
			System.Console.WriteLine($"App Console Ticet Manger             zalogowany jako:{LoginUser}");
			System.Console.WriteLine();

		}
		public static void DownTabel()
		{
			if (LoginRole == "Admin")
			{
				System.Console.WriteLine("1. Nowy || 2. Edytuj ||3. Ustawienia ||4. Wyloguj ||5.Czat ||6.Sortuj || 7. Szukaj || 8.Zakoñcz Program");
				int jakiKlawisz;
				switch (jakiKlawisz = int.Parse(Console.ReadLine()))
				{
					case 1:
						Ticet.AddTicet();
						break;
					case 2:
						Ticet.EditTicet();
						break;
					case 3:
						break;
					case 4:
						LoginWindow.Login();
						break;
					case 5:
						break;
					case 6:
						break;
					case 7:
						break;
					case 8:
						Environment.Exit(0);
						break;
				}
			}
			else
			{
				System.Console.WriteLine("1. Nowy ||2. Wyloguj ||3.Czat ||4.Sortuj || 5.Zakoñcz Program");
				int jakiKlawisz;
				switch (jakiKlawisz = int.Parse(Console.ReadLine()))
				{
					case 1:
						Ticet.AddTicet();
						break;
					case 2:
						LoginWindow.Login();
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						Environment.Exit(0);
						break;
				}
			}
		}
	}
}