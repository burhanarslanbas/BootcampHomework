﻿using BootcampHomework.Entities.Enums;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Entities
{
    public class Bootcamp : BaseEntity<Guid>
    {
        public string Name { get; set; } = default!;
        public Guid InstructorId { get; set; } = default!;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime? EndDate { get; set; }
        public BootcampState State { get; set; } = BootcampState.OPEN_FOR_APPLICATION;
    }
}
