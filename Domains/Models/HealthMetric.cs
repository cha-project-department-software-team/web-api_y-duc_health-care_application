namespace HealthCareApplication.Domains.Models;

public class HealthMetric
{
    public string HealthMetricId { get; private set; }
    public int SystolicBloodPressure { get; private set; }
    public int DiastolicBloodPressure { get; private set; }
    public int PulseRate { get; private set; }
    public decimal BloodSugar { get; private set; }
    public decimal BodyTemperature { get; private set; }
    public TimeSpan Timestamp { get; private set; }
    public Person Person { get; private set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private HealthMetric() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public HealthMetric(string healthMetricId, int systolicBloodPressure, int diastolicBloodPressure, int pulseRate, decimal bloodSugar, decimal bodyTemperature, TimeSpan timestamp, Person person)
    {
        HealthMetricId = healthMetricId;
        SystolicBloodPressure = systolicBloodPressure;
        DiastolicBloodPressure = diastolicBloodPressure;
        PulseRate = pulseRate;
        BloodSugar = bloodSugar;
        BodyTemperature = bodyTemperature;
        Timestamp = timestamp;
        Person = person;
    }
}
