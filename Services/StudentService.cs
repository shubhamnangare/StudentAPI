public class StudentService : IStudentService
{
    private readonly IStudentRepository _repo;

    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<StudentAPI>> GetAll()
        => await _repo.GetAll();

    public async Task Add(StudentAPI student)
    {
        student.CreatedDate = DateTime.Now;
        await _repo.Add(student);
    }

    public async Task Update(StudentAPI student)
        => await _repo.Update(student);

    public async Task Delete(int id)
        => await _repo.Delete(id);

    Task<IEnumerable<StudentAPI>> IStudentService.GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Studen(StudentAPI student)
    {
        throw new NotImplementedException();
    }


}