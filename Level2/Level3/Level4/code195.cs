using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();

// Event Class
public class StudentAddedEvent
{
    public string Name { get; set; }
}

// Event Publisher
public class EventPublisher
{
    public static event Action<StudentAddedEvent> OnStudentAdded;

    public static void Publish(StudentAddedEvent data)
    {
        OnStudentAdded?.Invoke(data);
    }
}

// Event Subscriber
public class EventSubscriber
{
    static EventSubscriber()
    {
        EventPublisher.OnStudentAdded += HandleEvent;
    }

    public static void HandleEvent(StudentAddedEvent data)
    {
        Console.WriteLine(
            "Student Added: " + data.Name);
    }
}

// Controller
[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    [HttpPost]
    public IActionResult AddStudent(string name)
    {
        // Publish Event
        EventPublisher.Publish(
            new StudentAddedEvent
            {
                Name = name
            });

        return Ok("Event Triggered");
    }
}