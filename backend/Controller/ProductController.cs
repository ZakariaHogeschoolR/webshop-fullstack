using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;
using System.Security.Authentication;

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
    {
        try
        {
            return Ok(await _productService.GetAllService());
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
            var product = await _productService.GetByIdService(id);
            return product is null ? NotFound() : Ok(product);
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
    public async Task<IActionResult> Create(ProductCreateDto dto)
    {
        try
        {
            await _productService.CreateService(dto);
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
    public async Task<IActionResult> Update(int id, ProductUpdateDto dto)
    {
        try
        {
            await _productService.UpdateService(id, dto);
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
            await _productService.DeleteService(id);
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