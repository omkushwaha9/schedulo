namespace Schedulo.Domain.Entities;

public class Service
{
    public Guid Id { get; private set; }

    public Guid BusinessId { get; private set; }

    public Business Business { get; private set; } = null!;

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public int DurationInMinutes { get; private set; }

    public decimal Price { get; private set; }

    public bool IsActive { get; private set; }

    public DateTime CreatedAtUtc { get; private set; }

    private Service()
    {
    }

    public Service(
        Guid businessId,
        string name,
        string description,
        int durationInMinutes,
        decimal price)
    {
        if (durationInMinutes <= 0)
        {
            throw new ArgumentException(
                "Service duration must be greater than zero.",
                nameof(durationInMinutes));
        }

        if (price < 0)
        {
            throw new ArgumentException(
                "Service price cannot be negative.",
                nameof(price));
        }

        Id = Guid.NewGuid();
        BusinessId = businessId;
        Name = name;
        Description = description;
        DurationInMinutes = durationInMinutes;
        Price = price;
        IsActive = true;
        CreatedAtUtc = DateTime.UtcNow;
    }

    public void Update(
        string name,
        string description,
        int durationInMinutes,
        decimal price)
    {
        if (durationInMinutes <= 0)
        {
            throw new ArgumentException(
                "Service duration must be greater than zero.",
                nameof(durationInMinutes));
        }

        if (price < 0)
        {
            throw new ArgumentException(
                "Service price cannot be negative.",
                nameof(price));
        }

        Name = name;
        Description = description;
        DurationInMinutes = durationInMinutes;
        Price = price;
    }

    public void Activate()
    {
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}