using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecisoesEmGrupo.Shared.Models
{
    public class GostoComentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ComentarioId { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public bool Gosto { get; set; } = false;
        public byte Concordancia { get; set; } = 0;
        public DateTime DataComentario { get; set; } = DateTime.Now;
    }
}
