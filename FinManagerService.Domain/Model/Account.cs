using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinManagerService.Domain
{
    public class Account : BaseEntity
    {
        public string Number { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
