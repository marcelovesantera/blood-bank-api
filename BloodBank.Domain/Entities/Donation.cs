namespace BloodBank.Domain.Entities
{
    public class Donation : BaseEntity
    {
        protected Donation() { }
        public Donation(int donorId, DateTime donationDate, int volumeInMilliliters)
        {
            DonorId = donorId;
            DonationDate = donationDate;
            VolumeInMilliliters = volumeInMilliliters;
        }

        public int DonorId { get; private set; }
        public DateTime DonationDate { get; private set; }
        public int VolumeInMilliliters { get; private set; }
        public Donor Donor { get; private set; }
    }
}
