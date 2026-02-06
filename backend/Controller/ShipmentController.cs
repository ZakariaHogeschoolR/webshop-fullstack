using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Webshop.Models;
using Webshop.Services;
using Webshop.DataTransferObject;

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
        => Ok(await _shipmentService.GetAllService());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _shipmentService.GetByIdService(id);
        return product is null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ShipmentCreateDto dto)
    {
        await _shipmentService.CreateService(dto);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, ShipmentUpdateDto dto)
    {
        await _shipmentService.UpdateService(id, dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _shipmentService.DeleteService(id);
        return NoContent();
    }


}