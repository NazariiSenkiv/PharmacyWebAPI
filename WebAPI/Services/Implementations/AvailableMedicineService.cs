using AutoMapper;
using WebAPI.Models;
using WebAPI.Repository;
using WebAPI.Services.Interfaces;

namespace WebAPI.Services.Implementations
{
    public class AvailableMedicineService : GenericService<AvailableMedicine>, IAvailableMedicineService
    {
        public AvailableMedicineService(IGenericRepository<AvailableMedicine> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

        public async Task<AvailableMedicine> DecreaseMedicineCountAsync(int id, int count)
        {
            var medicineRecord = (await _repository.GetByConditionAsync(m => m.Medicine.Id == id)).FirstOrDefault();
            
            try
            {
                medicineRecord.Count -= count;

                await _repository.UpdateAsync(medicineRecord);

                return medicineRecord;
            }
            catch (Exception ex)
            {
                throw new Exception($"cant decrease medicine count for {medicineRecord.Medicine.Name}!", ex);
            }
        }

        public async Task<AvailableMedicine> IncreaseMedicineCountAsync(int id, int count)
        {
            var medicineRecord = (await _repository.GetByConditionAsync(m => m.Medicine.Id == id)).FirstOrDefault();
            
            try
            {
                medicineRecord.Count += count;

                await _repository.UpdateAsync(medicineRecord);

                return medicineRecord;
            }
            catch (Exception ex)
            {
                throw new Exception($"cant increase medicine count for {medicineRecord.Medicine.Name}!", ex);
            }
        }
    }
}
