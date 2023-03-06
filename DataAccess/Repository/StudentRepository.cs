using DataAccess.IRepository;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Student model)
        {
            var modelDb = await _context.Student.AddAsync(model);
            await _context.SaveChangesAsync();
            return modelDb.Entity.Id != 0;
        }

        public async Task Delete(Student model)
        {
            _context.Student.Update(model);
            await _context.SaveChangesAsync();
        }

        public async Task<Student> Get(int id)
        {
            return await _context.Student
                .Include(x => x.Grimoire)
                .Include(x => x.Affinity)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Student
                .Include(x => x.Grimoire)
                .Include(x => x.Affinity)
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public async Task Update(Student model)
        {
            _context.Student.Update(model);
            await _context.SaveChangesAsync();
        }
    }
}
