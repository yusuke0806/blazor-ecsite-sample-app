using System;
using Azure.Identity;
using BlazorECSiteSample.Server.Extensions;
using BlazorECSiteSample.Shared.Entities;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Identity.Client;

namespace BlazorECSiteSample.Server.Services;

public interface IUserService
{
    ValueTask<ShopUser> GetAsync(string userId);
    ValueTask<int> PutAsync(ShopUser shopUser, string userId);
}

public class UserService : IUserService
{
    private readonly GraphServiceClient _graphServiceClient;
    
    public UserService(IConfiguration configuration)
    {
        var options = new TokenCredentialOptions
        {
            AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
        };
        var clientSecretCredential = new ClientSecretCredential(
            configuration["AzureAdB2C:TenantId"],
            configuration["AzureAdB2C:ClientId"],
            configuration["AzureAdB2C:ClientSecret"],
            options);
        
        _graphServiceClient = new GraphServiceClient(clientSecretCredential);
    }

    public async ValueTask<ShopUser> GetAsync(string userId)
    {
        var user = await _graphServiceClient.Users[userId].GetAsync();
        return user.ToShopUser();
    }
    
    public async ValueTask<int> PutAsync(ShopUser shopUser, string userId)
    {
        var user = new User
        {
            DisplayName = shopUser.DisplayName,
            MobilePhone = shopUser.MobilePhone
        };

        await _graphServiceClient.Users[userId].PatchAsync(user);
        return StatusCodes.Status204NoContent;
    }
}