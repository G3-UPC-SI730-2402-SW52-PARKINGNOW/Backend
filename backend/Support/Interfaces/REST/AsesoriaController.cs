using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Services;
using backend.Support.Interfaces.REST.Resources;
using Microsoft.AspNetCore.Mvc;

namespace backend.Support.Interfaces.REST.Transform;

[ApiController]
[Route("api/[controller]")]
public class AsesoriaController(
    IAsesoriaCommandService asesoriaCommandService,
    IAsesoriaQueryService asesoriaQueryService)
     : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAsesoria([FromBody] CreateAsesoriaResource createAsesoriaResource)
    {
        var createAsesoriaCommand =
            CreateAsesoriaCommandFromResourceAssembler.ToCommandFromResource(createAsesoriaResource);
        var asesoria = await asesoriaCommandService.Handle(createAsesoriaCommand);
        if (asesoria is null) return BadRequest();
        var resource = AsesoriaResourceFromEntityAssembler.ToResourceFromEntity(asesoria);
        
        return CreatedAtAction(nameof(GetAsesoriaById), new { asesoriaId = resource.id }, resource);
    }
    
    [HttpGet("{asesoriaId}")]
    public async Task<IActionResult> GetAsesoriaById([FromRoute] int asesoriaId)
    {
        var asesoria = await asesoriaQueryService.Handle(new GetAsesoriaByIdQuery(asesoriaId));
        if (asesoria == null) return NotFound();
        var resource = AsesoriaResourceFromEntityAssembler.ToResourceFromEntity(asesoria);
        return Ok(resource);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsesorias()
    {
        var getAllAsesoriasQuery = new GetAllAsesoriasQuery();
        var asesoria = await asesoriaQueryService.Handle(getAllAsesoriasQuery);
        var resources = asesoria.Select(AsesoriaResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    } 
}