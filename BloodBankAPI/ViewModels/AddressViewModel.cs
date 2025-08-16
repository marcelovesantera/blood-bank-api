namespace BloodBankAPI.ViewModels
{
    public class AddressViewModel
    {
        public AddressViewModel(Guid id, string street, string city, string state, string zipCode)
        {
            Id = id;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public Guid Id { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
    }
}
