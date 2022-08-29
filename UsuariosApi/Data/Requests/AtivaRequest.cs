using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosApi.Data.Requests
{
    public class AtivaRequest
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string CodigoAtivacao{ get; set; }
    }
}
