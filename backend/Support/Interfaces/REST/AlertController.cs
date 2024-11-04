using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Services;
using backend.Support.Interfaces.REST.Resources;
using backend.Support.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace backend.Support.Interfaces.REST;

[ApiController]
[Route("api/[controller]")]
public class AlertController(
    IAlertsCommandService alertCommandService,
    IAlertsQueryService alertQueryService)
     : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateAlert([FromBody] CreateAlertResource createAlertResource)
    {
        var createAlertCommand =
            CreateAlertCommandFromResourceAssembler.ToCommandFromResource(createAlertResource);
        var alert = await alertCommandService.Handle(createAlertCommand);
        if (alert is null) return BadRequest();
        var resource = AlertResourceFromEntityAssembler.ToResourceFromEntity(alert);
        
        return CreatedAtAction(nameof(GetAlertById), new { alertId = resource.id }, resource);
    }
    
    [HttpGet("{alertId}")]
    public async Task<IActionResult> GetAlertById([FromRoute] int alertId)
    {
        var alert = await alertQueryService.Handle(new GetAlertByIdQuery(alertId));
        if (alert == null) return NotFound();
        var resource = AlertResourceFromEntityAssembler.ToResourceFromEntity(alert);
        return Ok(resource);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAlerts()
    {
        var getAllAlertsQuery = new GetAllAlertsQuery();
        var alerts = await alertQueryService.Handle(getAllAlertsQuery);
        var resources = alerts.Select(AlertResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }
    
    [HttpPut("{alertId}")]
    public async Task<IActionResult> UpdateAlert([FromRoute] int alertId, [FromBody] AlertResource updateAlertResource)
    {
        var updateAlertCommand = UpdateAlertCommandFromResourceAssembler.ToCommandFromResource(updateAlertResource);
        var alert = await alertCommandService.Handle(updateAlertCommand);
        if (alert == null) return NotFound();
        var resource = AlertResourceFromEntityAssembler.ToResourceFromEntity(alert);
        return Ok(resource);
    }
}
