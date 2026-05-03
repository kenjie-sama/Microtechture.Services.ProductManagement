using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Domain.Models.Bases
{
    public class BaseCodeDecodeEntity : AuditableEntity<Guid>
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
    }
}
