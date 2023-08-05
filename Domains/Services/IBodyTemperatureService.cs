using HealthCareApplication.Domains.Models.Queries;
using HealthCareApplication.Resource.BodyTemperature;

namespace HealthCareApplication.Domains.Services;

public interface IBodyTemperatureService
{
    public Task<List<BodyTemperatureViewModel>> GetBodyTemperatures(string personId, TimeQuery timeQuery);
    public Task<bool> CreateBodyTemperature(string personId, CreateBodyTemperatureViewModel viewModel);
}
