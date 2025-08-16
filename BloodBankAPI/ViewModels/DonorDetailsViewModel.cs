namespace BloodBankAPI.ViewModels
{
    public class DonorDetailsViewModel
    {
        public DonorDetailsViewModel(
            Guid id,
            string fullName,
            string email,
            DateTime birthDate,
            string gender,
            double weight,
            string bloodType,
            string rhFactor,
            AddressViewModel address,
            List<DonationViewModel> donations)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Gender = gender;
            Weight = weight;
            BloodType = bloodType;
            RhFactor = rhFactor;
            Address = address;
            Donations = donations;
        }

        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Gender { get; private set; }
        public double Weight { get; private set; }
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public AddressViewModel Address { get; private set; }
        public List<DonationViewModel> Donations { get; private set; }
    }
}
