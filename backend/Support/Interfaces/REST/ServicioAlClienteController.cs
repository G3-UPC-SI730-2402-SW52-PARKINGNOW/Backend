using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Services;
using backend.Support.Interfaces.REST.Resources;
using backend.Support.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace backend.Support.Interfaces.REST;


[ApiController]
[Route("api/[controller]")]
public class ServicioAlClienteController(
    IServicioAlClienteCommandService servicioAlClienteCommandService,
    IServicioAlClienteQueryService servicioAlClienteQueryService)
     : ControllerBase
{
    //ServicioAlCliente 
    //servicioAlCliente 
    [HttpPost]
    public async Task<IActionResult> CreateServicioAlCliente([FromBody] CreateServicioAlClienteResource createServicioAlClienteResource)
    {
        var createServicioAlClienteCommand =
            CreateServicioAlClienteCommandFromResourceAssembler.ToCommandFromResource(createServicioAlClienteResource);
        var servicioAlCliente = await servicioAlClienteCommandService.Handle(createServicioAlClienteCommand);
        if (servicioAlCliente is null) return BadRequest();
        var resource = ServicioAlClienteResourceFromEntityAssembler.ToResourceFromEntity(servicioAlCliente);
        
        return CreatedAtAction(nameof(GetServicioAlClienteById), new { servicioAlClienteId = resource.id }, resource);
    }
    
    [HttpGet("{servicioAlClienteId}")]
    public async Task<IActionResult> GetServicioAlClienteById([FromRoute] int servicioAlClienteId)
    {
        var servicioAlCliente = await servicioAlClienteQueryService.Handle(new GetServicioAlClienteByIdQuery(servicioAlClienteId));
        if (servicioAlCliente == null) return NotFound();
        var resource = ServicioAlClienteResourceFromEntityAssembler.ToResourceFromEntity(servicioAlCliente);
        return Ok(resource);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllServicioAlClientes()
    {
        var getAllServicioAlClientesQuery = new GetAllServicioAlClienteQuery();
        var servicioAlCliente = await servicioAlClienteQueryService.Handle(getAllServicioAlClientesQuery);
        var resources = servicioAlCliente.Select(ServicioAlClienteResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }  
}