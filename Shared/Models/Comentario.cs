using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecisoesEmGrupo.Shared.Models
{
    public class Comentario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PropostaId { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public string TextoComentario { get; set; } = "";
        public DateTime DataComentario { get; set; } = DateTime.Now;
        
        public Proposta? Proposta { get; set; }

        [NotMapped]
        public int Gostos { get; set; }
    }
}
