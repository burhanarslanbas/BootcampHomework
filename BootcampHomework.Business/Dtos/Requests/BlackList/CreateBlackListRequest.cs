namespace BootcampHomework.Business.Dtos.Requests.BlackList
{
    public class CreateBlackListRequest
    {
        public Guid ApplicantId { get; set; }
        public string? Reason { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
} 