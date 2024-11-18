using ScoreApi.Models;

public class BoardType : ObjectType<Board>
{
    protected override void Configure(IObjectTypeDescriptor<Board> descriptor)
    {
        base.Configure(descriptor);
    }
}