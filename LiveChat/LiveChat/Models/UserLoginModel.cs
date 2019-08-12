using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturatHermes.Models
{
    public class UserLoginModel : IdentityUserLogin<Guid>
    {
        [Key]
        public Guid Key { get; set; }
        public UserLoginModel()
        {
            Key = Guid.NewGuid();
        }
    }
}
