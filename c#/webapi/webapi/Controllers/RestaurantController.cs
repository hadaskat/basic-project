using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    public class RestaurantController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            int a = 78;
            return a;
        }
    }
}
