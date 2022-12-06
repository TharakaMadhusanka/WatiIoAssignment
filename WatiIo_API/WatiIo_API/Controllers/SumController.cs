using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WatiIo_API.Models;

namespace WatiIo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumController : ControllerBase
    {
        [Route("add")]
        [HttpPost]
        public async Task<int> Sum(NumbersModel numbersModel)
        {
            return numbersModel.Number1 + numbersModel.Number2;
;       }
    }
}
