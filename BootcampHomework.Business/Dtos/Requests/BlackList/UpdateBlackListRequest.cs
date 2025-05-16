namespace BootcampHomework.Business.Dtos.Requests.BlackList
{
    public class UpdateBlackListRequest
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public string? Reason { get; set; }
        public DateTime Date { get; set; }
    }
} 