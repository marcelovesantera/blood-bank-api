using System;

namespace BloodBank.API.Models;

public class UpdateDonationInputModel
{
    public DateTime DonatetAt { get; set; }
    public int QuantityInMilliliters  { get; set; }
}
