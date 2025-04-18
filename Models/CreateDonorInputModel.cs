using System;

namespace BloodBank.API.Models;

public class CreateDonorInputModel
{
    public string Fullname { get; set;} = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; } = string.Empty;
    public double Weight { get; set; }
    public string BloodType { get; set; } = string.Empty;
    public string RhFactor { get; set; } = string.Empty;
}
