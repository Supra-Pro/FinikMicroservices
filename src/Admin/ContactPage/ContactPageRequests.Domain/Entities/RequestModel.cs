namespace ContactPageRequests.Domain.Entities
{
    public class RequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
