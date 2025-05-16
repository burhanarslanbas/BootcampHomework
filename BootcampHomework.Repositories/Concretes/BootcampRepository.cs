using BootcampHomework.Entities;
using BootcampHomework.Repositories.Abstracts;
using BootcampHomework.Repositories.Concretes.Contexts;
using Core.Repositories.EntityFramework;
using System;

namespace BootcampHomework.Repositories.Concretes
{
    public class BootcampRepository : EfRepositoryBase<Bootcamp, Guid, BaseDbContext>, IBootcampRepository
    {
        public BootcampRepository(BaseDbContext context) : base(context)
        {
        }
    }
} 