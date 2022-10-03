using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola_API.Models
{
    public class Curso
    {
        public int id { get; set; }
        public int codCurso { get; set; }
        public string? nomeCurso { get; set;}
        public string? periodo { get; set;}
    }
}