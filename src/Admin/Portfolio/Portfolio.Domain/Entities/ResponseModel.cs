namespace Portfolio.Domain.Entities
{
    public class ResponseModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; } = false;
    }
}
