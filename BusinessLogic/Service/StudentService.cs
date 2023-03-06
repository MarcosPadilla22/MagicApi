using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.IService;
using BusinessLogic.Validation;
using DataAccess.IRepository;
using DataAccess.Models;
using FluentValidation;

namespace BusinessLogic.Service
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        private readonly IGrimoireRepository _grimoireRepository;
        public StudentService(
            IMapper mapper,
            IStudentRepository studentRepository,
            IGrimoireRepository grimoireRepository)
        {
            _mapper = mapper;
            _studentRepository = studentRepository;
            _grimoireRepository = grimoireRepository;
        }

        public async Task ActiveOrInactive(int id)
        {
            var model = await _studentRepository.Get(id);
            if (model == null)
                throw new Exception("Error, no se encontro al estudiante");

            model.Status = !model.Status;
            await _studentRepository.Delete(model);
        }

        public async Task<bool> Create(StudentDTO dto)
        {
            var model = _mapper.Map<Student>(dto);
            var idGrimoire = await GetRandomIdGrimoire();
            model.IdGrimoire = idGrimoire;
            return await _studentRepository.Create(model);
        }

        public async Task Delete(int id)
        {
            var model = await _studentRepository.Get(id);
            if(model == null)
                throw new Exception("Error, no se encontro al estudiante");

            model.IsDeleted = true;
            await _studentRepository.Delete(model);
        }

        public async Task<StudentDTO> Get(int id)
        {
            var model = await _studentRepository.Get(id);
            return _mapper.Map<StudentDTO>(model);
        }

        public async Task<List<StudentDTO>> GetAll()
        {
            var models = await _studentRepository.GetAll();
            return models.Select(x => _mapper.Map<StudentDTO>(x)).ToList(); 
        }

        public async Task Update(StudentDTO dto)
        {
            var model = await _studentRepository.Get(dto.Id);
            if (model == null)
                throw new Exception("Error, no se encontro al estudiante");

            model.Name = dto.Name;
            model.Surname = dto.Surname;
            model.Identification = dto.Identification;
            model.Age = dto.Age;
            model.IdAffinity = dto.IdAffinity;
            await _studentRepository.Update(model);
        }

        #region Private Methods
        private async Task<int> GetRandomIdGrimoire()
        {
            var grimoires = await _grimoireRepository.GetAll();
            Random rnd = new Random();
            return rnd.Next(grimoires.First().Id, grimoires.Last().Id);
        }
        #endregion
    }
}
