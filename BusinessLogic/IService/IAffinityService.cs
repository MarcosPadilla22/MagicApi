using BusinessLogic.DTO;

namespace BusinessLogic.IService
{
    public interface IAffinityService
    {
        Task<List<AffinityDTO>> GetAll();
    }
}
