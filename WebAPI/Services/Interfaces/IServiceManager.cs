using WebAPI.Models;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services
{
    public interface IServiceManager
    {
        public IGenericService<Medicine> MedicineService { get; }
        public IAvailableMedicineService AvailableMedicineService { get; }
    }
}
