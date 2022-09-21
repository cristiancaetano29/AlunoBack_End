using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEscola_API.Data;
using ProjetoEscola_API.Models;

namespace ProjetoEscola_API.Controllers
{
    [Route("api/controller/cursos")]
    [ApiController]
    public class CursosController : Controller
    {
        private EscolaContext _context;

        public CursosController(EscolaContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Curso>> GetAll(){
            return _context.Curso.ToList();
        }

        [HttpPost]
        public async Task<ActionResult> post (Curso modelo) {
            try{
                _context.Curso.Add(modelo);
                if (await _context.SaveChangesAsync() == 1)
                    return Created($"/api/curso/{modelo.codCurso}", modelo);
            }
            catch{
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao Tentar Acessar o Banco de Dados");
            }
            //Caso os Comandos Acima não Funcionen ele Retornar uma BadRequest.
            return BadRequest();
        }

        [HttpPut("{CursoId}")]
        public async Task<IActionResult> put (int CursoId, Curso newDataCourse){
            try{
                var result = await _context.Curso.FindAsync(CursoId);
                if(CursoId != result.id)
                    return BadRequest();

                result.codCurso = newDataCourse.codCurso;
                result.nomeCurso = newDataCourse.nomeCurso;
                result.periodo = newDataCourse.periodo;
                await _context.SaveChangesAsync();
                return Created($"/api/aluno/{newDataCourse.codCurso}", newDataCourse);
            }
            catch{
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao Tentar Acessar o Banco de Dados");
            }
        }

        [HttpDelete("{CursoId}")]
        public async Task<ActionResult> delete(int CursoId) {
            try{
                var curso = await _context.Curso.FindAsync(CursoId);
                if(curso == null)
                    return NotFound();

                _context.Remove(curso);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch{
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao Tentar Acessar o Banco de Dados");
            }
        }
    }
}