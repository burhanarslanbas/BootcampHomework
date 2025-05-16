using BootcampHomework.Entities;
using Core.Repositories;

namespace BootcampHomework.Repositories.Abstracts
{
    public interface IApplicationRepository : IRepository<Application,Guid>
    {
    }
}