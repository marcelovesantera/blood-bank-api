namespace BloodBank.Domain.Entities
{
    public class BloodStock : BaseEntity
    {
        protected BloodStock() { }

        public BloodStock(string bloodType, string rhFactor, int volumeInMilliliters)
        {
            if (string.IsNullOrWhiteSpace(bloodType))
                throw new ArgumentException("Blood type is required.", nameof(bloodType));

            if (rhFactor != "+" && rhFactor != "-")
                throw new ArgumentException("RhFactor must be '+' or '-'.", nameof(rhFactor));

            if (volumeInMilliliters < 0)
                throw new ArgumentException("Volume cannot be negative.", nameof(volumeInMilliliters));

            BloodType = bloodType.ToUpperInvariant();
            RhFactor = rhFactor;
            VolumeInMilliliters = volumeInMilliliters;
        }

        public string BloodType { get; private set; }
        public string RhFactor { get; private set; }
        public int VolumeInMilliliters { get; private set; }

        public void AddVolume(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than zero.", nameof(amount));

            VolumeInMilliliters += amount;
            Update();
        }

        public void RemoveVolume(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than zero.", nameof(amount));

            if (VolumeInMilliliters - amount < 0)
                throw new InvalidOperationException("Insufficient blood stock.");

            VolumeInMilliliters -= amount;
            Update();
        }
    }
}
