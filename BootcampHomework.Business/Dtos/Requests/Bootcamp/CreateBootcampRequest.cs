using BootcampHomework.Entities.Enums;

namespace BootcampHomework.Business.Dtos.Requests.Bootcamp;
public class CreateBootcampRequest
{
    public string Name { get; set; } = default!;
    public Guid InstructorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public BootcampState State { get; set; } = BootcampState.OPEN_FOR_APPLICATION;
}
