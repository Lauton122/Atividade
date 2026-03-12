using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
