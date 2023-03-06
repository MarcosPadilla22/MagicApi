using DataAccess.Models;

namespace DataAccess.IRepository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> Get(int id);
        Task<bool> Create(Student model);
        Task Update(Student model);
        Task Delete(Student model);
    }
}
