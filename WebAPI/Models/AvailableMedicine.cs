namespace WebAPI.Models
{
    public class AvailableMedicine : IBaseModel
    {
        public int Id { get; set; }

        public virtual Medicine Medicine { get; set; }
        public int Count { get; set; }
    }
}
