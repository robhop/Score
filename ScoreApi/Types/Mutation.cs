using HotChocolate.Subscriptions;

namespace ScoreApi.Types;

public class Mutation
{
    public async Task<Book> AddBook(Book book, ITopicEventSender sender)
    {

        await sender.SendAsync("bookAdded", book);
        return book;

        // Omitted code for brevity
    }
}
