using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoEscola_API.Models;
using System.Diagnostics.CodeAnalysis;

namespace ProjetoEscola_API.Data
{
    public class EscolaContext: DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base (options){

        } 
        /*protected readonly IConfiguration Configuration;

        public EscolaContext(IConfiguration configuration){
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer(Configuration.GetConnectionString("StringConexaoSQLServer"));
        }*/

        public DbSet<Aluno> Aluno { get; set; }
    }
}