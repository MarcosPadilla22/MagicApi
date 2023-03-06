using DataAccess.Models;

namespace DataAccess.IRepository
{
    public interface IGrimoireRepository
    {
        Task<IEnumerable<Grimoire>> GetAll();
    }
}
