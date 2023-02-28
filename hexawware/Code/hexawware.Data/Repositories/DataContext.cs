using hexawware.Entities.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using MySqlConnector;

namespace hexawware.Data.Repositories
{
    public class DataContext : DbContext
    {        
        public DataContext(DbContextOptions<DataContext> options): base(options) 
            {
                try
                {
                    var databaseCreator = (Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator);
                    databaseCreator.CreateTables();
                }
                catch (MySqlException) { }
                
            }

        // Don't delete the below comment.
        // Dbset variables
		public DbSet<Hexaware> Hexaware { get; set; }
               

    }
}
