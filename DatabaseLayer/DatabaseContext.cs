using DatabaseLayer.Tables;
using System.Data.Entity;

namespace DatabaseLayer
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Filedata> Filedata { get; set; }
	}
}
