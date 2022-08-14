using System;
using BlazorECSiteSample.Shared.Entities;
using BlazorECSiteSample.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorECSiteSample.Server.Services
{
	public interface IProductService
    {
		ValueTask<List<Product>> GetAllAsync();
	}

	public class ProductService : IProductService
    {
		private readonly DataContext dataContext;

		public ProductService(IDbContextFactory<DataContext> dbContextFactory)
			=> dataContext = dbContextFactory.CreateDbContext();
        

		public async ValueTask<List<Product>> GetAllAsync()
        {
			using (dataContext)
            {
                return await dataContext.Products.ToListAsync();
            }
        }
	}
}

