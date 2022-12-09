namespace WebAPI.DTO
{
    public class MedicineDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public int ProductionYear { get; set; }
        public float Price { get; set; }
    }
}
