using Newtonsoft.Json.Linq;
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
        private static List<Models.Produto> produtos = new List<Models.Produto>();
        private static int contador = 0;

        // GET: api/Produtos
        public List<Models.Produto> Get()
        {         
            return produtos;
        }

        // GET: api/Produtos/5
        public Models.Produto Get(int id)
        {
            foreach (var produto in produtos)
            {
                if (produto.Id == id)
                {
                    return produto;                                        
                }
                
            }
            return null;
        }

        // POST: api/Produtos
        public void Post([FromBody]Models.Produto produto)
        {
            produto.Id = ++contador;
            
            produtos.Add(produto);
        }

        // PUT: api/Produtos/5
        public void Put(int id, [FromBody]Models.Produto value)
        {
            foreach(var produto in produtos)
            {
                if (produto.Id == id)
                {
                    produto.Nome = value.Nome;
                    break;
                }
            }
        }

        // DELETE: api/Produtos/5
        public void Delete(int id)
        {
            foreach (var produto in produtos)
            {
                if (produto.Id == id)
                {
                    produtos.Remove(produto);
                    break;
                }
            }

        }
    }
}
