using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

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
        => Ok(await _orderService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var Order = await _orderService.GetByIdService(id);
        return Order is null ? NotFound() : Ok(Order);
    }

    [HttpPost]
    public async Task<IActionResult> Create(OrderCreateDto dto)
    {
        await _orderService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, OrderUpdateDto dto)
    {
        await _orderService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _orderService.DeleteService(id);
        return NoContent();
    }


}