using backend.User.Domain.Model.Queries;
using backend.User.Domain.Services;
using backend.User.Interfaces.REST.Resources;
using backend.User.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace backend.User.Interfaces.REST;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController(
    IUsuarioCommandService usuarioCommandService,
    IUsuarioQueryService usuarioQueryService)
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateUsuario([FromBody] CreateUsuarioResource createUsuarioResource)
    {
        var createUsuarioCommand =
            CreateUsuarioCommandFromResourceAssembler.ToCommandFromResource(createUsuarioResource);
        var usuario = await usuarioCommandService.Handle(createUsuarioCommand);
        if (usuario is null) return BadRequest();
        var resource = UsuarioResourceFromEntityAssembler.ToResourceFromEntity(usuario);
        
        return CreatedAtAction(nameof(GetUsuarioById), nameof(GetUsuarioByDNI), new { usuarioId = resource.Id, usuarioDni = resource.DNI }, resource);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllUsuarios()
    {
        var getAllUsuariosQuery = new GetAllUsuariosQuery();
        var usuarios = await usuarioQueryService.Handle(getAllUsuariosQuery);
        var resources = usuarios.Select(UsuarioResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    
    [HttpGet("{usuarioId}")]
    public async Task<IActionResult> GetUsuarioById([FromRoute] int usuarioId)
    {
        var usuario = await usuarioQueryService.Handle(new GetUsuarioByIdQuery(usuarioId));
        if (usuario == null) return NotFound();
        var resource = UsuarioResourceFromEntityAssembler.ToResourceFromEntity(usuario);
        return Ok(resource);
    }
    
    [HttpPut("{usuarioDni}")]
    public async Task<IActionResult> GetUsuarioByDNI([FromRoute] string usuarioDni)
    {
        var usuario = await usuarioQueryService.Handle(new GetUsuarioByDNIQuery(usuarioDni));
        if (usuario == null) return NotFound();
        var resource = UsuarioResourceFromEntityAssembler.ToResourceFromEntity(usuario);
        return Ok(resource);
    }
}