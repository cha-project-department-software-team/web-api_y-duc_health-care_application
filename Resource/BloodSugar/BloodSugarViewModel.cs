﻿namespace HealthCareApplication.Resource.BloodSugar;

public class BloodSugarViewModel
{
    public decimal Value { get; set; }
    public string ImageLink { get; set; }
    public DateTime Timestamp { get; set; }

    public BloodSugarViewModel(decimal value, string imageLink, DateTime timestamp)
    {
        Value = value;
        ImageLink = imageLink;
        Timestamp = timestamp;
    }
}
