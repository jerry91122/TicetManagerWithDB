using System.ComponentModel.DataAnnotations;

namespace ConsoleTicetManager_ver_1.Models
{
	public class Chat
    {
        [Key]
        public int IdChat { get; set; }
       
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
		public Chat( string text)
		{

		}
		public static void AddChat()
		{

		}
		
		public static void ShowChat()
		{

		}
	}
}