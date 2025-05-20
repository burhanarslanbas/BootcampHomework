using BootcampHomework.Entities.Enums;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Entities
{
    public class Application : BaseEntity<Guid>
    {
        public Guid ApplicantId { get; set; }
        public Guid BootcampId { get; set; }
        public ApplicationState State { get; set; } = ApplicationState.PENDING;

        // Navigation Properties
        public virtual Bootcamp Bootcamp { get; set; } = default!;
    }
}
