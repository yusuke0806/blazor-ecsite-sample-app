using System;
using System.Net.Http.Json;
using BlazorECSiteSample.Shared.Entities;

namespace BlazorECSiteSample.Client.Services;
public interface IUserService
{
    ValueTask<ShopUser> GetMeAsync();
    ValueTask PutAsync(ShopUser user);
}

public class UserService : IUserService
{
    private readonly HttpClient _httpClient;
    
    public UserService(HttpClient httpClient)
        => _httpClient = httpClient;
    
    public async ValueTask<ShopUser> GetMeAsync()
    {
        var response = await _httpClient.GetAsync("api/user/me");

        return await response.Content.ReadFromJsonAsync<ShopUser>();
    }
    
    public async ValueTask PutAsync(ShopUser user)
    {
        await _httpClient.PutAsJsonAsync($"api/user", user);
    }

}