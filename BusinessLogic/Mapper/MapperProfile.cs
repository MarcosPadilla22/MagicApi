using AutoMapper;
using BusinessLogic.DTO;
using DataAccess.Models;

namespace BusinessLogic.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() {

            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.TypeStatus, opt => opt.MapFrom(src => src.Status ? "Activo" : "Inactivo"))
                .ForMember(dest => dest.AffinityName, opt => opt.MapFrom(src => src.Affinity.Name ?? ""))
                .ForMember(dest => dest.GrimoireName, opt => opt.MapFrom(src => src.Grimoire.Name ?? ""));

            CreateMap<Affinity, AffinityDTO>();
            CreateMap<Grimoire, GrimoireDTO>();

            CreateMap<Student, StudentShortDTO>()
                .ForMember(dest => dest.Grimoire, opt => opt.MapFrom(src => src.Grimoire.Name ?? ""));
        }
    }
}
