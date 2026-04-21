using Microsoft.EntityFrameworkCore;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<StudentAPI>> GetAll()
        => await _context.Students.ToListAsync();

    public async Task Add(StudentAPI student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }

    public async Task Update(StudentAPI student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var data = await _context.Students.FindAsync(id);
        if (data != null)
        {
            _context.Students.Remove(data);
            await _context.SaveChangesAsync();
        }
    }
}