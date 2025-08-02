namespace BloodBank.Domain.Entities
{
    public class Address : BaseEntity
    {
        protected Address() { }

        public Address(string street, string city, string state, string zipCode, int donorId)
        {
            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Street is required.", nameof(street));

            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required.", nameof(city));

            if (string.IsNullOrWhiteSpace(state))
                throw new ArgumentException("State is required.", nameof(state));

            if (string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("Zip code is required.", nameof(zipCode));

            if (donorId <= 0)
                throw new ArgumentException("DonorId must be greater than zero.", nameof(donorId));

            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            DonorId = donorId;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public int DonorId { get; private set; }
        public Donor Donor { get; private set; }


        public void UpdateAddress(string street, string city, string state, string zipCode)
        {
            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Street is required.", nameof(street));

            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required.", nameof(city));

            if (string.IsNullOrWhiteSpace(state))
                throw new ArgumentException("State is required.", nameof(state));

            if (string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("Zip code is required.", nameof(zipCode));

            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
            Update();
        }
    }
}
