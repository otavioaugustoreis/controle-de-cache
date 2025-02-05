using AprendendoUsoDoCache.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace AprendendoUsoDoCache.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        //Vai ser usada como chave para recuperar o valor salvo no cache
        private const string CacheProdutoKey =  "CacheProduto";
        public List<ProdutoEntity> ProdutoList { get; set; } = new()
        {
                new ProdutoEntity(1, "Geladeira"),
                new ProdutoEntity(2, "Fogão"),
                new ProdutoEntity(3, "Cadeira"),
                new ProdutoEntity(4, "Mesa"),
        };

        public ProdutoController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }

        [HttpGet]
        public ActionResult<List<ProdutoEntity>> GetProdutos()
        {

            if(!_cache.TryGetValue(CacheProdutoKey, out List<ProdutoEntity>? produtos))
            {
                produtos = ProdutoList;

                if (produtos is not null && produtos.Any())
                {
                    var cacheOptions = new MemoryCacheEntryOptions
                    {
                        //Tempo de expiração absoluta
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30),
                        //Tempo de expiração deslizante =  Item será removido caso ele não seja acessado em 15 segundos
                        SlidingExpiration = TimeSpan.FromSeconds(15),
                        //Prioridade Alta, será permitido na memória por mais tempo
                        Priority = CacheItemPriority.High
                    };
                    _cache.Set(CacheProdutoKey, produtos, cacheOptions);
                }
            }

            return Ok(produtos);
        }



    }
}
