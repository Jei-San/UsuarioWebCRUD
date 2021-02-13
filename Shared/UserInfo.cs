using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserWebCRUD.Shared
{
    public class UserInfo
    {
        [Key] public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<UserProfessionInfo> UserProfessionsInfo { get; set; }
    }
}
