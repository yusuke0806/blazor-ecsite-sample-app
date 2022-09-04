using System;
using System.Security.Claims;
using BlazorECSiteSample.Server.Services;
using BlazorECSiteSample.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorECSiteSample.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    
    public UserController(IUserService userService)
        => _userService = userService;
    
    [HttpGet("me")]
    public async ValueTask<ActionResult<ShopUser>> GetMe()
    {
        var userId = GetUserId();
        var shopUser = await _userService.GetAsync(userId);
        return Ok(shopUser);

    }

    [HttpPut]
    public async ValueTask<ActionResult> Put(ShopUser shopUser)
    {
        var userId = GetUserId();
        if (userId != null)
        {
            await _userService.PutAsync(shopUser,userId);   
        }
        return NoContent();
    }
    
    private string? GetUserId()
        => User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
}