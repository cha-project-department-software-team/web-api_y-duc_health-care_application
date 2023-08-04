using AutoMapper;
using HealthCareApplication.Domains.Models;
using HealthCareApplication.Resource.Addresses;
using HealthCareApplication.Resource.Persons;

namespace HealthCareApplication.Mapping;

public class ModelToViewModelProfile : Profile
{
    public ModelToViewModelProfile() 
    {
        CreateMap<Person, PersonViewModel>();

        CreateMap<Address, AddressViewModel>();
    }
}
