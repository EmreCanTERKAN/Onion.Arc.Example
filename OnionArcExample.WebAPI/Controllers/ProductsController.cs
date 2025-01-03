using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Domain.Entities;
using OnionArcExample.Infrastructure.Interfaces.Services;

namespace OnionArcExample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IProductRepository _productRepository;
        readonly IEmailService _emailService;

        public ProductsController(IProductRepository productRepository, IEmailService emailService)
        {
            _productRepository = productRepository;
            _emailService = emailService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> allProducts = await _productRepository.GetAsync();
            return Ok(allProducts);
        }

        [HttpGet("sendemail")]
        public IActionResult SendEmail()
        {
            bool result = _emailService.Send("emrecanterkan06@gmail.com","Çıldırırsın..");
            return Ok(result);
        }
    }
}
