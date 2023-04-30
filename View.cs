using ConsoleTicetManager_ver_1._0;
using System;

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
			System.Console.WriteLine("1. Nowy || 2. Edytuj ||3. Ustawienia ||4. Wyloguj ||5.Czat ||6.Sortuj || 7. Szukaj || 8.Zakoñcz Program");
			int jakiKlawisz;
			switch (jakiKlawisz = int.Parse(Console.ReadLine()))
			{

			}
		}
	}
}