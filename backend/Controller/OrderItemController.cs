using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

[ApiController]
[Route("api/[controller]")]
public class OrderItemController: ControllerBase
{
    protected readonly OrderItemService _orderItemService;
    protected OrderItemController(OrderItemService OrderItemService)
    {
        _orderItemService = OrderItemService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _orderItemService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var OrderItem = await _orderItemService.GetByIdService(id);
        return OrderItem is null ? NotFound() : Ok(OrderItem);
    }

    [HttpPost]
    public async Task<IActionResult> Create(OrderItemCreateDto dto)
    {
        await _orderItemService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, OrderItemUpdateDto dto)
    {
        await _orderItemService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _orderItemService.DeleteService(id);
        return NoContent();
    }


}