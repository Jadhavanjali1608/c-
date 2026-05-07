using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Model
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    // Sample Data
    static List<Student> students = new List<Student>
    {
        new Student { Id = 1, Name = "Anjali" },
        new Student { Id = 2, Name = "Rahul" },
        new Student { Id = 3, Name = "Priya" },
        new Student { Id = 4, Name = "Aman" },
        new Student { Id = 5, Name = "Sneha" }
    };

    // Pagination + Filtering
    [HttpGet]
    public IActionResult GetStudents(
        int page = 1,
        int pageSize = 2,
        string search = "")
    {
        var result = students
            .Where(x => x.Name.Contains(search,
                StringComparison.OrdinalIgnoreCase))
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return Ok(result);
    }
}