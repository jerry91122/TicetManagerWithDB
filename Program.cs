using ConsoleTicetManager_ver_1._0;
using ConsoleTicetManager_ver_1.Models;

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
			DrawTabel.UpTabel();
			Ticet.ShowTicet();
			DrawTabel.DownTabel();

		}
	}
}