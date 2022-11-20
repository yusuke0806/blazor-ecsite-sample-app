using System;
using BlazorECSiteSample.Shared.Entities;
using BlazorECSiteSample.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorECSiteSample.Server.Services;

public interface IProductService
{
	ValueTask<List<Product?>> GetAllAsync();
	ValueTask<Product?> FindAsync(int id);
}

public class ProductService : IProductService
{
	private readonly DataContext _dataContext;

	public ProductService(IDbContextFactory<DataContext> dbContextFactory)
		=> _dataContext = dbContextFactory.CreateDbContext();
	
	public async ValueTask<List<Product?>> GetAllAsync()
	{
		await using (_dataContext)
		{
			return await _dataContext.Products.ToListAsync();
		}
	}

	public async ValueTask<Product?> FindAsync(int id)
	{
		await using (_dataContext)
		{
			return await _dataContext.Products.FirstOrDefaultAsync(x => x != null && x.Id == id);
		}
	}
}

