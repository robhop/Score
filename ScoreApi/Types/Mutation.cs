using HotChocolate.Subscriptions;
using Microsoft.EntityFrameworkCore;
using ScoreApi.Models;

namespace ScoreApi.Types;

public class Mutation
{

    public async Task<Board> AddBoard(ScoreContext context, string name)
    {
        var board = new Board { Name = name, BoardId = Guid.NewGuid() };
        context.Boards.Add(board);
        await context.SaveChangesAsync();
        return board;
    }

    public async Task<Board> AddScore(ScoreContext context,ITopicEventSender sender, Guid boardId, int score, string description = "")
    {
        var board = await context.Boards.FindAsync(boardId);
        if (board == null)
        {
            throw new ArgumentException("Board not found", nameof(boardId));
        }
        var newScore = new Score { Value = score, Board = board, Description = description };
        board.Scores.Add(newScore);
        await context.SaveChangesAsync();

        await sender.SendAsync("updateBoard", boardId);

        return await context.Boards
            .AsNoTrackingWithIdentityResolution()
            .Include(b => b.Scores)
            .Where(b => b.BoardId == boardId)
            .SingleAsync();
    }
    public async Task<Book> AddBook(Book book, ITopicEventSender sender)
    {

        
        await sender.SendAsync("bookAdded", book);
        return book;

        // Omitted code for brevity
    }
}
