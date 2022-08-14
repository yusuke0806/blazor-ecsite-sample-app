using System;
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

        [HttpGet]
		public async ValueTask<ActionResult<List<Product>>> GetAll()
        {
			return Ok(await _productService.GetAllAsync());
        }
	}
}

