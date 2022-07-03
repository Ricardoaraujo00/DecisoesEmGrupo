using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisoesEmGrupo.Shared.Models
{
    public class Utilizador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public string NomeCompleto { get; set; } = "";
        public string NumeroCc { get; set; } = "";
        public DateTime DataNascimento { get; set; } =DateTime.Now;
        public string Telemovel { get; set; } = "";
        public string Email { get; set; } = "";
        public int Role { get; set; } = 0;
        public int ValidadoPor { get; set; } = 0;
        public DateTime DataRegisto { get; set; } = DateTime.Now;
    }
}
