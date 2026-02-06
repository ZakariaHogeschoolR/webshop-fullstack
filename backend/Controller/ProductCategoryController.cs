using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

[ApiController]
[Route("api/[controller]")]
public class ProductCategoryController: ControllerBase
{
    protected readonly ProductCategoryService _productCategoryService;
    protected ProductCategoryController(ProductCategoryService ProductCategoryService)
    {
        _productCategoryService = ProductCategoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _productCategoryService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var productCategory = await _productCategoryService.GetByIdService(id);
        return productCategory is null ? NotFound() : Ok(productCategory);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductCategoryCreateDto dto)
    {
        await _productCategoryService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, ProductCategoryUpdateDto dto)
    {
        await _productCategoryService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _productCategoryService.DeleteService(id);
        return NoContent();
    }


}