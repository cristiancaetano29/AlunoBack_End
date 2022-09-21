using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola_API.Models
{
    public class Aluno
    {
        public int id { get; set; }
        [Required]
        [StringLength(5, ErrorMessage ="O campo RA não pode passar de 5 digitos")]
        public string? ra { get; set; }
        [Required]
        [StringLength(30, ErrorMessage ="O campo nome não pode passar de 30 digitos")]
        public string? nome { get; set; }
        [Required]
        //[MaxLength(2,ErrorMessage = "Campo deve ter 2(dois) caracteres")]
        public int codCurso { get; set; }
    }
}