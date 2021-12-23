using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRelationshipOnetoOne.Model;

namespace StudentRelationshipOnetoOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get(int studentID)
        {
                   var students = await _context.Students
                .Include(a => a.Address)
                .Where(c => c.Id == studentID)
                .ToListAsync();
            return students;
        }
    }
}

