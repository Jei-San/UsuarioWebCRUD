using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UsuarioWebCRUD.Shared
{
    public class Profession
    {
        [Key] public int ProfessionId { get; set; }
        public string ProfessionName { get; set; }
    }
}
