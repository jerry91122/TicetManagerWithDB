using ConsoleTicetManager_ver_1._0;
using ConsoleTicetManager_ver_1.Data;
using ConsoleTicetManager_ver_1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace ConsoleTicetManager_ver_1
{
	public class Program
	{
		static void Main()
		{
			LoginWindow.Login();

		}
		public static void StartApp()
		{
			Ticet.EditTicet();
			DrawTabel.UpTabel();
			Ticet.ShowTicet();

		}
	}
}