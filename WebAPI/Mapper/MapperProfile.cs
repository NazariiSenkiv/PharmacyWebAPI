using AutoMapper;
using WebAPI.Models;
using System.ComponentModel;
using WebAPI.DTO;

namespace WebAPI.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Medicine, MedicineDTO>();
            CreateMap<MedicineDTO, Medicine>();
        }
    }
}
