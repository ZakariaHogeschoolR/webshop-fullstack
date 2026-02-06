using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

[ApiController]
[Route("api/[controller]")]
public class CategoryController: ControllerBase
{
    protected readonly CategoryService _categoryService;
    protected CategoryController(CategoryService CategoryService)
    {
        _categoryService = CategoryService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _categoryService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var Category = await _categoryService.GetByIdService(id);
        return Category is null ? NotFound() : Ok(Category);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateDto dto)
    {
        await _categoryService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CategoryUpdateDto dto)
    {
        await _categoryService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _categoryService.DeleteService(id);
        return NoContent();
    }


}