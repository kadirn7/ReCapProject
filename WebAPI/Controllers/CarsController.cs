 using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public string Get()
        {
            
            var result = _carService.GetAll();
            return result.Message;
        }

    }
}
