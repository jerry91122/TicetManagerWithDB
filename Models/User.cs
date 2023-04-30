using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTicetManager_ver_1.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
		public static void AddUser()
		{

		}
		public static void EditUser()
		{

		}
		public static void ShowUsers()
		{

		}
	}
}