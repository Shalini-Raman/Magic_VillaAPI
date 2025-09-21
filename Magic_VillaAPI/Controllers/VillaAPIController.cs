using Magic_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;


namespace Magic_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
           return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200 , Type = typeof(VillaDto) )]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(400)]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if(id==0)
                return BadRequest();
            var villa = VillaStore.villaList.FirstOrDefault(v => v.ID == id);
            if(villa == null)
                return NotFound();

            return Ok(villa);
        }


        [HttpPost]
        public ActionResult<VillaDto> CreateVilla([FromBody] VillaDto villaDto)
        {
            if(villaDto == null)
                return BadRequest(villaDto);
            if (villaDto.ID > 0)
                return StatusCode(StatusCodes.Status500InternalServerError);

            villaDto.ID = VillaStore.villaList.OrderByDescending(v => v.ID).FirstOrDefault().ID + 1;
            VillaStore.villaList.Add(villaDto);
            return Ok(villaDto);


        }
    }
}
