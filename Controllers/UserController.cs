using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TennisClubApi.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TennisClubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBusinessProvider userBusinessProvider;

        public UserController(IUserBusinessProvider userBusinessProvider)
        {
            this.userBusinessProvider = userBusinessProvider;
        }

        // GET: api/<UserTypeController>
        [HttpGet]
        public string Get()
        {
            var userTypes = userBusinessProvider.GetUsers();
            string json = JsonConvert.SerializeObject(userTypes);
            return json;
        }

        // GET api/<UserTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
