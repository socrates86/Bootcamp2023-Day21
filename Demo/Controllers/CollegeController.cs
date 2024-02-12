using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CollegeController : ControllerBase
    {
        [HttpGet("GetCollege")]
        public string GetCollege()
        {
            return "College of Social Sciences";
        }

        [HttpGet("GetColleges")]
        public string GetColleges()
        {
            return "Colleges of Engineering";
        }
    }
}