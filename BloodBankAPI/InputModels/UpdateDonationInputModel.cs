namespace BloodBankAPI.InputModels
{
    public class UpdateDonationInputModel
    {
        public int Id { get; private set; }
        public DateTime DonationDate { get; private set; }
        public int VolumeInMilliliters { get; private set; }
    }
}
