using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoUrgencia.Data;
using ProjetoUrgencia.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ChamadosController : ControllerBase
{
    private readonly AppDbContext _context;
    public ChamadosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Chamado>>> Get()
    {
        return await _context.Chamados.Include(c => c.Usuario).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult> Post(Chamado chamado)
    {
        _context.Chamados.Add(chamado);
        await _context.SaveChangesAsync();
        return Ok(chamado);
    }
}
