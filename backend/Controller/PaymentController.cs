using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;
using System.Security.Authentication;

[ApiController]
[Route("api/[controller]")]
public class PaymentController: ControllerBase
{
    protected readonly PaymentService _paymentService;
    protected PaymentController(PaymentService PaymentService)
    {
        _paymentService = PaymentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            return Ok(await _paymentService.GetAllService());
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
            var Payment = await _paymentService.GetByIdService(id);
            return Payment is null ? NotFound() : Ok(Payment);
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
    public async Task<IActionResult> Create(PaymentCreateDto dto)
    {
        try 
        {
            await _paymentService.CreateService(dto);
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
    public async Task<IActionResult> Update(int id, PaymentUpdateDto dto)
    {
        try
        {
            await _paymentService.UpdateService(id, dto);
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
            await _paymentService.DeleteService(id);
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