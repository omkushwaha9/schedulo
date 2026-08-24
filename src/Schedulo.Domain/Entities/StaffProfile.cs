namespace Schedulo.Domain.Entities;

public class StaffProfile
{
    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public User User { get; private set; } = null!;

    public Guid BusinessId { get; private set; }

    public Business Business { get; private set; } = null!;

    public string JobTitle { get; private set; } = string.Empty;

    public bool IsAvailableForAppointments { get; private set; }

    public DateTime CreatedAtUtc { get; private set; }

    private StaffProfile()
    {
    }

    public StaffProfile(
        Guid userId,
        Guid businessId,
        string jobTitle)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        BusinessId = businessId;
        JobTitle = jobTitle;
        IsAvailableForAppointments = true;
        CreatedAtUtc = DateTime.UtcNow;
    }

    public void UpdateJobTitle(string jobTitle)
    {
        JobTitle = jobTitle;
    }

    public void EnableAppointments()
    {
        IsAvailableForAppointments = true;
    }

    public void DisableAppointments()
    {
        IsAvailableForAppointments = false;
    }
}