using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.IService;
using DataAccess.IRepository;

namespace BusinessLogic.Service
{
    public class AffinityService : IAffinityService
    {
        private readonly IMapper _mapper;
        private readonly IAffinityRepository _affinityRepository;
        public AffinityService(
            IMapper mapper,
            IAffinityRepository affinityRepository)
        {
            _mapper = mapper;
            _affinityRepository = affinityRepository;
        }

        public async Task<List<AffinityDTO>> GetAll()
        {
            var results = await _affinityRepository.GetAll();
            return results.Select(x => _mapper.Map<AffinityDTO>(x)).ToList();
        }
    }
}
