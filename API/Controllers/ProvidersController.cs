using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProvidersController : ControllerBase
  {
    private readonly DataContext _context;
    public ProvidersController(DataContext context)
    {
      this._context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<BloodProvider>>> GetProviders()
    {
      return await _context.BloodProviders.ToListAsync();
    }

    [HttpGet("{id}")] //api/products/3
    public async Task<ActionResult<BloodProvider>> GetSingleProvider(int id)
    {
      return await _context.BloodProviders.FindAsync(id);
    }

  }
}