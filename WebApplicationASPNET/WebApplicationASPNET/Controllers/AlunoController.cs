﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationASPNET.Models;

namespace WebApplicationASPNET.Controllers
{
    public class AlunoController : ApiController
    {
        // GET: api/Aluno
        public IEnumerable<Alunos> Get()
        {
            //return new string[] { "Jefferson", "Rain" };
            Alunos alunos = new Alunos();
            return alunos.listaAlunos();
        }

        // GET: api/Aluno/5
        public string Get(int id)
        {
            
            return "Jefferson";
        }

        // POST: api/Aluno
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Aluno/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Aluno/5
        public void Delete(int id)
        {
        }
    }
}
