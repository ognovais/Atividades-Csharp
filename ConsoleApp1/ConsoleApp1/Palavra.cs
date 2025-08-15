using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Palavra
    {
        public string Nome { get; set; }
        public List<Significado> Significados { get; set; }

        public Palavra(string nome)
        {
            this.Nome = nome;
            this.Significados = new List<Significado>();
        }

        public void AdicionarSignificado(Significado texto)
        {
            Significados.Add(texto);
        }

        public List<Significado> RecuperarSignificado()
        {
            return Significados;
        }

        public void RemoverSignificado(Significado texto)
        {
            Significados.Remove(texto);
        }

        public bool PesquisarSignificado(Significado texto)
        {
           return Significados.Contains(texto);
        }
        public override string ToString()
        {
            string significadosStr = string.Join(", ", Significados);
            return $"Nome: {Nome} | Significado: {significadosStr}";
        }
    }
}
