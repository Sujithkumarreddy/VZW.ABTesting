using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WebApiSample.Models;
using WebApiSample.Initializer;

namespace WebApiSample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        [HttpGet]
        [Route("[action]")]
        public List<Product> GetProducts()
        {
            List<Product> lstp = new List<Product>();
            lstp = Seeder.lstProducts;
            return lstp;
        }

        [Route("[action]")]
        public JsonResult PostURL(CreateAdd value)
        {
            CreateAdd objAdd = new CreateAdd();
            objAdd.AgeGroup = value.AgeGroup;
            objAdd.Browser = value.Browser;
            objAdd.Device = value.Device;
            objAdd.Gender = value.Gender;
            objAdd.Region = value.Region;
            objAdd.URL = value.URL;
            Seeder.lstAdds.Add(objAdd);

            return Json("ok");
        }
        [Route("[action]")]
        public List<CreateAdd> getUrlNames()
        {        
            return Seeder.lstAdds;
        }
    }
}










