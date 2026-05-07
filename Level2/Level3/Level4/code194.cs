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

// Command (Write)
public class AddStudentCommand
{
    public string Name { get; set; }
}

// Query (Read)
public class GetStudentQuery
{
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    static List<Student> students =
        new List<Student>();

    // Command
    [HttpPost]
    public IActionResult AddStudent(
        AddStudentCommand command)
    {
        students.Add(new Student
        {
            Id = students.Count + 1,
            Name = command.Name
        });

        return Ok("Student Added");
    }

    // Query
    [HttpGet]
    public IActionResult GetStudents(
        [FromQuery] GetStudentQuery query)
    {
        return Ok(students);
    }
}