using Business.Abstract;
using Etities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarımagesController : ControllerBase
    {
        ICarimgService _carimgService;

        public CarımagesController(ICarimgService carimgService)
        {
            _carimgService = carimgService;
        }

        [HttpPost("upload")]
        public IActionResult Upload(IFormFile formFile,[FromForm]Carimg carimg)
        {
            var result=_carimgService.Add(formFile,carimg);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete([FromForm]Carimg carimg)
        {
            var carDeleteImage = _carimgService.GetByImgId(carimg.Id).Data;
            var result = _carimgService.Delete(carDeleteImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(IFormFile formFile, [FromForm]Carimg carimg)
        {
            var result = _carimgService.Update(formFile, carimg);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carimgService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int carId)
        {
            var result = _carimgService.GetByCarId(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyimgid")]
        public IActionResult GeyByImgId(int imgId)
        {
           var result = _carimgService.GetByImgId(imgId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        

	}

}
