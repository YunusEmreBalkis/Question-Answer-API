using Business.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        IAnswerService _answerService;
        public AnswersController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _answerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _answerService.GetAllByQuestionId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Answer answer)
        {
            var result = _answerService.Add(answer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Answer answer)
        {
            var resultowner = checkOwner(answer.UserId);
            if (resultowner == false)
            {
                return Unauthorized();
            }
            var result = _answerService.Update(answer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Answer answer)
        {
            var resultowner = checkOwner(answer.UserId);
            if (resultowner == false)
            {
                return Unauthorized();
            }
            var result = _answerService.Delete(answer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        public bool checkOwner(int userId)
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id == null)
            {
                return false;
            }
            var currentUserId = int.Parse(id);
            return currentUserId != userId ? false : true;
        }
    }
}
