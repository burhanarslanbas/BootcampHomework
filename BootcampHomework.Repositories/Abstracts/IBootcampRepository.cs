using BootcampHomework.Entities;
using Core.Repositories;

namespace BootcampHomework.Repositories.Abstracts
{
    public interface IBootcampRepository : IRepository<Bootcamp, Guid>
    {
    }
}
