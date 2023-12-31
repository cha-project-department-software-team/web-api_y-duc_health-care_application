﻿namespace HealthCareApplication.Domains.Models;

public class BloodPressure
{
    public string BloodPressureId { get; private set; }
    public int Systolic { get; private set; }
    public int Diastolic { get; private set; }
    public int PulseRate { get; private set; }
    public string ImageLink { get; private set; }
    public DateTime Timestamp { get; private set; }
    public Person Person { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private BloodPressure() { }

    public BloodPressure(int systolic, int diastolic, int pulseRate, string imageLink, DateTime timestamp, Person person)
    {
        Systolic = systolic;
        Diastolic = diastolic;
        PulseRate = pulseRate;
        ImageLink = imageLink;
        Timestamp = timestamp;
        Person = person;
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
