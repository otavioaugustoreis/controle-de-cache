using AprendendoUsoDoCache.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AprendendoUsoDoCache.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public List<ProdutoEntity> ProdutoList { get; set; } = new()
        {
                new ProdutoEntity(1, "Geladeira"),
                new ProdutoEntity(2, "Fogão"),
                new ProdutoEntity(3, "Cadeira"),
                new ProdutoEntity(4, "Mesa"),
        };
        
        public ProdutoController() { }

        [HttpGet]
        public ActionResult<List<ProdutoEntity>> GetProdutos()
        {
            return Ok(ProdutoList);
        }


        
    }
}
