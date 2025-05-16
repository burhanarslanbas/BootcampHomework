using BootcampHomework.Entities.Enums;

namespace BootcampHomework.Business.Dtos.Responses.Bootcamp;
public class GetBootcampResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public Guid InstructorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public BootcampState State { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
