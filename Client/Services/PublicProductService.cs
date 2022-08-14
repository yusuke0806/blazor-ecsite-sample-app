using System;
using System.Net.Http.Json;
using BlazorECSiteSample.Client.Util;
using BlazorECSiteSample.Shared.Entities;

namespace BlazorECSiteSample.Client.Services
{
    public interface IPublicProductService
    {
        ValueTask<List<Product>> GetAllAsync();
    }

    public class PublicProductService : IPublicProductService
    {
        private readonly HttpClient httpClient;

        public PublicProductService(PublicHttpClient publicHttpClient)
        {
            httpClient = publicHttpClient.httpClient;
        }

        public async ValueTask<List<Product>> GetAllAsync()
        {
            var response = await httpClient.GetAsync("api/product");
            return await response.Content.ReadFromJsonAsync<List<Product>>();
        }
    }
}
