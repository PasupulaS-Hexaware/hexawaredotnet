using System.Collections.Generic;
using hexawware.Business.Interfaces;
using hexawware.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace hexawware.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class HexawareController : ControllerBase
    {
        IHexawareService _HexawareService;
        public HexawareController(IHexawareService HexawareService)
        {
            _HexawareService = HexawareService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hexaware>> Get()
        {
            return Ok(_HexawareService.GetAll());
        }

        [HttpPost]
        public ActionResult<Hexaware> Save(Hexaware Hexaware)
        {
            return Ok(_HexawareService.Save(Hexaware));

        }

        [HttpPut]
        public ActionResult<Hexaware> Update( Hexaware Hexaware)
        {
            return Ok(_HexawareService.Update(Hexaware));

        }

        [HttpDelete]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(_HexawareService.Delete(id));

        }
        [HttpGet("{id:int}")]
        public ActionResult<Hexaware> GetById(int id)
        {
            return Ok(_HexawareService.GetById(id));
        }

    }
}
