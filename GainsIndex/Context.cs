using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
   public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=exercise.db");
    }
   
   public DbSet<Exercise> Exercises {get;set;}
}