using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_api.Controllers
{
    public class ProdutosController : ApiController
    {
        // GET: api/Produtos
        public List<Models.Produto> Get()
        {
            Models.Produto p1 = new Models.Produto();
            p1.Id = 1;
            p1.Nome = "TV";

            Models.Produto p2 = new Models.Produto();

            List<Models.Produto> produtos = new List<Models.Produto>();
            produtos.Add(p1);
            produtos.Add(p2);

            return produtos;
        }

        // GET: api/Produtos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Produtos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Produtos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Produtos/5
        public void Delete(int id)
        {
        }
    }
}
