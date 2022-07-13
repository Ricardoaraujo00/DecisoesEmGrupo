using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DecisoesEmGrupo.Shared.Models
{
    public class Proposta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; } = 0;
        public string Texto { get; set; } = "";
        public DateTime DataSubmissao { get; set; } = DateTime.Now;
        public bool Aceite { get; set; } = false;
        public DateTime DataFecho { get; set; } = DateTime.Now;
        public bool Concluida { get; set; } = false;

        [NotMapped]
        public bool ShowComentarios { get; set; } = false;
        public HashSet<Comentario>? Comentarios { get; set; }
    }
}
