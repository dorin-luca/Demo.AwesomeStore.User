using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.AwesomeStore.User.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseContreller<T> : ControllerBase
    {
        public virtual Task<T> Get(int id)
        {
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<T> GetAll()
        {
            return null;
        }
        
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
