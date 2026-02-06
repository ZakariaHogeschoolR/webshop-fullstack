using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;
using System.Security.Authentication;

[ApiController]
[Route("api/[controller]")]
public class OrderController: ControllerBase
{
    protected readonly OrderService _orderService;
    protected OrderController(OrderService OrderService)
    {
        _orderService = OrderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _orderService.GetAllService());
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
            var Order = await _orderService.GetByIdService(id);
            return Order is null ? NotFound() : Ok(Order);
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
    public async Task<IActionResult> Create(OrderCreateDto dto)
    {
        try
        {
            await _orderService.CreateService(dto);
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
    public async Task<IActionResult> Update(int id, OrderUpdateDto dto)
    {
        try
        {
            await _orderService.UpdateService(id, dto);
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
            await _orderService.DeleteService(id);
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