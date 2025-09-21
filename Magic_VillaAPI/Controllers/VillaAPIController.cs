using Magic_VillaAPI.Logging;
using Magic_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace Magic_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ILogging _logger;
        public VillaAPIController(ILogging logger)
        {
            _logger = logger;
        }
        //private readonly ILogger<VillaAPIController> _logger;
        //public VillaAPIController(ILogger<VillaAPIController> logger)
        //{
        //    _logger = logger;
        //}
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            _logger.Log("Getting all villas","");
            return Ok(VillaStore.villaList);
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200 , Type = typeof(VillaDto) )]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(400)]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if (id == 0)
                _logger.Log("Get Villa Error with Id " + id ,"Error");
            return BadRequest();
            var villa = VillaStore.villaList.FirstOrDefault(v => v.ID == id);
            if (villa == null)
                return NotFound();

            return Ok(villa);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> CreateVilla([FromBody] VillaDto villaDto)
        {
            if (VillaStore.villaList.FirstOrDefault(v => v.Name.ToLower() == villaDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Villa already exists!");
                return BadRequest(ModelState);
            }
            //if(ModelState.IsValid == false)
            //{
            //    return BadRequest(ModelState);
            //}
            if (villaDto == null)
                return BadRequest(villaDto);
            if (villaDto.ID > 0)
                return StatusCode(StatusCodes.Status500InternalServerError);

            villaDto.ID = VillaStore.villaList.OrderByDescending(v => v.ID).FirstOrDefault().ID + 1;
            VillaStore.villaList.Add(villaDto);
            return CreatedAtRoute("GetVilla", new { id = villaDto.ID }, villaDto);


        }


        [HttpPost("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<VillaDto> DeleteVilla(int id)
        {
            if (id == 0)
                return BadRequest();
            var villa = VillaStore.villaList.FirstOrDefault(v => v.ID == id);
            if (villa == null)
                return NotFound();
            VillaStore.villaList.Remove(villa);
            return NoContent();
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<VillaDto> UpdateVilla(int id, [FromBody] VillaDto villaDto)
        {
            if (villaDto == null || id != villaDto.ID)
                return BadRequest();
            var villa = VillaStore.villaList.FirstOrDefault(v => v.ID == id);
            if (villa == null)
                return NotFound();
            villa.Name = villaDto.Name;
            villa.Occupancy = villaDto.Occupancy;
            villa.Sqft = villaDto.Sqft;
            return NoContent();
        }


        [HttpPatch("{id:int}", Name="UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDto> UpdatePartialVilla(int id, JsonPatchDocument<VillaDto> patchDto)
        {
            if (patchDto == null || id == 0)
                return BadRequest();
            var villa = VillaStore.villaList.FirstOrDefault(v => v.ID == id);
            if (villa == null)
                return NotFound();
            
            patchDto.ApplyTo(villa, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return NoContent();
        }
    }
}
