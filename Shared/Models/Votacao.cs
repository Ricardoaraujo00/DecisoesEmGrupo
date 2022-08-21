using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecisoesEmGrupo.Shared.Models
{
    public class Votacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PropId { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public int VoteBy { get; set; } = 0;
        public bool Voto { get; set; } = false;
        public byte Concordancia { get; set; } = 0;
        public DateTime DataVoto { get; set; } = DateTime.Now;
    }
}
