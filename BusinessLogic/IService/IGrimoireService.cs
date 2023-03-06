using BusinessLogic.DTO;

namespace BusinessLogic.IService
{
    public interface IGrimoireService
    {
        Task<List<GrimoireDTO>> GetAll();
        Task<List<StudentShortDTO>> GetAllGrimoiresAndStudents();
    }
}
