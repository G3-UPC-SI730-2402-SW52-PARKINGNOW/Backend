using backend.User.Domain.Model.Queries;
using backend.User.Domain.Services;
using backend.User.Interfaces.REST.Resources;
using backend.User.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace backend.User.Interfaces.REST;

[ApiController]
[Route("api/[controller]")]
public class DuenoDePlayasController(
    IDuenoDePlayasCommandService duenoDePlayasCommandService,
    IDuenoDePlayasQueryService duenoDePlayasQueryService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateDuenoDePlayas([FromBody] CreateDuenoDePlayasResource createDuenoDePlayasResource)
    {
        var createDuenoDePlayasCommand =
            CreateDuenoDePlayasCommandFromResourceAssembler.ToCommandFromResource(createDuenoDePlayasResource);
        var duenoDePlayas = await duenoDePlayasCommandService.Handle(createDuenoDePlayasCommand);
        if (duenoDePlayas is null) return BadRequest();
        var resource = DuenoDePlayasResourceFromEntityAssembler.ToResourceFromEntity(duenoDePlayas);
        
        return CreatedAtAction(nameof(GetDuenoDePlayasByRUC), new { duenoDePlayasRUC = resource.RUC }, resource);
    }
    
    [HttpGet("{duenoDePlayasId}")]
    public async Task<IActionResult> GetDuenoDePlayasByRUC([FromRoute] string duenoDePlayasRUC)
    {
        var duenoDePlayas = await duenoDePlayasQueryService.Handle(new GetDuenoDePlayasByRUCQuery(duenoDePlayasRUC));
        if (duenoDePlayas == null) return NotFound();
        var resource = DuenoDePlayasResourceFromEntityAssembler.ToResourceFromEntity(duenoDePlayas);
        return Ok(resource);
    }
}