using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace WebApplicationASPNET.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int RA { get; set; }

        // método que retorna lista de alunos
        public List<Aluno> listaAlunos()
        {
            Aluno aluno1 = new Aluno();
            aluno1.RA = 10;
            aluno1.Nome = "Paula";
            aluno1.SobreNome = "Silva";

            List<Aluno> listaDeAlunos = new List<Aluno>();
            listaDeAlunos.Add(aluno1);
            listaDeAlunos.Add(new Aluno { Nome = "João", SobreNome = "Souza", RA = 110 });
            listaDeAlunos.Add(new Aluno { Nome = "Luciana", SobreNome = "Marques", RA = 115 });
            listaDeAlunos.Add(new Aluno { Nome = "Rafaela", SobreNome = "Rain", RA = 120 });
            listaDeAlunos.Add(new Aluno { Nome = "Gabriel", SobreNome = "Hula", RA = 130 });
            listaDeAlunos.Add(new Aluno { Nome = "Arthur", SobreNome = "Pereira", RA = 140 });
            listaDeAlunos.Add(new Aluno { Nome = "Marcelo", SobreNome = "Inacio", RA = 135 });
            return listaDeAlunos;
        }       

            public List<Aluno> listarAlunos()
        {
            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\DataBase.json");
            var json = File.ReadAllText(caminhoArquivo);
            var listaAlunos = JsonConvert.DeserializeObject<List<Aluno>>(json);

            return listaAlunos;
        }

        public bool rescreverAlunosArquivo(List<Aluno> lista)
        {
            var caminhoArquivo = HostingEnvironment.MapPath(@"~/App_Data\DataBase.json");
            var json = JsonConvert.SerializeObject(lista, Formatting.Indented);

            File.WriteAllText(caminhoArquivo, json);

            return true;
        }

        public Aluno Inserir(Aluno aluno)
        {
            var listaAlunos = this.listarAlunos();
            var maxRA = listaAlunos.Max(a => aluno.RA);
            aluno.RA = maxRA + 1;
            listaAlunos.Add(aluno);

            rescreverAlunosArquivo(listaAlunos);
            return aluno;
        }

        public Aluno Salvar(Aluno Aluno)
        {
            var listaAlunos = this.listarAlunos();
            Aluno.RA = listaAlunos.Max(p => p.RA) + 1;
            listaAlunos.Add(Aluno);

            this.rescreverAlunosArquivo(listaAlunos);

            return Aluno;
        }

        public Aluno Atualizar(int RA, Aluno Aluno)
        {
            var listaAlunos = this.listarAlunos();
            var itemIndex = listaAlunos.FindIndex(p => p.RA == RA);
            if (itemIndex >= 0)
            {
                listaAlunos[itemIndex] = Aluno;
            }
            else
            {
                return null;
            }

            this.rescreverAlunosArquivo(listaAlunos);
            return Aluno;
        }

        public bool Deletar(int RA)
        {
            var listaAlunos = this.listarAlunos();
            var itemIndex = listaAlunos.FindIndex(p => p.RA == RA);
            if (itemIndex >= 0)
            {
                listaAlunos.RemoveAt(itemIndex);
            }
            else
            {
                return false;
            }

            this.rescreverAlunosArquivo(listaAlunos);
            return true;
        }

    }
}