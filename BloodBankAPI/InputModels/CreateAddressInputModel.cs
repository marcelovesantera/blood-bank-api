using BloodBank.Domain.Entities;

namespace BloodBankAPI.InputModels
{
    public class CreateAddressInputModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int DonorId { get; set; }
    }
}
