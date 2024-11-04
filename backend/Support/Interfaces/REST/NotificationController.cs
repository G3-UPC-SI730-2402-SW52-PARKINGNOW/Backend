using backend.Support.Domain.Model.Queries;
using backend.Support.Domain.Services;
using backend.Support.Interfaces.REST.Resources;
using backend.Support.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace backend.Support.Interfaces.REST;


[ApiController]
[Route("api/[controller]")]
public class NotificationController(
    INotificationCommandService notificationCommandService,
    INotificationQueryService notificationQueryService)
     : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> CreateNotification([FromBody] CreateNotificationResource createNotificationResource)
    {
        var createNotificationCommand =
            CreateNotificationCommandFromResourceAssembler.ToCommandFromResource(createNotificationResource);
        var notification = await notificationCommandService.Handle(createNotificationCommand);
        if (notification is null) return BadRequest();
        var resource = NotificationResourceFromEntityAssembler.ToResourceFromEntity(notification);
        
        return CreatedAtAction(nameof(GetNotificationById), new { notificationId = resource.id }, resource);
    }
    
    [HttpGet("{notificationId}")]
    public async Task<IActionResult> GetNotificationById([FromRoute] int notificationId)
    {
        var notification = await notificationQueryService.Handle(new GetNotificationsByConductorQuery(notificationId));
        if (notification == null) return NotFound();
        var resource = NotificationResourceFromEntityAssembler.ToResourceFromEntity(notification);
        return Ok(resource);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllNotifications()
    {
        var getAllNotificationsQuery = new GetAllNotificationsQuery();
        var notification = await notificationQueryService.Handle(getAllNotificationsQuery);
        var resources = notification.Select(NotificationResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    } 
}