using Microsoft.AspNetCore.Mvc;
using TestTaskQulix.Interfaces;
using TestTaskQulix.Services;

namespace TestTaskQulix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : Controller
    {
        private readonly IDataService _dataService;

        public ContentController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public object GetTexts()
            => _dataService.GetAllModels();
    }
}
