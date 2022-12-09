namespace WebAPI.Models
{
    public class Medicine : IBaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public int ProductionYear { get; set; }
        public float Price { get; set; }
    }
}
