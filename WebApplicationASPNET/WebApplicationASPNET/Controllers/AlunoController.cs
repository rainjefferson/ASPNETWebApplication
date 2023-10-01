using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplicationASPNET.Models;

namespace WebApplicationASPNET.Controllers
{   [EnableCors("*", "*", "*")]
    public class AlunoController : ApiController
    {
        // GET: api/Aluno
        public IEnumerable<Aluno> Get()
        {
            //return new string[] { "Jefferson", "Rain" };
            Aluno alunos = new Aluno();
            //return alunos.listaAlunos(); lista em memória

            // Lista em arquivo json
            return alunos.listarAlunos();  
        }

        // GET: api/Aluno/5
        public Aluno Get(int id)
        {
            Aluno alunos = new Aluno();
            return alunos.listarAlunos().Where(x => x.RA == id).FirstOrDefault();
        }

        // POST: api/Aluno
        public List<Aluno> Post(Aluno aluno)
        {
            Aluno _aluno = new Aluno();
            _aluno.Inserir(aluno);
                        
            return _aluno.listaAlunos();
        }

        // PUT: api/Aluno/5
        public Aluno Put(int id, [FromBody]Aluno aluno)
        {
            Aluno _aluno = new Aluno();
            return _aluno.Atualizar(id, aluno);
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
        }
    }
}
