﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Entities
{
    public class BlackList: BaseEntity<Guid>
    {
        public Guid ApplicantId { get; set; } = default!;
        public string? Reason { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
