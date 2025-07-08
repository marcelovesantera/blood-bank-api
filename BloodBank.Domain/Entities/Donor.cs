namespace BloodBank.Domain.Entities;

public class Donor : BaseEntity
{
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Gender { get; private set; }
    public double Weight { get; private set; }
    public string BloodType { get; private set; }
    public string RhFactor { get; private set; }
    public Address Address { get; private set; }
    public List<Donation> Donations { get; private set; }
}
