namespace BloodBankAPI.ViewModels
{
    public class DonorViewModel
    {
        public DonorViewModel(
            Guid id,
            string fullName,
            DateTime birthDate,
            string gender,
            double weight,
            string bloodType,
            string rhFactor)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
            Weight = weight;
            BloodType = bloodType;
            RhFactor = rhFactor;
        }

        public Guid Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Gender { get; private set; }
        public double Weight { get; private set; }
        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
    }
}
