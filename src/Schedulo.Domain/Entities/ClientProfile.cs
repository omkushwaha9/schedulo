namespace Schedulo.Domain.Entities;

public class ClientProfile
{
    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public User User { get; private set; } = null!;

    public DateTime CreatedAtUtc { get; private set; }

    private ClientProfile()
    {
    }

    public ClientProfile(Guid userId)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        CreatedAtUtc = DateTime.UtcNow;
    }
}