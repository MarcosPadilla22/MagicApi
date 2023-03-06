using DataAccess.Models;

namespace DataAccess.IRepository
{
    public interface IAffinityRepository
    {
        Task<IEnumerable<Affinity>> GetAll();
    }
}
