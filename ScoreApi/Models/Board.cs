using System.ComponentModel.DataAnnotations;

namespace ScoreApi.Models;

public class Board
{
    [Key]
    [Required]
    public Guid BoardId { get; set; }
    public string Name { get; set; } = "";
    public List<Score> Scores { get; set; } = [];

}
