using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinManagerService.Domain
{
    public class User : BaseEntity
    {
        #region MyRegion

        #endregion

        #region MyRegion

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Account> Accounts { get; set; }

        #endregion
    }
}
