namespace BloodBank.Domain.Entities
{
    public class BloodStock : BaseEntity
    {
        protected BloodStock() { }

        public BloodStock(string bloodType, string rhFactor, int volumeInMilliliters)
        {
            BloodType = bloodType;
            RhFactor = rhFactor;
            VolumeInMilliliters = volumeInMilliliters;
        }


        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public int VolumeInMilliliters { get; private set; }
    }
}
