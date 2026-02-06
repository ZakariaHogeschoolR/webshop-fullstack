using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;
using System.Security.Authentication;

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
    {
        try
        {
            return Ok(await _categoryService.GetAllService());
        }
        catch(AuthenticationException AE)
        {
            return Unauthorized(AE.Message);
        }
        catch(UnauthorizedAccessException UAE)
        {
            return Forbid(UAE.Message);
        }
        catch(ArgumentException AE)
        {
            return BadRequest(AE.Message);
        }
        catch(KeyNotFoundException KNFE)
        {
            return NotFound(KNFE.Message);
        }
        catch(Exception E)
        {
            return StatusCode(500, E.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var Category = await _categoryService.GetByIdService(id);
            return Category is null ? NotFound() : Ok(Category);
        }
        catch(AuthenticationException AE)
        {
            return Unauthorized(AE.Message);
        }
        catch(UnauthorizedAccessException UAE)
        {
            return Forbid(UAE.Message);
        }
        catch(ArgumentException AE)
        {
            return BadRequest(AE.Message);
        }
        catch(KeyNotFoundException KNFE)
        {
            return NotFound(KNFE.Message);
        }
        catch(Exception E)
        {
            return StatusCode(500, E.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateDto dto)
    {
        try
        {
            await _categoryService.CreateService(dto);
            return Ok();
        }
        catch(AuthenticationException AE)
        {
            return Unauthorized(AE.Message);
        }
        catch(UnauthorizedAccessException UAE)
        {
            return Forbid(UAE.Message);
        }
        catch(ArgumentException AE)
        {
            return BadRequest(AE.Message);
        }
        catch(KeyNotFoundException KNFE)
        {
            return NotFound(KNFE.Message);
        }
        catch(Exception E)
        {
            return StatusCode(500, E.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CategoryUpdateDto dto)
    {
        try
        {
            await _categoryService.UpdateService(id, dto);
            return Ok();
        }
        catch(AuthenticationException AE)
        {
            return Unauthorized(AE.Message);
        }
        catch(UnauthorizedAccessException UAE)
        {
            return Forbid(UAE.Message);
        }
        catch(ArgumentException AE)
        {
            return BadRequest(AE.Message);
        }
        catch(KeyNotFoundException KNFE)
        {
            return NotFound(KNFE.Message);
        }
        catch(Exception E)
        {
            return StatusCode(500, E.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _categoryService.DeleteService(id);
            return NoContent();
        }
        catch(AuthenticationException AE)
        {
            return Unauthorized(AE.Message);
        }
        catch(UnauthorizedAccessException UAE)
        {
            return Forbid(UAE.Message);
        }
        catch(ArgumentException AE)
        {
            return BadRequest(AE.Message);
        }
        catch(KeyNotFoundException KNFE)
        {
            return NotFound(KNFE.Message);
        }
        catch(Exception E)
        {
            return StatusCode(500, E.Message);
        }
    }
}