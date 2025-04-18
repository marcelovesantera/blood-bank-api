using System;

namespace BloodBank.API.Models;

public class UpdateDonorInputModel
{
    public int Id { get; set; }
    public string Fullname { get; set;} = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public double Weight { get; set; }
}
