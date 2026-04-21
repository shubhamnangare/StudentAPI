public interface IStudentService
{
    Task<IEnumerable<StudentAPI>> GetAll();
    Task Add(StudentAPI student);
    Task Update(StudentAPI student);
    Task Delete(int id);
}