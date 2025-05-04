using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Repositories.Abstracts
{
    public interface IQuery<T>
    {
        IQueryable<T> Query();
    }
}