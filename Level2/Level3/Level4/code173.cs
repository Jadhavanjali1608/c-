using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Database Connection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("StudentDB"));

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

// DbContext
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly AppDbContext db;

    public StudentController(AppDbContext context)
    {
        db = context;
    }

    // GET
    [HttpGet]
    public IActionResult GetStudents()
    {
        return Ok(db.Students.ToList());
    }

    // POST
    [HttpPost]
    public IActionResult AddStudent(Student s)
    {
        db.Students.Add(s);
        db.SaveChanges();

        return Ok("Student Added");
    }
}