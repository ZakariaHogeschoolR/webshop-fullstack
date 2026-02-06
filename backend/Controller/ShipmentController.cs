using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;
using System.Security.Authentication;

[ApiController]
[Route("api/[controller]")]
public class ShipmentController: ControllerBase
{
    protected readonly ShipmentService _shipmentService;
    protected ShipmentController(ShipmentService shipmentService)
    {
        _shipmentService = shipmentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _shipmentService.GetAllService());
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
            var product = await _shipmentService.GetByIdService(id);
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
    public async Task<IActionResult> Create(ShipmentCreateDto dto)
    {
        try
        {
            await _shipmentService.CreateService(dto);
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
    public async Task<IActionResult> Update(int id, ShipmentUpdateDto dto)
    {
        try
        {
            await _shipmentService.UpdateService(id, dto);
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
            await _shipmentService.DeleteService(id);
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