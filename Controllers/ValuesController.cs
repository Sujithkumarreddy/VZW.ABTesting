using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using WebApiSample.Models;
using WebApiSample.Initializer;
using System.Linq;

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
                var id=Seeder.lstAdds.Count;
                 CreateAdd objAdd = new CreateAdd();
                objAdd.AgeGroup = value.AgeGroup;
                objAdd.Browser = value.Browser;
                objAdd.Device = value.Device;
                objAdd.Gender = value.Gender;
                objAdd.Region = value.Region;
                objAdd.URL = value.URL;
                objAdd.RegionName = value.RegionName;
                objAdd.ID = id + 1;
            Seeder.lstAdds.Add(objAdd);

            return Json("ok");
        }
        [Route("[action]")]
        public List<CreateAdd> getUrlNames()
        {        
            return Seeder.lstAdds;
        }
        [Route("[action]/{id}")]      
        public string IncrementCounter(int id)
        {
            var Product = Seeder.lstProducts.Where(kvp => kvp.ID == id).Select(x => x).ToArray();
             
            if (Product != null && Product.Length==1)
            {
                Product[0].Views = Product[0].Views + 1;
            }
            return "ok";
        }

        [Route("[action]/{id}")]
        public JsonResult GetProductsDetails(int id)
        {
            var Product = Seeder.lstProducts.Where(kvp => kvp.ID == id).Select(x => x).ToArray();
            return Json(Product);
        }

        [Route("[action]/{id}")]
        public string UpdatePurchased(int id)
        {
            var Product = Seeder.lstProducts.Where(kvp => kvp.ID == id).Select(x => x).ToArray();

            if (Product != null && Product.Length == 1)
            {
                Product[0].TotalNoOfPurchases = Product[0].TotalNoOfPurchases + 1;
            }
            return "ok";
        }


        [Route("[action]")]
        public JsonResult AddsViewHistory(AddsHistory value)
        {
            AddsHistory objAdd = new AddsHistory();
            objAdd.AgeGroup = value.AgeGroup;
            objAdd.Gender = value.Gender;
            objAdd.Region = value.Region;
            objAdd.Views = value.Views;
            objAdd.ID = value.ID;
            Seeder.lstAddsHistory.Add(objAdd);
            return Json("ok");
        }

    }

    
}










