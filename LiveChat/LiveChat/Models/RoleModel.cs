using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturatHermes.Models
{
    public class RoleModel : IdentityRole<Guid, UserRoleModel>
    {
    }
}
