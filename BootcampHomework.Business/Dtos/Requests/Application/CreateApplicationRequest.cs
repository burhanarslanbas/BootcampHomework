using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampHomework.Entities.Enums;

namespace BootcampHomework.Business.Dtos.Requests.Application
{
    public class CreateApplicationRequest
    {
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; } = ApplicationState.PENDING;
    }
}
