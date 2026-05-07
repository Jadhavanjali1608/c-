using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IStudentService,
    StudentService>();

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

// Service Interface
public interface IStudentService
{
    Student GetStudent();
}

// Service Class
public class StudentService : IStudentService
{
    public Student GetStudent()
    {
        return new Student
        {
            Id = 1,
            Name = "Anjali"
        };
    }
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentService service;

    public StudentController(IStudentService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetStudent());
    }
}