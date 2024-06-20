using CadCliBlazor.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CadCliBlazor.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetALl() => Ok(new List<Cliente>()
    {
        new() {Id = 1, Nome = "Fabiano", Email = "fabiano.nalin@gmail.com", Idade = 45},
        new() {Id = 2, Nome = "Lucas", Email = "lucas@teste.com", Idade = 25}
    }); 
}