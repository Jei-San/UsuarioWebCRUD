using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UserWebCRUD.Shared
{
    public class ProfessionInfo
    {
        [Key] public int ProfessionId { get; set; }
        public string ProfessionName { get; set; }
        public virtual ICollection<UserProfessionInfo> UserProfessionsInfo { get; set; }
    }
}
