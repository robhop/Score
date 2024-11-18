using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using Microsoft.EntityFrameworkCore;
using ScoreApi.Models;

namespace ScoreApi.Types;

public class SubscriptionType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor
            .Field("updateBoard")
            .Type<BoardType>()
            .Resolve(async context => {
               using var db =  context.Service<IDbContextFactory<ScoreContext>>().CreateDbContext();
               var id  = context.GetEventMessage<Guid>();
               return await db.Boards
                .AsNoTrackingWithIdentityResolution()
                .Include(b => b.Scores)
                .Where(b => b.BoardId == id)
                .SingleAsync();
            })
            .Subscribe(async context =>
            {
                var receiver = context.Service<ITopicEventReceiver>();
                ISourceStream stream = await receiver.SubscribeAsync<Guid>("updateBoard");
                return stream;
            });
    }
}
