using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using XadrezBaleia.Application.DTOs.ClassEnrollments;
using XadrezBaleia.Application.DTOs.Classes;
using XadrezBaleia.Domain.Models;

namespace Xadrez_Baleia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassesController : ControllerBase
    {
        // Listar todas as turmas disponíveis
        [HttpGet]
        public async Task<ActionResult<List<Classes>>> Get()
        {
            throw new NotImplementedException();
        }

        // Consultar uma turma específica
        [HttpGet("{id}")]
        public async Task<ActionResult<Classes>> Get(int id)
        {
            throw new NotImplementedException();
        }

        // Criar uma turma (administrador)
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<Classes>> Post(
            [FromBody] CriarClasseDTO classe)
        {
            throw new NotImplementedException();
        }

        // Atualizar uma turma (administrador)
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<Classes>> Put(int id)
        {
            throw new NotImplementedException();
        }

        // Desativar uma turma (administrador)
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Classes>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        // Listar alunos matriculados e fila de espera (administrador)
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}/students")]
        public async Task<ActionResult<List<ClassEnrollments>>> GetStudents(int id)
        {
            throw new NotImplementedException();
        }

        // Solicitar ingresso em uma turma
        [Authorize]
        [HttpPost("{id}/enroll")]
        public async Task<ActionResult<ClassEnrollments>> Enroll(
            int id,
            [FromBody] CriarSolitacaoDTO solicitacao)
        {
            throw new NotImplementedException();
        }

        // Cancelar a própria matrícula
        [Authorize]
        [HttpDelete("{id}/enroll")]
        public async Task<ActionResult> CancelEnrollment(int id)
        {
            throw new NotImplementedException();
        }

        // Consultar a própria posição na fila
        [Authorize]
        [HttpGet("{id}/queue/me")]
        public async Task<ActionResult<int?>> GetMyQueuePosition(int id)
        {
            throw new NotImplementedException();
        }

        // Remover um aluno de uma turma (administrador)
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}/students/{userId}")]
        public async Task<ActionResult> RemoveStudent(int id, int userId)
        {
            throw new NotImplementedException();
        }
    }
}