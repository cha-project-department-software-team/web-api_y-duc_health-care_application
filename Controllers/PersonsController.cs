using HealthCareApplication.Domains.Models;
using HealthCareApplication.Domains.Services;
using HealthCareApplication.Resource.Persons;
using MesMicroservice.Api.Application.Messages;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace HealthCareApplication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonsController : Controller
{
    private readonly IPersonService _personService;

    public PersonsController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpPost]
    public async Task<IActionResult> CreatePerson([FromBody] CreatePersonViewModel person)
    {
        try
        {
            var result = await _personService.CreatePerson(person);
            return Ok(result);
        }
        catch (Exception ex)
        {
            var errorMessage = new ErrorMessage(ex);
            return BadRequest(errorMessage);
        }
    }

    [HttpPut]
    [Route("{personId}")]
    public async Task<IActionResult> UpdatePerson([FromRoute] string personId, [FromBody] UpdatePersonViewModel person)
    {
        try
        {
            var result = await _personService.UpdatePerson(personId, person);
            return Ok(result);
        }
        catch (Exception ex)
        {
            var errorMessage = new ErrorMessage(ex);
            return BadRequest(errorMessage);
        }
    }

    [HttpGet]
    [Route("{personId}")]
    public async Task<PersonViewModel> GetPerson([FromRoute]string personId)
    {
        return await _personService.GetPerson(personId);
    }

    [HttpDelete]
    [Route("{personId}")]
    public async Task<IActionResult> DeletePerson([FromRoute] string personId)
    {
        try
        {
            var result = await _personService.DeletePerson(personId);
            return Ok(result);
        }
        catch (Exception ex)
        {
            var errorMessage = new ErrorMessage(ex);
            return BadRequest(errorMessage);
        }
    }
}
