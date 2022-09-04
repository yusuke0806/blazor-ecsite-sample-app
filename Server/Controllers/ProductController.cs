using System;
using System.Net.Mime;
using BlazorECSiteSample.Server.Services;
using BlazorECSiteSample.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorECSiteSample.Server.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet("{id:int}")]
		[Produces(MediaTypeNames.Application.Json)]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async ValueTask<ActionResult<Product>> Get(int id)
		{
			var product = await _productService.FindAsync(id);
			if (product is null)
				return NotFound("商品が見つかりませんでした。");
			
			return Ok(product);
		}

        [HttpGet]
		public async ValueTask<ActionResult<List<Product>>> GetAll()
        {
			return Ok(await _productService.GetAllAsync());
        }
	}
}

