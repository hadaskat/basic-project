using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private  IProductBll ProductBll;
        public ProductController(IProductBll  ProductBll)
        {
            this.ProductBll = ProductBll;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public List<ProductDTO> Get()
        {
            return ProductBll.getAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ProductDTO Get(int id)
        {
            return ProductBll.getById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] ProductDTO value)
        {
             ProductBll.post(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductDTO value)
        {
            ProductBll.put(id, value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ProductBll.delete(id);
        }
    }
}


