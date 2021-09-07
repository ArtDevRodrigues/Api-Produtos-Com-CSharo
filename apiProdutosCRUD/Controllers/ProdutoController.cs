using System.Data.Common;
using System.Net;
using System.Threading.Tasks;
using apiProdutosCRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiProdutosCRUD.Models;

namespace apiProdutosCRUD.Controllers
{
    [Controller]
    [Route("[controller]")]

    public class ProdutoController : ControllerBase
    {
        private DataContext dc;

        public ProdutoController(DataContext dataContext)
        {
            this.dc = dataContext;
        }

        [HttpPost("api")]
        public async Task<ActionResult> cadastar([FromBody] Produto p)
        {
            dc.produtos.Add(p);
            await dc.SaveChangesAsync();

            return Created("Obj Produto", p);
        }

        [HttpGet("api")]
        public async Task<ActionResult> listar()
        {
            var dado = await dc.produtos.ToListAsync();
            return Ok(dado);
        }

        [HttpGet("api/{codigo}")]
        public Produto filtrar(int codigo)
        {
            var p = dc.produtos.Find(codigo);
            return p;
        }

        [HttpPut("api")]
        public async Task<ActionResult> editar([FromBody] Produto p)
        {
            dc.produtos.Update(p);
            await dc.SaveChangesAsync();
            return Ok(p);
        }

        [HttpDelete("api/{codigo}")]
        public async Task<ActionResult> remover(int codigo)
        {
            Produto p = filtrar(codigo);

            if(p == null){
                return NotFound();
            }else{
                dc.produtos.Remove(p);
                await dc.SaveChangesAsync();
                return Ok();
            }

        }

        [HttpGet("oiProd")]
        public string oi()
        {
            return "Hello World Produto";
        }
    }
}