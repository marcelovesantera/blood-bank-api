namespace BloodBank.Domain.Entities
{
    public class Donation : BaseEntity
    {
        public DateTime DonationDate { get; private set; }
        public int VolumeInMilliliters { get; private set; }
        public int DonorId { get; private set; }
        public Donor Donor { get; private set; }
    }
}
