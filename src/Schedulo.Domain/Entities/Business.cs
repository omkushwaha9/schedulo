namespace Schedulo.Domain.Entities;

public class Business
{
    public Guid Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public string PhoneNumber { get; private set; } = string.Empty;

    public string TimeZoneId { get; private set; } = "UTC";

    public bool IsActive { get; private set; }

    public DateTime CreatedAtUtc { get; private set; }

    private Business()
    {
    }

    public Business(
        string name,
        string description,
        string email,
        string phoneNumber,
        string timeZoneId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Email = email;
        PhoneNumber = phoneNumber;
        TimeZoneId = timeZoneId;
        IsActive = true;
        CreatedAtUtc = DateTime.UtcNow;
    }

    public void UpdateDetails(
        string name,
        string description,
        string email,
        string phoneNumber,
        string timeZoneId)
    {
        Name = name;
        Description = description;
        Email = email;
        PhoneNumber = phoneNumber;
        TimeZoneId = timeZoneId;
    }

    public void Deactivate()
    {
        IsActive = false;
    }

    public void Activate()
    {
        IsActive = true;
    }
}