using ScoreApi.Models;

namespace ScoreApi.Types;

[QueryType]
public static class Query
{
    public static Book GetBook()
        => new Book("C# in depth.", new Author("Jon Skeet"));

   public static IEnumerable<Board> GetBoards(ScoreContext scoreContext) {
    return scoreContext.Boards;
   } 
}
