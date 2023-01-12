using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Models.Identity
{
    public class DeleteUserRequest
    {

        public int idCompany { get; set; }
        public string UserId { get; set; } = string.Empty;


    }
}
