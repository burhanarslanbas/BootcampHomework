using BootcampHomework.Entities;
using BootcampHomework.Repositories.Abstracts;
using BootcampHomework.Repositories.Concretes.Contexts;
using Core.Repositories.EntityFramework;
namespace BootcampHomework.Repositories.Concretes
{
    public class BlackListRepository : EfRepositoryBase<BlackList, Guid, BaseDbContext>, IBlackListRepository
    {
        public BlackListRepository(BaseDbContext context) : base(context)
        {
        }
    }
} 