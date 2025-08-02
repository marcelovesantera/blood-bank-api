namespace BloodBank.Domain.Entities
{
    public class Donation : BaseEntity
    {
        protected Donation() { }

        public Donation(int donorId, DateTime donationDate, int volumeInMilliliters)
        {
            if (donorId <= 0)
                throw new ArgumentException("DonorId must be greater than zero.", nameof(donorId));

            if (donationDate > DateTime.Now)
                throw new ArgumentException("Donation date cannot be in the future.", nameof(donationDate));

            if (volumeInMilliliters < 420 || volumeInMilliliters > 470)
                throw new ArgumentException("Volume must be between 420ml and 470ml.", nameof(volumeInMilliliters));

            DonorId = donorId;
            DonationDate = donationDate;
            VolumeInMilliliters = volumeInMilliliters;
        }

        public DateTime DonationDate { get; private set; }
        public int VolumeInMilliliters { get; private set; }
        public int DonorId { get; private set; }
        public Donor Donor { get; private set; }


        public void UpdateVolume(int newVolume)
        {
            if (newVolume < 420 || newVolume > 470)
                throw new ArgumentException("Volume must be between 420ml and 470ml.", nameof(newVolume));

            VolumeInMilliliters = newVolume;
            Update();
        }
    }
}
