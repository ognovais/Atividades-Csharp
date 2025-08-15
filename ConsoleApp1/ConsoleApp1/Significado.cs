using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Significado
    {
        public string Texto { get; set; }

        public Palavra palavra { get; set; }

        public Significado(string texto, Palavra palavra)
        {
            Texto = texto;
            this.palavra = palavra;
        }

        public override string ToString()
        {
            return $"{Texto}";
        }
    }
}
