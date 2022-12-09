using WebAPI.Models;

namespace WebAPI.Services.Interfaces
{
    public interface IAvailableMedicineService : IGenericService<AvailableMedicine>
    {
        Task<AvailableMedicine> DecreaseMedicineCountAsync(int id, int count);
        Task<AvailableMedicine> IncreaseMedicineCountAsync(int id, int count);
    }
}
