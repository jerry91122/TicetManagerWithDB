using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTicetManager_ver_1.Models
{
    public class Chat
    {
        [Key]
        public int IdChat { get; set; }
       
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
		public static void AddChat()
		{

		}
		
		public static void ShowChat()
		{

		}
	}
}