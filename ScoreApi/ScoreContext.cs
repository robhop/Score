using Microsoft.EntityFrameworkCore;

namespace ScoreApi.Models;
public class ScoreContext : DbContext
{
    required public DbSet<Board> Boards { get; set; }

    public string DbPath { get; }

    public ScoreContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = "blogging.db";
    }

    public ScoreContext(DbContextOptions<ScoreContext> options) : base(options) {
       DbPath = ""; 
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
