// Controllers/StudentsController.cs
using Microsoft.AspNetCore.Mvc;
using Assignment5_AyseOzgeErkan.BLL.Services; // Referansın doğru olduğundan emin olun

namespace Assignment5_AyseOzgeErkan.MVC.Controllers // veya MVC projenizdeki doğru namespace'i kullanın
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // Action methods...
    }
}