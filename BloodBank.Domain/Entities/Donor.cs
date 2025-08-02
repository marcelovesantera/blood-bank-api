namespace BloodBank.Domain.Entities;

public class Donor : BaseEntity
{
    protected Donor()
    {
        Donations = new List<Donation>();
    }

    public Donor(string fullName, string email, DateTime birthDate, string gender, double weight, string bloodType, string rhFactor)
    {
        if (string.IsNullOrWhiteSpace(fullName))
            throw new ArgumentException("Full name is required.", nameof(fullName));

        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            throw new ArgumentException("Valid email is required.", nameof(email));

        if (birthDate > DateTime.Now)
            throw new ArgumentException("Birth date cannot be in the future.", nameof(birthDate));

        if (weight <= 0)
            throw new ArgumentException("Weight must be greater than zero.", nameof(weight));

        if (string.IsNullOrWhiteSpace(bloodType))
            throw new ArgumentException("Blood type is required.", nameof(bloodType));

        if (string.IsNullOrWhiteSpace(rhFactor))
            throw new ArgumentException("RH Factor is required.", nameof(rhFactor));

        FullName = fullName;
        Email = email;
        BirthDate = birthDate;
        Gender = gender;
        Weight = weight;
        BloodType = bloodType;
        RhFactor = rhFactor;

        Donations = new List<Donation>();
    }

    public string FullName { get; private set; }
    public string Email { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string Gender { get; private set; }
    public double Weight { get; private set; }
    public string BloodType { get; private set; }
    public string RhFactor { get; private set; }
    public Address Address { get; private set; }
    public List<Donation> Donations { get; private set; }

    public void UpdateWeight(double weight)
    {
        if (weight <= 0)
            throw new ArgumentException("Weight must be greater than zero.", nameof(weight));

        Weight = weight;
        Update();
    }

    public void SetAddress(Address address)
    {
        Address = address ?? throw new ArgumentNullException(nameof(address));
        Update();
    }
}
