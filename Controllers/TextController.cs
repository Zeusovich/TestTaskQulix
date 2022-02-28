using Microsoft.AspNetCore.Mvc;
using TestTaskQulix.Interfaces;
using TestTaskQulix.Models;
using TestTaskQulix.Services;

namespace TestTaskQulix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextController : Controller
    {
        private readonly IDataService _dataService;

        public TextController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public Task<IEnumerable<Text>> GetTexts()
            => _dataService.GetText();

        [HttpPost]
        public Task Add([FromBody] Text text)
            => _dataService.AddText(text);
    }
}
