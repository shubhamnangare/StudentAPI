using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentService _service;

    public StudentController(IStudentService service)
    {
        _service = service;
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAll());

    [HttpPost]
    public async Task<IActionResult> Add(StudentAPI student)
    {
        await _service.Add(student);
        return Ok("Added");
    }

    [HttpPut]
    public async Task<IActionResult> Update(StudentAPI student)
    {
        await _service.Update(student);
        return Ok("Updated");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.Delete(id);
        return Ok("Deleted");
    }
}