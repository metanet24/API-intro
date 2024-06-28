//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Api_Intro.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class ExampleController : ControllerBase
//    {
//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            List<string> students = new List<string>() { "Metanet", "Cavid", "Naide" };
//            return Ok(students);
//        }

//        [HttpPost]

//        public IActionResult Create([FromBody] User user)
//        {
//            return Ok(user.Name+" "+user.Surname);
//        }
//    }
//}
