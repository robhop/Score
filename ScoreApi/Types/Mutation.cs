using HotChocolate.Subscriptions;
using ScoreApi.Models;

namespace ScoreApi.Types;

public class Mutation
{

    public async Task<Board> AddBoard(ScoreContext context, Board board)
    {

        context.Boards.Add(board);
        await context.SaveChangesAsync();
        return board;
    }
    public async Task<Book> AddBook(Book book, ITopicEventSender sender)
    {

        
        await sender.SendAsync("bookAdded", book);
        return book;

        // Omitted code for brevity
    }
}
