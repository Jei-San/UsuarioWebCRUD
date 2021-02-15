using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuarioWebCRUD.Shared
{
    public class UserProfession
    {
        [Key] public int UserProfessionId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ProfessionId { get; set; }
        public virtual Profession Profession { get; set; }
    }
}
