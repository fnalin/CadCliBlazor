using CadCliBlazor.Data;
using CadCliBlazor.Domain.Contracts.Repositories;
using CadCliBlazor.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CadCliBlazor.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController (IClienteRepository repository) : ControllerBase
{
    
    
    [HttpGet]
    public async Task<IActionResult> GetALl() => Ok(await repository.GetAllAsync());

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var cliente = await repository.GetAsync(id);
        
        if (cliente is null)
            return NotFound();
        
        return Ok(await repository.GetAsync(id));
    }
}