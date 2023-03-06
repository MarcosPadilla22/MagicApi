using DataAccess.IRepository;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class AffinityRepository : IAffinityRepository
    {
        private DataContext _context;
        public AffinityRepository(DataContext context) { _context = context; }

        public async Task<IEnumerable<Affinity>> GetAll()
        {
            return await _context.Affinity.ToListAsync();
        }
    }
}
