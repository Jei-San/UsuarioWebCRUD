using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioWebCRUD.Shared.Models
{
    public class UserData
    {
        public User User { get; set; }
        public Profession Profession { get; set; }
        public UserProfession UserProfession { get; set; }
    }
}
