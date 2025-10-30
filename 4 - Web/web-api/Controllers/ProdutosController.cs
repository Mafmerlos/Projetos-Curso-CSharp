using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;

namespace web_api.Controllers
{
    public class ProdutosController : ApiController
    {
        private static List<Models.Produto> produtos = new List<Models.Produto>();
        private static int contador = 0;

        // GET: api/Produtos
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(produtos);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // GET: api/Produtos/5
        public IHttpActionResult Get(int id)
        {

            try
            {         
                var produto = produtos.FirstOrDefault(item => item.Id == id);

                if (produto == null)
                {
                    return NotFound();
                }
                return Ok(produto);
            }
            catch (Exception e) 
            { 
                return InternalServerError(e);
            }

            //foreach (var produto in produtos)
            //{
            //    if (produto.Id == id)
            //    {
            //        return produto;                                        
            //    }
                
            //}
            //return null;
        }

        // POST: api/Produtos
        public IHttpActionResult Post([FromBody]Models.Produto produto)
        {
            try
            {
                produto.Id = ++contador;
                produtos.Add(produto);
                return Ok();
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // PUT: api/Produtos/5
        public IHttpActionResult Put(int id, [FromBody]Models.Produto value)
        {
            if(id != value.Id)
            {
                return BadRequest("O id do endpoint é diferente da requisição");
            }

            try
            {
                var produto = produtos.FirstOrDefault(item => item.Id == id);
                if (produto == null)
                {
                    return NotFound();
                }
                produto.Nome = value.Nome;
                return Ok(produto);

            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
            



            //foreach(var produto in produtos)
            //{
            //    if (produto.Id == id)
            //    {
            //        produto.Nome = value.Nome;
            //        break;
            //    }
            //}
        }

        // DELETE: api/Produtos/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var produto = produtos.FirstOrDefault(item => item.Id == id);
                if (produto == null)
                {
                    return NotFound();
                }
                produtos.Remove(produto);
                return Ok(produto);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }

            //foreach (var produto in produtos)
            //{
            //    if (produto.Id == id)
            //    {
            //        produtos.Remove(produto);
            //        break;
            //    }
            //}

        }
    }
}
