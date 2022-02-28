using Microsoft.AspNetCore.Mvc;
using TestTaskQulix.Interfaces;
using TestTaskQulix.Models;
using TestTaskQulix.Services;

namespace TestTaskQulix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : Controller
    {
        private readonly IDataService _dataService;

        public PhotoController(IDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpGet("{id}")]
        public Task<Photo> Get([FromRoute] int id)
            => _dataService.GetPhotoById(id);

        [HttpGet]
        public Task<IEnumerable<Photo>> GetAll() 
            => _dataService.GetAllPhotos();

        [HttpPut]
        public Task<Photo> Update([FromBody] Photo photo)
            => _dataService.UpdatePhoto( photo);

        [HttpPost]
        public Task<Photo> SendRating( [FromBody] Photo photo)
            => _dataService.SendRating(photo);
    }
}
