using Microsoft.EntityFrameworkCore;

namespace ScoreApi.Models;
public class ScoreContext : DbContext
{
    required public DbSet<Board> Boards { get; set; }

    public ScoreContext()
    {
    }

    public ScoreContext(DbContextOptions<ScoreContext> options) : base(options) {
    }

    /*
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseSqlite("Data Source=score.db");
       }

       */

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var board = modelBuilder.Entity<Board>( board => {
            board.Property(b => b.BoardId)
            .ValueGeneratedOnAdd();
            board.HasKey(b => b.BoardId);
            board.HasMany(b => b.Scores)
                .WithOne(s => s.Board);
        });

        var score = modelBuilder.Entity<Score>(score => {
            score.Property(s => s.ScoreId)
            .ValueGeneratedOnAdd();
            score.HasKey(s => s.ScoreId);
            score.HasOne(s => s.Board)
                .WithMany(b => b.Scores);
        });
    }
}
