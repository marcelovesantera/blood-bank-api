using System;

namespace BloodBank.API.Models;

public class CreateDonationInputModel
{
    public int DonorId { get; set; }
    public DateTime DonatetAt { get; set; }
    public int QuantityInMilliliters  { get; set; }
}
