
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Routing.Tree;

namespace ScoreApi.Models;

public class Score
{
    [Key]
    [Required]
    public int ScoreId { get; set; }
    public string Description { get; set; } = "";

	[Required]
    public int Value { get; set; } 
	public Board Board { get; set; } = null!;

}
