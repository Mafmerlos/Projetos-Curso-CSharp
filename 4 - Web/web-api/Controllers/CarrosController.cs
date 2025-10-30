using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.UI;
using web_api.Models;

namespace web_api.Controllers
{
    //API Carro versão 1 = 2025-10-23 11:33
    //API Carro versão 2 = 2025-10-28 10:22
    

    public class CarrosController : ApiController
    {
        private static List<Carro> listaCarro = new List<Models.Carro>();
        private static int contador = 0;

        // GET: api/Carros
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(listaCarro);
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
            //List<Carro> listaCarro = new List<Models.Carro>();
            //Carro c1 = new Carro();
            //c1.Nome = "Gol";
            //c1.Valor = 45.000;
            //listaCarro.Add(c1);


           /*for (int i = 0; i < 900; i++)
            {
                listaCarro.Add(new Models.Carro());
            } */


        /*for(int i = 0; i < 900; i++)
            {
                Models.Carro c = new Models.Carro();
                c.Nome = $"Carro {i}";
                listaCarro.Add(c);
            }
            
           


            return listaCarro;

            */
        }

        // GET: api/Carros/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                var carro = listaCarro.Find(item =>  item.Id == id);
                if (carro == null)
                    NotFound();
                return Ok(carro);


                //foreach (var carro in listaCarro)
                //{
                //    if (carro.Id == id)
                //    {
                //        return Ok(carro);
                //    }

                //}
                //return NotFound();
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        // POST: api/Carros
        public IHttpActionResult Post([FromBody] Models.Carro carro)
        {
            try
            {
                carro.Id = ++contador;
                listaCarro.Add(carro);

                return Content(HttpStatusCode.Created, carro);
                //return Ok(carro);
            }
            catch (Exception e)
            {
                //TODO: Log
                return InternalServerError();
            }

        }

        // PUT: api/Carros/5
        public IHttpActionResult Put(int id, [FromBody]Models.Carro value)
        {
            if (id != value.Id)
            { 
                return BadRequest("Id do corpo da requisição diferente do id do endpoint");
            }
            try
            {           
                var carro = listaCarro.FirstOrDefault(item => item.Id == id);
                if (carro == null)
                    NotFound();

                carro.Nome = value.Nome;
                carro.Valor = value.Valor;
                

               

                return Ok(carro);

                //foreach (Models.Carro carro in listaCarro)
                //{
                //    if (carro.Id == id)
                //    {
                //        carro.Nome = value.Nome;
                //        carro.Valor = value.Valor;
                //        return Ok(carro);
                //    }

                //}
                //return NotFound();
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Carros/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var carro = listaCarro.FirstOrDefault(item => item.Id == id);
                if(carro == null)
                {
                    NotFound();
                }


                listaCarro.Remove(carro);
                return Ok(carro);
                //foreach (Models.Carro carro in listaCarro)
                //{
                //    if (carro.Id == id)
                //    {
                //        listaCarro.Remove(carro);
                //        return Ok(carro);
                //    }
                //}
                //return NotFound();
            }
            catch (Exception e)
            {
                return InternalServerError();
            }
        }
    }
}
