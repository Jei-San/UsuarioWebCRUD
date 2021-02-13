using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserWebCRUD.Shared
{
    public class UserProfessionInfo
    {
        [Key] public int UserProfessionId { get; set; }
        public string UserId { get; set; }
        public string ProfessionId { get; set; }
        public virtual ProfessionInfo ProfessionsInfo { get; set; }
        public virtual UserInfo UsersInfo { get; set; }
    }
}
