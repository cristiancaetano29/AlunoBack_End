using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEscola_API.Models
{
    public class Images
    {
        public int Id { get; set;}
        public string nome { get; set; }
        public byte[] dados { get; set; }
        public string contentType { get; set; }
    }
}