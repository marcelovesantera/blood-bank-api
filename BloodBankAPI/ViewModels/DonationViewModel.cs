namespace BloodBankAPI.ViewModels
{
    public class DonationViewModel
    {
        public DonationViewModel(Guid id, DateTime donationDate, int volumeInMilliliters)
        {
            Id = id;
            DonationDate = donationDate;
            VolumeInMilliliters = volumeInMilliliters;
        }

        public Guid Id { get; private set; }
        public DateTime DonationDate { get; private set; }
        public int VolumeInMilliliters { get; private set; }
    }
}
