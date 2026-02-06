using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

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
        => Ok(await _paymentService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var Payment = await _paymentService.GetByIdService(id);
        return Payment is null ? NotFound() : Ok(Payment);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PaymentCreateDto dto)
    {
        await _paymentService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, PaymentUpdateDto dto)
    {
        await _paymentService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _paymentService.DeleteService(id);
        return NoContent();
    }


}