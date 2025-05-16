using BootcampHomework.Entities.Enums;

namespace BootcampHomework.Business.Dtos.Responses.Application
{
    public class UpdatedApplicationResponse
    {
        public Guid Id { get; set; }
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
} 