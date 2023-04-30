using ConsoleTicetManager_ver_1.Models;
using Microsoft.EntityFrameworkCore;


namespace ConsoleTicetManager_ver_1.Data
{
    public class TicetManagerContext:DbContext
    {
		public DbSet<Chat> Chats { get; set; } = null;
		public DbSet<Ticet> Ticets { get; set; } = null;
		public DbSet<User> Users { get; set; } = null;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TerminalTicetManager;Integrated Security=True;");
		}

	}
}
