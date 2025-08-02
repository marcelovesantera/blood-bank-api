using BloodBank.Domain.Entities;

namespace BloodBankAPI.InputModels
{
    public class CreateDonationInputModel
    {
        public DateTime DonationDate { get; private set; }
        public int VolumeInMilliliters { get; private set; }
        public int DonorId { get; private set; }
    }
}
