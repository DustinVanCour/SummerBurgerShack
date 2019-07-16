using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack.Models;
using burgershack.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurgersController : ControllerBase
    {
        private readonly BurgerRepository _br; //provides refrence to repository (service)
        public BurgersController(BurgerRepository br)
        {
            _br = br;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Burger>> Get()
        {
            try
            {
                return Ok(_br.GetAllBurgers());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<Burger> Get(int id)
        // {
        //     try
        //     {
        //         Burger found = Burgers.Find(burger => burger.Id == id);
        //         if (found == null) return BadRequest("No burger with that Id");
        //         return Ok(found);
        //     }
        //     catch (Exception e)
        //     {
        //         return BadRequest(e);
        //     }

        // }

        // POST api/values
        // [HttpPost]
        // public ActionResult<IEnumerable<Burger>> Post([FromBody] Burger value)
        // {
        //     Burgers.Add(value);
        //     return Ok(Burgers);
        // }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
