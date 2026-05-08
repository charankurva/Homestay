using Homestay.Data;
using Homestay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homestay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private HomeStayDbContext _dbcontext;
        public UserController(HomeStayDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser([FromRoute] int id)
        {
            if (_dbcontext.users == null)
            {
                return NotFound();
            }
            else
            {
                var user = await _dbcontext.users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }
                else return user;
            }
        }


        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User user)
        {
            await _dbcontext.users.AddAsync(user);
            await _dbcontext.SaveChangesAsync();
            return CreatedAtAction("GetUser", new { id = user.UserId }, User);
        }
    }
}
