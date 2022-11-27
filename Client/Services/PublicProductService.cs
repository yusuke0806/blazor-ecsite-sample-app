using System;
using System.Net.Http.Json;
using BlazorECSiteSample.Client.Util;
using BlazorECSiteSample.Shared.Entities;
using BlazorECSiteSample.Client.Extensions;

namespace BlazorECSiteSample.Client.Services;

public interface IPublicProductService
{
    ValueTask<List<Product>> GetAllAsync();
    ValueTask<Product> GetAsync(int id);
}

public class PublicProductService : IPublicProductService
{
    private readonly HttpClient _httpClient;

    public PublicProductService(PublicHttpClient publicHttpClient)
    {
        _httpClient = publicHttpClient.httpClient;
    }

    public async ValueTask<List<Product>> GetAllAsync()
    {
        var response = await _httpClient.GetAsync("api/product");
        await response.HandleError();
        
        return await response.Content.ReadFromJsonAsync<List<Product>>();
    }

    public async ValueTask<Product> GetAsync(int id)
    {
        var response = await _httpClient.GetAsync($"api/Product/{id}");
        await response.HandleError();

        return await response.Content.ReadFromJsonAsync<Product>();
    }
}

