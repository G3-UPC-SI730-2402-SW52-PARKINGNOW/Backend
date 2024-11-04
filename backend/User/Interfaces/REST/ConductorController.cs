using backend.User.Domain.Model.Queries;
using backend.User.Domain.Services;
using backend.User.Interfaces.REST.Resources;
using Microsoft.AspNetCore.Mvc;

namespace backend.User.Interfaces.REST.Transform;

[ApiController]
[Route("api/[controller]")]
public class ConductorController(
    IConductorCommandService conductorCommandService,
    IConductorQueryService conductorQueryService)
     : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateConductor([FromBody] CreateConductorResource createConductorResource)
    {
        var createConductorCommand =
            CreateConductorCommandFromResourceAssembler.ToCommandFromResource(createConductorResource);
        var conductor = await conductorCommandService.Handle(createConductorCommand);
        if (conductor is null) return BadRequest();
        var resource = ConductorResourceFromEntityAssembler.ToResourceFromEntity(conductor);
        
        return CreatedAtAction(nameof(GetConductorByPlaca), new { conductorPlaca = resource.Placa }, resource);
    }
    
    [HttpGet("{conductorPlacaId}")]
    public async Task<IActionResult> GetConductorByPlaca([FromRoute] string conductorPlaca)
    {
        var conductor = await conductorQueryService.Handle(new GetConductorByPlacaQuery(conductorPlaca));
        if (conductor == null) return NotFound();
        var resource = ConductorResourceFromEntityAssembler.ToResourceFromEntity(conductor);
        return Ok(resource);
    }
}