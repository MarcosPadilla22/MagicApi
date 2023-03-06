using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.IService;
using DataAccess.IRepository;

namespace BusinessLogic.Service
{
    public class GrimoireService : IGrimoireService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly IGrimoireRepository _grimoireRepository;
        public GrimoireService(
            IMapper mapper,
            IStudentRepository studentRepository,
            IGrimoireRepository grimoireRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
            _grimoireRepository = grimoireRepository;
        }

        public async Task<List<GrimoireDTO>> GetAll()
        {
            var results = await _grimoireRepository.GetAll();
            return results.Select(x => _mapper.Map<GrimoireDTO>(x)).ToList();
        }

        public async Task<List<StudentShortDTO>> GetAllGrimoiresAndStudents()
        {
            var results = await _studentRepository.GetAll();
            return results.Select(x => _mapper.Map<StudentShortDTO>(x)).ToList();
        }
    }
}
