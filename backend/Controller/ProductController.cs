using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

[ApiController]
[Route("api/[controller]")]
public class ProductController: ControllerBase
{
    protected readonly ProductService _productService;
    protected ProductController(ProductService ProductService)
    {
        _productService = ProductService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _productService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _productService.GetByIdService(id);
        return product is null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductCreateDto dto)
    {
        await _productService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, ProductUpdateDto dto)
    {
        await _productService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _productService.DeleteService(id);
        return NoContent();
    }


}