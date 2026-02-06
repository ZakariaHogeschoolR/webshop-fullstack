using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

[ApiController]
[Route("api/[controller]")]
public class CartController: ControllerBase
{
    protected readonly CartService _cartService;
    protected CartController(CartService CartService)
    {
        _cartService = CartService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _cartService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var Cart = await _cartService.GetByIdService(id);
        return Cart is null ? NotFound() : Ok(Cart);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CartCreateDto dto)
    {
        await _cartService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CartUpdateDto dto)
    {
        await _cartService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _cartService.DeleteService(id);
        return NoContent();
    }


}