using Microsoft.AspNetCore.Mvc;
using Temples.Data.Models;
using Temples.Repositories;
using System.Collections.Generic;

namespace Temples.Controllers;

[ApiController]
[Route("temples")]
public class TemplesController : ControllerBase
{
    private readonly ITempleRepository _templeRepository;
    
    public TemplesController(ITempleRepository templeRepository)
    {
        _templeRepository = templeRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllTemples()
    {
        try
        {
            var temples = await _templeRepository.FindAll();
            return Ok(temples);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTempleById(Guid id)
    {   
        if (id == Guid.Empty)
        {
            return BadRequest("Invalid temple id");
        }
        try
        {
            var temple = await _templeRepository.FindById(id);
            return Ok(temple);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateTemple([FromBody] Temple temple)
    {
        try
        {
            var newTempleId = await _templeRepository.Create(temple);
            return Ok(newTempleId);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateTemple([FromBody] Temple temple)
    {
        try
        {
            var isUpdated = await _templeRepository.Update(temple);
            return Ok(isUpdated);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTemple(Guid id)
    {
        if (id == Guid.Empty)
        {
            return BadRequest("Invalid temple id");
        }
        try
        {
            var isDeleted = await _templeRepository.DeleteById(id);
            return Ok(isDeleted);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
}