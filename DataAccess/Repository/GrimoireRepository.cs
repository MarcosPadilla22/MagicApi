using DataAccess.IRepository;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class GrimoireRepository : IGrimoireRepository
    {
        private DataContext _context;
        public GrimoireRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Grimoire>> GetAll()
        {
            return await _context.Grimoire.ToListAsync();
        }
    }
}
