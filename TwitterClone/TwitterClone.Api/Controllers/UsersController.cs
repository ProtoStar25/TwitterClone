using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserDto createUserDto) 
        {
            var createdUser = _userService.CreateUser(createUserDto);

            if (createdUser == null)
            {
                return BadRequest("User could not be created.");
            }
            return Ok(createdUser);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromRoute]Guid id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] Guid id, [FromBody] UpdateUserDto updateUserDto)
        {
            var user = _userService.UpdateUser(id, updateUserDto);
            if (user == null)
            {
                return NotFound();
            }
         

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromRoute] Guid id)
        {
            var isDeleted = _userService.DeleteUser(id);
            if (isDeleted == false)
            {
                return NotFound();
            }
            return Ok(isDeleted);
        }


    }
}
