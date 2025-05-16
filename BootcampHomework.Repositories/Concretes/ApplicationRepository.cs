using BootcampHomework.Entities;
using BootcampHomework.Repositories.Abstracts;
using BootcampHomework.Repositories.Concretes.Contexts;
using Core.Repositories.EntityFramework;
using System;

namespace BootcampHomework.Repositories.Concretes
{
    public class ApplicationRepository : EfRepositoryBase<Application, Guid, BaseDbContext>, IApplicationRepository
    {
        public ApplicationRepository(BaseDbContext context) : base(context)
        {
        }
    }
} 