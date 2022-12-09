using AutoMapper;
using WebAPI.Repository;
using WebAPI.Models;
using WebAPI.Services.Interfaces;
using WebAPI.Services.Implementations;

namespace WebAPI.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IGenericRepository<Medicine> _medicineRepository;
        private readonly IGenericRepository<AvailableMedicine> _availableMedicineRepository;

        private readonly IMapper _mapper;

        public ServiceManager(
            IMapper mapper,
            IGenericRepository<Medicine> medicineRepository,
            IGenericRepository<AvailableMedicine> availableMedicineRepository)
        {
            _mapper = mapper;

            _medicineRepository = medicineRepository;
            _availableMedicineRepository = availableMedicineRepository;
        }

        
        public IGenericService<Medicine> MedicineService => new GenericService<Medicine>(_medicineRepository, _mapper);
        public IAvailableMedicineService AvailableMedicineService => 
            new AvailableMedicineService(_availableMedicineRepository, _mapper);
    }
}
