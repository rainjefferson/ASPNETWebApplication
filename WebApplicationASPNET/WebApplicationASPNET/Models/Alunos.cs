using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationASPNET.Models
{
    public class Alunos
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int RA { get; set; }

        // método que retorna lista de alunos
        public List<Alunos> listaAlunos()
        {
            Alunos aluno1 = new Alunos();
            aluno1.RA = 10;
            aluno1.Nome = "Paula";
            aluno1.SobreNome = "Silva";

            List<Alunos> listaDeAlunos = new List<Alunos>();
            listaDeAlunos.Add(aluno1);
            listaDeAlunos.Add(new Alunos { Nome = "João", SobreNome = "Souza", RA = 110 });
            listaDeAlunos.Add(new Alunos { Nome = "Luciana", SobreNome = "Marques", RA = 115 });
            listaDeAlunos.Add(new Alunos { Nome = "Rafaela", SobreNome = "Rain", RA = 120 });
            listaDeAlunos.Add(new Alunos { Nome = "Gabriel", SobreNome = "Hula", RA = 130 });
            listaDeAlunos.Add(new Alunos { Nome = "Arthur", SobreNome = "Pereira", RA = 140 });
            listaDeAlunos.Add(new Alunos { Nome = "Marcelo", SobreNome = "Inacio", RA = 135 });
            return listaDeAlunos;
        }

    }
}