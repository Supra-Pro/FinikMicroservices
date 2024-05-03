namespace Dealers.Domain.Entities
{
    public class DealersModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset AddedAt { get; set; } = DateTimeOffset.Now;

    }
}
