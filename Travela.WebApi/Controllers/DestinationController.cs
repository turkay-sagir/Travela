using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        [HttpGet]
        public IActionResult DestionationList()
        {
            var values = _destinationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateDestionation(Destination destination)
        {
            _destinationService.TInsert(destination);
            return Ok("Rota başarıyla eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteDestionation(int id)
        {
            _destinationService.TDelete(id);
            return Ok("Rota başarıyla silindi");
        }

        [HttpPut]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return Ok("Güncelleme yapıldı");
        }


    }
}
