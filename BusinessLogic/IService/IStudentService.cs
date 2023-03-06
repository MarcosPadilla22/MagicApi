using BusinessLogic.DTO;

namespace BusinessLogic.IService
{
    public interface IStudentService
    {
        Task<StudentDTO> Get(int id);
        Task<List<StudentDTO>> GetAll();
        Task<bool> Create(StudentDTO dto);
        Task Update(StudentDTO dto);
        Task ActiveOrInactive(int id);
        Task Delete(int id);
    }
}
