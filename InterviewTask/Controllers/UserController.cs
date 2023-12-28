using InterviewTask.Models;
using InterviewTask.UserContract;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTask.Controllers
{
    public class UserController: Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            List<UserDetail> response = _userService.GetUsers();
            return View(response);
        }

        [HttpGet]
        [Route("user/Add")]
        public IActionResult Create()
        {
            return View("Add");
        }

        [HttpPost]
        [Route("user/Add")]
        public IActionResult Add(UserDetail userData ) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _userService.AddUser(userData);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUser()
        {
            return View();
        }

        [HttpGet]
        [Route("GetUserByUserName")]
        public IActionResult GetUserByUserName(string userName)
        {
            List<UserDetail> result = new List<UserDetail>();
            result =  _userService.SearchUser(userName);
            ViewBag.UserName = result.First().UserName;
            return PartialView("GetUserByUserName", result);
        }
    }
}
