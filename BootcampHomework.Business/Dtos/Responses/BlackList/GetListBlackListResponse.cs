namespace BootcampHomework.Business.Dtos.Responses.BlackList
{
    public class GetListBlackListResponse
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public string? Reason { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
} 