using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

[ApiController]
[Route("api/[controller]")]
public class CartItemController: ControllerBase
{
    protected readonly CartItemService _cartItemService;
    protected CartItemController(CartItemService CartItemService)
    {
        _cartItemService = CartItemService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _cartItemService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var CartItem = await _cartItemService.GetByIdService(id);
        return CartItem is null ? NotFound() : Ok(CartItem);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CartItemCreateDto dto)
    {
        await _cartItemService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CartItemUpdateDto dto)
    {
        await _cartItemService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _cartItemService.DeleteService(id);
        return NoContent();
    }


}