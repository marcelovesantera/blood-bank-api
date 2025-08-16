namespace BloodBankAPI.ViewModels
{
    public class DonationDetailsViewModel
    {
        public DonationDetailsViewModel(
            Guid id,
            DateTime donationDate,
            int volumeInMilliliters,
            int donorId,
            DonorViewModel donor)
        {
            Id = id;
            DonationDate = donationDate;
            VolumeInMilliliters = volumeInMilliliters;
            DonorId = donorId;
            Donor = donor;
        }

        public Guid Id { get; private set; }
        public DateTime DonationDate { get; private set; }
        public int VolumeInMilliliters { get; private set; }
        public int DonorId { get; private set; }
        public DonorViewModel Donor { get; private set; }
    }
}
