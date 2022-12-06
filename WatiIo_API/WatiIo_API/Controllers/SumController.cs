using Microsoft.AspNetCore.Mvc;
using WatiIo_API.Models;
using WatiO.Shared;

namespace WatiIo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumController : ControllerBase
    {
        [Route("add")]
        [HttpPost]
        public async Task<int> Sum(Models.NumbersModel numbersModel)
        {
            var sharedClass = new SharedClass();
            return sharedClass.Sum(new WatiO.Shared.NumbersModel() { Number1 = numbersModel.Number1, Number2 = numbersModel.Number2 });
;       }
    }
}
